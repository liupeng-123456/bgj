using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTF;
using Cap;
using LogTool;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using YWHUtil.AlarmNotify;

namespace Cap
{
    public partial class DeviceControlPage : UIPage
    {
        public DeviceControlPage()
        {
            InitializeComponent();
            InitAlarmInfo();
            // 订阅AlarmEvent事件  
            AlarmManager.AlarmEvent += HandleAlarmEvent;
        }
       

        private void HandleAlarmEvent(string msg, AlarmManager.AlarmEnum alarmType)
        {
            if (msg.IsNullOrEmpty())
            {
                return;
            }
            else
            {
                msg = $"{DateTime.Now:yyyy-MM-dd:hh-mm-ss fff}:{msg}";
            }

            if (alarmType == AlarmManager.AlarmEnum.Info)
            {
                AppendLogInfo(msg);
            }
            else if (alarmType == AlarmManager.AlarmEnum.Alarm)
            {
                AppendLogAlarm(msg);
            }
            else
            {
                AppendLogErr(msg);
            }

        }
        private void AppendLogInfo(string msg)
        {
            if (InvokeRequired)
            {
                uiListBox2.Invoke(
                    new Action(() =>
                    {
                        AppendLogInfo(msg);
                    }));
                return;
            }
            if (uiListBox2.Items.Contains(msg))
            {

            }
            else
            {
                //uiListBox2.ForeColor = Color.Green;

                uiListBox2.Items.Add(msg);
                //int count = uiListBox2.Items.Count;
            }
        }

        private void AppendLogAlarm(string msg)
        {
            if (InvokeRequired)
            {
                uiListBox2.Invoke(
                    new Action(() =>
                    {
                        AppendLogAlarm(msg);
                    }));
                return;
            }
            if (uiListBox2.Items.Contains(msg))
            {

            }
            else
            {
                //uiListBox2.ForeColor = Color.Yellow;
                uiListBox2.Items.Add(msg);
            }
        }

        private void AppendLogErr(string msg)
        {
            if (InvokeRequired)
            {
                uiListBox2.Invoke(
                    new Action(() =>
                    {
                        AppendLogErr(msg);
                    }));
                return;
            }
            if (uiListBox2.Items.Contains(msg))
            {

            }
            else
            {
                //uiListBox2.ForeColor = Color.Red;
                uiListBox2.Items.Add(msg);
            }
        }

        /// <summary>
        /// 初始化完成
        /// </summary>
        public bool IsFirstFinishInit = true;

        /// <summary>
        /// 任务完成
        /// </summary>
        public bool IsTaskFinish = true;

        /// <summary>
        /// 设备停止中
        /// </summary>
        public bool IsFirstStop = true;

        private void InitAlarmInfo()
        {

        }

        public Dictionary<string, string> AlarmMap = new Dictionary<string, string>()
        {

        };

