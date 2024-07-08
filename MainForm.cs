using AutoTF;
using Cap.FormEditor;
using Cap.Page.PLCControl;
using LogTool;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using AutoTF.Pages.Query;

namespace Cap
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static MainForm _instance;

        // 3. 提供一个公共的静态方法，用于获取单例对象
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(MainForm))
                    {
                        if (_instance == null)
                        {
                            _instance = new MainForm();
                        }
                    }
                }
                return _instance;
            }
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            Form_WorkOrderEditor editor = new Form_WorkOrderEditor();
            editor.Show();

            //添加拨盖任务

            //1. 添加一种药品的拨盖数量

            //2  添加多种药品的拨盖数量

            //选择未完成任务 

            //实时记录拨盖数量 进度


        }

        public void UpdateCurrentPLC(int prodoctNo, int finishCount)
        {
            if (InvokeRequired)
            {
                Invoke(
                    new Action(() =>
                    {
                        UpdateCurrentPLC(prodoctNo, finishCount);
                    }));
                return;
            }

            if (Global.CurrentFinishCount!=0 && Global.CurrentFinishCount==Global.TotalCount)
            {
                //当前任务完成
                uiLabel4.ForeColor = Color.Green;
                uiLabel4.Text = "任务完成";

                 /*  if (!Global.IsCurrentFinish)
                {
                    Global.IsCurrentFinish = true;
                   //SpeckMessage.SpeakAsync("任务完成");
                }*/
            }
            else
            {
                uiLabel4.ForeColor = Color.AliceBlue;
                uiLabel4.Text = "进行中";
            }

            lbl_TotalFinish.Text = finishCount.ToString();
            lblProductNo.Text = prodoctNo.ToString();
            lblFinishCount.Text = finishCount.ToString();
        }

        public void SetCurrentTaskUI(string DrugName, int totalCount, string imagePath)
        {
    /*        if (InvokeRequired)
            {
                Invoke(
                    new Action(() =>
                    {
                        SetCurrentTaskUI(DrugName, totalCount, imagePath);
                    }));
                return;
            }*/
            lblTotalSet.Text = totalCount.ToString();
            lblDrugName.Text = DrugName;
            lblTotalCount.Text = totalCount.ToString();
            lblFinishCount.Text = "0";
            pictureBox1.ImageLocation = imagePath;
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            bool flag = SystemParams.Instance.OpLvl == 10;
            if (!flag)
            {
                UIMessageBox.ShowError("权限不足！");
                return;
            }
            new PageProperty(SystemParams.Instance).ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SystemParams.Load();
            LoadPLCAlarmConfig();
            InitPages();

            LogMgr.Instance.Init();
            LogMgr.Instance.SetCtrl(listViewEx_Log1);
            listViewEx_Log1.BindingControl = listViewEx_Log1.Parent;
            LogMgr.Instance.Debug("打开软件");
            SystemParams.Instance.Login("ywh", 10, "超级管理员");
            Mainfunc.Instance.Start();
            Form_WorkOrderEditor.StartCapWorkEvent += Form_WorkOrderEditor_StartCapWorkEvent;
            Mainfunc.RecivePCLDataEvent += Mainfunc_RecivePCLDataEvent;
           
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        public void LoadPLCAlarmConfig()
        {
            #region    读取参数
            try
            {
                string path = "DATA";
                XmlDocument doc = new XmlDocument();
                doc.Load(path + "\\PLC参数设置.XML");
                XmlNode xn = doc.SelectSingleNode("参数");
                XmlElement xe11 = (XmlElement)xn;
                //得到根节点的所有子节点
                XmlNodeList xnl = xn.ChildNodes;
                Global.PlcAlarmList.Clear();
                for (int i = 0; i < xnl.Count; i++)
                {
                    try
                    {
                        XmlElement xe = (XmlElement)xnl[i];
                        PLCAlarmData pLC_DATA_ = new PLCAlarmData();
                        //节点名称 
                        pLC_DATA_.ID = xe.Name;
                        pLC_DATA_.Name = Convert.ToString(xe.GetAttribute("报警名称"));
                        pLC_DATA_.Address = Convert.ToString(xe.GetAttribute("地址"));
                        Global.PlcAlarmList.Add(pLC_DATA_);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                //  my_object.LOGS_disp(ex.Message);
            }
            #endregion
        }

        private void Mainfunc_RecivePCLDataEvent(int productID, int finishCount)
        {
            UpdateCurrentPLC(productID,finishCount);
        }

        private void Form_WorkOrderEditor_StartCapWorkEvent(string DrugName, int totalCount, string imagePath)
        {
            SetCurrentTaskUI(DrugName, totalCount, imagePath);
        }

        private void InitPages()
        {
            //拨盖机控制
            DeviceControlPage deviceControlPage = new DeviceControlPage();
            deviceControlPage.Dock = DockStyle.Fill;
            deviceControlPage.Show();
            tabPage2.Controls.Add(deviceControlPage);


            //药品配置
            PageDrugFormulaConfig drugFormulaConfig = new PageDrugFormulaConfig();
            drugFormulaConfig.Dock = DockStyle.Fill;
            drugFormulaConfig.Show();
            tabPage6.Controls.Add(drugFormulaConfig);

            //PLC报警配置
            Page_PLCAlarmConfigcs pagePlcAlarmConfig = new Page_PLCAlarmConfigcs();
            pagePlcAlarmConfig.Dock = DockStyle.Fill;
            pagePlcAlarmConfig.Show();
            tabPage8.Controls.Add(pagePlcAlarmConfig);

            PageUserQuery PageUserQuery = new PageUserQuery();
            PageUserQuery.Dock = DockStyle.Fill;
            PageUserQuery.Show();
            tabPage5.Controls.Add(PageUserQuery);
        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiTabControlMenu1.SelectedIndex == 1)
            {
                //打开拨盖机控制页面

                //tabPage2.Controls.Add(new DeviceControlPage());
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void cbxPrintStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

/*        public void Update_PLCStatus(bool isConnect)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    Update_PLCStatus(isConnect);
                });
                return;
            }

            //label1.Text = "测试中";
            lbl_PLCStatus.Refresh();
            if (isConnect)
            {
                lbl_PLCStatus.Visible =false;
                lbl_PLCStatus.Text = "PLC已连接";
                lbl_PLCStatus.ForeColor = Color.Black;
            }
            else
            {
                lbl_PLCStatus.Visible = true;
                lbl_PLCStatus.Text = "PLC断开";
                lbl_PLCStatus.ForeColor = Color.Red;
            }
        }*/

        private void uiLight1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            bool flag = UIMessageDialog.ShowAskDialog(sender as Form, "确定要退出吗?");
            if (flag)
            {
                try
                {
                    LogMgr.Instance.Info("退出程序");
                    e.Cancel = false;
                    Environment.Exit(1);
                }
                catch (Exception exception)
                {

                }
            }
        }

        private void lbl__Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            bool b = UIMessageDialog.ShowAskDialog(this,"确定开始消毒吗？");
            if (b)
            {

                Global.SiemensPLC.WriteInt32(PLCAddress.DisinfectTime, SystemParams.Instance.DisinfectTime);
                Global.SiemensPLC.WriteBool(PLCAddress.DisinfectStart, true);
            }
        }
    }
}
