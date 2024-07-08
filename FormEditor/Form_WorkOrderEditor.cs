using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTF.DBTool;
using Cap.Util;
using LogTool;
using Sunny.UI;

namespace Cap.FormEditor
{
    public partial class Form_WorkOrderEditor : UIForm
    {
        public Form_WorkOrderEditor()
        {
            InitializeComponent();
        }

        public string ImagePath;

        public string DrugName;

        public string DrugCode;

        public int DelayTime;
        private static Form_WorkOrderEditor _instance;

        // 3. 提供一个公共的静态方法，用于获取单例对象
        public static Form_WorkOrderEditor Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(Form_WorkOrderEditor))
                    {
                        if (_instance == null)
                        {
                            _instance = new Form_WorkOrderEditor();
                        }
                    }
                }
                return _instance;
            }
        }

        // 定义委托  
        public delegate void StartCapWorkHandle(string DrugName, int totalCount, string imagePath);

        // 定义事件  
        public static event StartCapWorkHandle StartCapWorkEvent;

    

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (PLCHelper.CheckPlcIsAlarm())
            {
                MessageBox.Show("设备报警中");
                return;
            }
            //下发配方给PLC
            //药品料号编号
            if (DrugName=="")
            {
                MessageBox.Show("药品名称不存在");
                return;
            }
            if (!int.TryParse(lblProductNo.Text, out int ProdoctID))
            {
                MessageBox.Show("料号格式错误");
                return;
            }
            if (tbx_Count.Text=="")
            {
                MessageBox.Show("任务数量不能为空");
                return;
            }

            int.TryParse(tbx_Count.Text, out int count);
            if (count==0)
            {
                MessageBox.Show("任务数量不能为0");
                return;
            }
            if (!int.TryParse(tbx_Height.Text, out int height))
            {
                MessageBox.Show("西林瓶高度格式错误");
                return;
            }
            if (!int.TryParse(tbx_Weight.Text, out int weight))

            {
                MessageBox.Show("西林瓶宽度格式错误");
                return;
            }

            if (!Global.IsPlc_Connected)
            {
                MessageBox.Show("请检查与PLC连接状态");
                return;
            }
            try
            {
                bool b = UIMessageDialog.ShowAskDialog(this, "请确认流道中无产品!");
                if (b)
                {
                    //MainForm.Instance.SetCurrentTaskUI(cbx_Drugs.SelectedItem.ToString(), uiIntegerUpDown1.Value, ImagePath);
                    StartCapWorkEvent?.Invoke(DrugName, count, ImagePath);
                    Global.SiemensPLC.WriteInt16(PLCAddress.ProdType, ProdoctID);
                    Global.SiemensPLC.WriteInt32(PLCAddress.Height, height);

                    Global.SiemensPLC.WriteInt32(PLCAddress.Weight, weight);
                    Global.SiemensPLC.WriteInt16(PLCAddress.TaskTotalCount, count);
                    Global.SiemensPLC.WriteInt16(PLCAddress.FinishCount, 0);

                    Global.SiemensPLC.WriteInt32(PLCAddress.DelayTime, DelayTime);
                    Global.TotalCount = count;
                    Global.CurrentFinishCount = 0;
                    Global.IsCurrentFinish = false;
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("错误:"+exception.Message);
                LogMgr.Instance.Error("下发拨盖任务 错误:"+exception.Message);
            }
         
        }

        private void uiCheckBox1_ValueChanged(object sender, bool value)
        {
    

        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uiCheckBox1.Checked)
            {
                tbx_Height.Enabled =true;
                tbx_Weight.Enabled =true;
                tbx_Delay.Enabled = true;
            }
            else
            {
                tbx_Height.Enabled = false;
                tbx_Weight.Enabled = false;
                tbx_Delay.Enabled = false;
            }
        }

        private void Form_WorkOrderEditor_Load(object sender, EventArgs e)
        {
            List<tbDrugConfig> list = DBCommander.GetAllDrugConfig();
            if (list.Any())
            {
                cbx_Drugs.DataSource = list;
                cbx_Drugs.DisplayMember = "DrugName";
            }
            else
            {
                MessageBox.Show("获取药品配方信息失败");
            }
          
            Win10key.StartKeyBoardFun();
        }



        private void cbx_Drugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDrugConfig item = cbx_Drugs.SelectedItem as tbDrugConfig;
            if (item != null)
            {
                lblProductNo.Text = item.ProductNo.ToString();
                tbx_Height.Text =item.PLC_Height.ToString();
                tbx_Weight.Text = item.PLC_Weight.ToString();
                tbx_Delay.Text = item.Delay.ToString();
                pictureBox1.ImageLocation = item.ImagePath;
                ImagePath = item.ImagePath;
                DrugName = item.DrugName;
                DrugCode =item.DrugCode;
                int.TryParse(item.Delay, out int delay); 
                DelayTime = delay;
            }
            else
            {
                lblProductNo.Text = "";
                tbx_Height.Text = "";
                tbx_Weight.Text = "";
           

                DrugName = "";
                DrugCode = "";
                DelayTime = 0;
            }
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
