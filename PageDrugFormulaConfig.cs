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
using Cap.FormEditor;
using Sunny.UI;

namespace Cap
{
    public partial class PageDrugFormulaConfig : UIPage
    {
        public PageDrugFormulaConfig()
        {
            InitializeComponent();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 添加药品配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            Form_WorkOrderAdd form = new Form_WorkOrderAdd();
            form.ShowDialog();

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            List<tbDrugConfig> list = DBCommander.GetAllDrugConfig();

            if (string.IsNullOrEmpty(uiTextBox1.Text))
            {
                //重新初始化查询所有
                list = DBCommander.GetAllDrugConfig();
            }
            else
            {
                string name = uiTextBox1.Text;
                list = DBCommander.GetAllDrugConfigByName(name);
            }

            if (!list.Any())
            {
                UIMessageDialog.ShowErrorDialog(this, "查询失败");
                return;
            }
            dgv.Rows.Clear();
            dgv.SuspendLayout();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = item.ID;
                row.Cells[1].Value = item.DrugName;
                row.Cells[2].Value = item.DrugUnit;
                row.Cells[3].Value = item.ProductNo;
                row.Cells[4].Value = item.diameter;
                row.Cells[5].Value = item.height;
                row.Cells[6].Value = item.InsertDate;
                row.Cells[7].Value = item.ImagePath;
                row.Cells[8].Value = item.DrugCode;

                row.Cells[9].Value = item.PLC_Weight;
                row.Cells[10].Value = item.PLC_Height;
                row.Cells[11].Value = item.Delay;
                //row.Cells[8].Value = item.IsUseOCR;
                dgv.Rows.Add(row);
            }
            dgv.ResumeLayout();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {

        }

        private void PageDrugFormulaConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
