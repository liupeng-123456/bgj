using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTF.DBTool;
using LogTool;
using Sunny.UI;

namespace Cap.FormEditor
{
    public partial class Form_WorkOrderAdd : UIForm
    {
        public Form_WorkOrderAdd()
        {
            InitializeComponent();
        }

        public string ImagePath;

        public string DrugName;

        public string DrugCode;

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

        private void uiButton2_Click(object sender, EventArgs e)
        {
            //下发配方给PLC
            //药品料号编号
            if (!int.TryParse(tbx_ProductNO.Text, out int ProdoctID))
            {
                MessageBox.Show("料号格式错误");
                return;
            }
            if (!double.TryParse(tbx_Height.Text, out double height))
            {
                MessageBox.Show("西林瓶高度格式错误");
                return;
            }
            if (!double.TryParse(tbx_Weight.Text, out double weight))
            {
                MessageBox.Show("西林瓶外径格式错误");
                return;
            }
            if (!int.TryParse(tbx_Delay.Text, out int d))

            {
                MessageBox.Show("西林瓶延时格式错误");
                return;
            }
            string delay = tbx_Delay.Text;

            if (DrugName=="" || DrugCode=="")
            {
                MessageBox.Show("药品名称为空");
                return;
            }
            string unit = tbx_Unit.Text;
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext(1))
                {
                    tbDrugConfig drugConfig = db.tbDrugConfig.FirstOrDefault(r => r.DrugCode == DrugCode);
               
                    if (drugConfig!=null)
                    {
                        bool flag = UIMessageDialog.ShowAskDialog(this,"药品已经存在配方，确认修改？");
                        if (flag)
                        {
                            drugConfig.ProductNo = ProdoctID;
                            drugConfig.height = height.ToString();
                            drugConfig.diameter = weight.ToString();
                            drugConfig.Delay = delay;


                            drugConfig.PLC_Height = GetHeight(height);
                            drugConfig.PLC_Weight = GetWeight(weight);
                            drugConfig.InsertDate = DateTime.Now;
                            drugConfig.DrugName = DrugName;
                            drugConfig.DrugUnit = unit;
                            drugConfig.DrugCode = DrugCode;
                            drugConfig.ImagePath = ImagePath;
                        }
                    }
                    else
                    {
                        drugConfig = new tbDrugConfig();
                        drugConfig.ProductNo = ProdoctID;
                        drugConfig.height = height.ToString();
                        drugConfig.diameter = weight.ToString();

                        drugConfig.Delay = delay;

                        drugConfig.PLC_Height = GetHeight(height);
                        drugConfig.PLC_Weight = GetWeight(weight);
                        drugConfig.InsertDate = DateTime.Now;
                        drugConfig.DrugName = DrugName;
                        drugConfig.DrugUnit = unit;
                        drugConfig.DrugCode = DrugCode;
                        drugConfig.ImagePath = ImagePath;
                        bool b = UIMessageDialog.ShowAskDialog(this, "确认保存药品配方吗");
                        if (!b)
                        {
                           return;
                        }
                        db.tbDrugConfig.InsertOnSubmit(drugConfig);

                    }
                    db.SubmitChanges();
                    MessageBox.Show("保存成功");
                    this.Close();
                    return;
                }
            }
            catch (Exception exception)
            {
               LogMgr.Instance.Error("保存药品配方错误:"+exception.Message);
            }
        }

        /// <summary>
        /// 拨盖高度
        /// </summary>
        /// <returns></returns>
        public int GetHeight(double a)
        {
            //原点盘上方到进料线高度 81 
            //上盖高度 8.5

            int value =0;

            double v =  81 - (a - 8.5);
            value = (int)(v * 100);
            return value;
        }

        /// <summary>
        /// 拨盖高度
        /// </summary>
        /// <returns></returns>
        public int GetWeight(double d)
        {
            int value = 0;
            //取反
            double v =- (32 -(d/2));
            value = (int)(v * 100);
            return value;
        }


        private void Form_WorkOrderEditor_Load(object sender, EventArgs e)
        {
            List<tbTestDrug> list = DBCommander.GetAllDrugName();
            if (list.Any())
            {
                cbx_Drugs.DataSource = list;
                cbx_Drugs.DisplayMember = "DrugName";
            }
            else
            {
                MessageBox.Show("获取系统药品列表失败");
            }
        }

        private void cbx_Drugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTestDrug item = cbx_Drugs.SelectedItem as tbTestDrug;

            if (item != null)
            {
                tbDrugConfig config = DBCommander.GetDrugConfig(item.DrugCode);
                if (config != null)
                {
                    tbx_Delay.Text = config.Delay;

                    tbx_ProductNO.Text = config.ProductNo.ToString();
                    tbx_Height.Text = config.height.ToString();
                    tbx_Weight.Text = config.diameter.ToString();
                    tbx_Unit.Text = config.DrugUnit;
                    pictureBox1.ImageLocation = config.ImagePath;
                    ImagePath = config.ImagePath;
                    DrugCode = item.DrugCode;
                    DrugName =item.DrugName;
                    tbx_ImagePath.Text = ImagePath;
                    return;
                }
                else
                {
                    DrugCode = item.DrugCode;
                    DrugName = item.DrugName;
                }
            }
            else
            {
                DrugCode = "";
                DrugName = "";
            }
            tbx_Delay.Text = "";

            tbx_ProductNO.Text = "";
            tbx_Height.Text = "";
            tbx_Weight.Text = "";
            tbx_Unit.Text = "";
            ImagePath = "";
            pictureBox1.ImageLocation = ImagePath;
            tbx_ImagePath.Text = "";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();
            frm.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            frm.Multiselect = false;
            frm.Filter = "图片(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            var result = frm.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            tbx_ImagePath.Text = ImagePath;
            ImagePath = frm.FileName;
            pictureBox1.ImageLocation = ImagePath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