        private void ClearAlarm()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(
                        new Action(ClearAlarm));

                }
                else
                {
                    if (uiListBox1.Items.Count<=0)
                    {
                        return;
                    }
                    uiListBox1.Items.Clear();
                }
            }
            catch { }


        }

        private void AddInfo(string msg)
        {
            if (InvokeRequired)
            {
                uiListBox1.Invoke(
                    new Action(() =>
                    {
                        AddInfo(msg);
                    }));
                return;
            }
            if (uiListBox1.Items.Contains(msg))
            {

            }
            else
            {
                uiListBox1.ForeColor = Color.Green;
                uiListBox1.Items.Add(msg);
            }
        }

        private void AddAlarm(string msg)
        {
            if (InvokeRequired)
            {
                uiListBox1.Invoke(
                    new Action(() =>
                    {
                        AddAlarm(msg);
                    }));
                return;
            }

            if (uiListBox1.Items.Contains(msg))
            {

            }
            else
            {
                uiListBox1.ForeColor = Color.Red;
                uiListBox1.Items.Add(msg);
            }
        }
        /// <summary>
        /// 持续监控设备状态
        /// </summary>
        private void ReflashStatus()
        {
            string alarmAddressPre = "DB533.";
            bool isFinish = false;
            while (true)
            {
                ClearAlarm();
                if (Global.IsPlc_Connected)
                {
                    Global.IsDeviceAlarm = false;
                    foreach (PLCAlarmData data in Global.PlcAlarmList)
                    {
                        string address = alarmAddressPre + data.Address;
                        Global.SiemensPLC.ReadBool(address, out bool res);
                        if (res)
                        {
                            Global.IsDeviceAlarm = true;
                            AddAlarm(data.Name);
                        }
                    }
                    UpdateLight(true);
                    //设备停止信号
                    //Global.SiemensPLC.ReadBool(PLCAddress.StopSignal, out bool isStop);
                    Global.SiemensPLC.ReadBool(PLCAddress.TaskFinish, out bool isTaskFinish);
                    if ( isTaskFinish)
                    {
                        if (!Global.IsCurrentFinish)
                        {
                            Global.IsCurrentFinish = true;
                            //SpeckMessage.SpeakAsync("任务完成");
                        }
                        Global.SiemensPLC.WriteBool(PLCAddress.TaskFinish, false);
                        SpeckMessage.SpeakAsync("任务完成");
                        LogMgr.Instance.Info("任务完成");
                        IsTaskFinish = false;
                    }

                    Global.SiemensPLC.ReadBool(PLCAddress.DisinfectFinish, out bool isDisinfectFinish);
                    if (isDisinfectFinish)
                    {
                        Global.SiemensPLC.WriteBool(PLCAddress.DisinfectFinish, false);
                        SpeckMessage.SpeakAsync("消毒完成");
                        LogMgr.Instance.Info("消毒完成");
                    }

                    Global.SiemensPLC.ReadBool(PLCAddress.ManualSwitch, out bool isManual);

                    Global.SiemensPLC.ReadBool(PLCAddress.InitFinish, out isFinish );
                   
           /*         if (signal == 10)
                    {
                        isFinish = true;
                    }
                    else
                    {
                        isFinish=false;
                    }*/

                    if (IsFirstFinishInit && isFinish)
                    {
                        SpeckMessage.SpeakAsync("设备初始化完成");
                        IsFirstFinishInit = false;
                    }

                    UpdateUICtrl(isManual, isFinish);
                    /*    Global.SiemensPLC.ReadBool(PLCAddress.Belt1Shield, out bool belt1Shield);

                        Global.SiemensPLC.ReadBool(PLCAddress.Belt2Shield, out bool belt2Shield);

                        Global.SiemensPLC.ReadBool(PLCAddress.VisionShield, out bool visionShield);

                        Global.SiemensPLC.ReadBool(PLCAddress.ScannerShield, out bool ScannerShield);

                        UpdateUICtrl(isStop, isManual, isFinish, belt1Shield, belt2Shield, visionShield, ScannerShield);*/
                }
                else
                {
                    UpdateLight(false);
                    AddAlarm("PLC连接断开");
                }
                Thread.Sleep(1000);
            }
        }

        private void UpdateUICtrl(bool isManual, bool isFinish)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    UpdateUICtrl( isManual, isFinish);
                });
                return;
            }

            uiTurnSwitch2.Active = isManual;

            if (isFinish)
            {
                uiLabel2.Text = "初始化完成";
                uiLabel2.ForeColor = Color.Green;
            }
            else
            {
                uiLabel2.Text = "未初始化";
                uiLabel2.ForeColor = Color.Gray;
            }
        }


        private void UpdateUIStatus()
        {
            // 使用Control.Invoke将操作传递给UI线程执行
            this.Invoke((MethodInvoker)delegate
            {
                if (!Global.IsPlc_Connected)
                {
                    uiLight1.State = UILightState.Off;
                    return;
                }
                uiLight1.State = UILightState.On;

                // 设备停止信号
                /*               Global.SiemensPLC.ReadBool(PLCAddress.StopSignal, out bool isStop);

                               Global.SiemensPLC.ReadBool(PLCAddress.ManualSwitch, out bool isManual);
                               uiTurnSwitch2.Active = isManual;

                               Global.SiemensPLC.ReadBool(PLCAddress.InitFinish, out bool isFinish);
                               if (isFinish)
                               {
                                   uiLabel2.Text = "初始化完成";
                                   uiLabel2.ForeColor = Color.Green;
                               }
                               else
                               {
                                   uiLabel2.Text = "未初始化";
                                   uiLabel2.ForeColor = Color.Gray;
                               }*/

                /*                Global.SiemensPLC.ReadBool(PLCAddress.Belt1Shield, out bool belt1Shield);
                                uiSwitch1.Active = belt1Shield;

                                Global.SiemensPLC.ReadBool(PLCAddress.Belt2Shield, out bool belt2Shield);
                                uiSwitch2.Active = belt2Shield;

                                Global.SiemensPLC.ReadBool(PLCAddress.VisionShield, out bool visionShield);
                                uiSwitch3.Active = visionShield;

                                Global.SiemensPLC.ReadBool(PLCAddress.ScannerShield, out bool scannerShield);
                                uiSwitch4.Active = scannerShield;*/
            });
        }
        private void UpdateLight(bool isConnect)
        {
            if (uiLight1.InvokeRequired)
            {
                uiLight1.Invoke((MethodInvoker)delegate
                {
                    UpdateLight(isConnect);
                });
                return;
            }
            // MainForm.Instance.Update_PLCStatus(isConnect);
            if (isConnect)
            {

                uiLight1.State = UILightState.On;
            }
            else
            {
                uiLight1.State = UILightState.Off;
            }

        }

        private void uiTurnSwitch1_ValueChanged(object sender, bool value)
        {
            //1是停止  False 是启动
            if (Global.IsPlc_Connected)
            {
                try
                {
                    bool b = Global.SiemensPLC.WriteBool(PLCAddress.StopSignal, !value);
                }
                catch (Exception e)
                {
                    MessageBox.Show("控制失败，" + e.Message);
                }
            }
        }

        private void uiTurnSwitch2_ValueChanged(object sender, bool value)
        {
            if (Global.IsPlc_Connected)
            {
                try
                {
                    //自动写0 手动写1
                    bool b = Global.SiemensPLC.WriteBool(PLCAddress.ManualSwitch, value);
                }
                catch (Exception e)
                {
                    MessageBox.Show("控制失败，" + e.Message);
                }
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            IsFirstFinishInit = true;
            if (Global.IsPlc_Connected)
            {
                try
                {
                    bool b = Global.SiemensPLC.WriteInt16(PLCAddress.InitSingal, 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("控制失败，" + ex.Message);
                }
            }
        }

        private void uiLight1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }



        private void uiButton2_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void uiButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Global.IsPlc_Connected)
            {
                try
                {
                    //上位机复位按钮
                    bool b = Global.SiemensPLC.WriteBool(PLCAddress.InitSingal, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("初始化失败，" + ex.Message);
                }
            }
        }

        private void uiButton1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Global.IsPlc_Connected)
            {
                try
                {
                    //上位机复位按钮
                    Thread.Sleep(100);
                    bool b = Global.SiemensPLC.WriteBool(PLCAddress.InitSingal, false);
                    UIMessageTip.Show("正在初始化...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("初始化失败，" + ex.Message);
                }
            }
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.IsPlc_Connected)
            {
                try
                {
                    Global.SiemensPLC.WriteBool(PLCAddress.StopSignal, true);
                    Thread.Sleep(100);
                    bool b = Global.SiemensPLC.WriteBool(PLCAddress.StopSignal, false);
                    UIMessageTip.Show("触发停止");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("初始化失败，" + ex.Message);
                }
            }
        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //这个操作很快
            if (Global.IsPlc_Connected)
            {
                try
                {
                    //上位机复位按钮
                    Global.SiemensPLC.WriteInt16(PLCAddress.DeviceReset, 1);
                    Thread.Sleep(100);
                    Global.SiemensPLC.WriteInt16(PLCAddress.DeviceReset, 0);
                    SpeckMessage.SpeakAsync("复位完成");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("复位失败，" + ex.Message);
                }
            }
        }

        private void DeviceControlPage_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(ReflashStatus);
            t.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
