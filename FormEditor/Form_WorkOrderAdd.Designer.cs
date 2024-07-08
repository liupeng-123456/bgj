using System;

namespace Cap.FormEditor
{
    partial class Form_WorkOrderAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Drugs = new Sunny.UI.UIComboBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbx_Height = new Sunny.UI.UITextBox();
            this.tbx_Weight = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.tbx_ProductNO = new Sunny.UI.UITextBox();
            this.tbx_Unit = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbx_ImagePath = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbx_Delay = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Drugs
            // 
            this.cbx_Drugs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cbx_Drugs.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.cbx_Drugs.DataSource = null;
            this.cbx_Drugs.DropDownAutoWidth = true;
            this.cbx_Drugs.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbx_Drugs.FillColor = System.Drawing.Color.White;
            this.cbx_Drugs.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_Drugs.ItemHeight = 40;
            this.cbx_Drugs.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbx_Drugs.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbx_Drugs.Location = new System.Drawing.Point(31, 61);
            this.cbx_Drugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Drugs.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx_Drugs.Name = "cbx_Drugs";
            this.cbx_Drugs.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbx_Drugs.Radius = 2;
            this.cbx_Drugs.ScrollBarHandleWidth = 22;
            this.cbx_Drugs.Size = new System.Drawing.Size(384, 62);
            this.cbx_Drugs.SymbolSize = 24;
            this.cbx_Drugs.TabIndex = 9;
            this.cbx_Drugs.Text = "药品名称";
            this.cbx_Drugs.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbx_Drugs.Watermark = "";
            this.cbx_Drugs.SelectedIndexChanged += new System.EventHandler(this.cbx_Drugs_SelectedIndexChanged);
            // 
            // uiButton2
            // 
            this.uiButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(315, 449);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 56);
            this.uiButton2.TabIndex = 16;
            this.uiButton2.Text = "确定";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(52, 140);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(89, 67);
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "瓶高：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(52, 192);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 67);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "外径：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_Height
            // 
            this.tbx_Height.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Height.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Height.Location = new System.Drawing.Point(134, 151);
            this.tbx_Height.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Height.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Height.Name = "tbx_Height";
            this.tbx_Height.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Height.ShowText = false;
            this.tbx_Height.Size = new System.Drawing.Size(229, 37);
            this.tbx_Height.TabIndex = 87;
            this.tbx_Height.Text = "0.00";
            this.tbx_Height.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Height.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbx_Height.Watermark = "输入西林瓶高度";
            // 
            // tbx_Weight
            // 
            this.tbx_Weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Weight.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Weight.Location = new System.Drawing.Point(134, 209);
            this.tbx_Weight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Weight.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Weight.Name = "tbx_Weight";
            this.tbx_Weight.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Weight.ShowText = false;
            this.tbx_Weight.Size = new System.Drawing.Size(229, 37);
            this.tbx_Weight.TabIndex = 88;
            this.tbx_Weight.Text = "0.00";
            this.tbx_Weight.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Weight.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbx_Weight.Watermark = "输入西林瓶宽度";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(25, 358);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(136, 67);
            this.uiLabel3.TabIndex = 90;
            this.uiLabel3.Text = "PLC料号：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(392, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(347, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uiButton1
            // 
            this.uiButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(532, 77);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 56);
            this.uiButton1.TabIndex = 93;
            this.uiButton1.Text = "上传图片";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // tbx_ProductNO
            // 
            this.tbx_ProductNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_ProductNO.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_ProductNO.Location = new System.Drawing.Point(134, 375);
            this.tbx_ProductNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_ProductNO.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_ProductNO.Name = "tbx_ProductNO";
            this.tbx_ProductNO.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_ProductNO.ShowText = false;
            this.tbx_ProductNO.Size = new System.Drawing.Size(229, 37);
            this.tbx_ProductNO.TabIndex = 94;
            this.tbx_ProductNO.Text = "0";
            this.tbx_ProductNO.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_ProductNO.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbx_ProductNO.Watermark = "输入PLC对应料号";
            // 
            // tbx_Unit
            // 
            this.tbx_Unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Unit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Unit.Location = new System.Drawing.Point(134, 319);
            this.tbx_Unit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Unit.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Unit.Name = "tbx_Unit";
            this.tbx_Unit.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Unit.ShowText = false;
            this.tbx_Unit.Size = new System.Drawing.Size(229, 37);
            this.tbx_Unit.TabIndex = 95;
            this.tbx_Unit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Unit.Watermark = "输入西林瓶规格";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(52, 312);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(75, 44);
            this.uiLabel4.TabIndex = 96;
            this.uiLabel4.Text = "规格:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_ImagePath
            // 
            this.tbx_ImagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_ImagePath.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_ImagePath.Location = new System.Drawing.Point(392, 150);
            this.tbx_ImagePath.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_ImagePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_ImagePath.Name = "tbx_ImagePath";
            this.tbx_ImagePath.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_ImagePath.ShowText = false;
            this.tbx_ImagePath.Size = new System.Drawing.Size(347, 37);
            this.tbx_ImagePath.TabIndex = 97;
            this.tbx_ImagePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_ImagePath.Watermark = "图片路径";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(52, 259);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(75, 44);
            this.uiLabel5.TabIndex = 98;
            this.uiLabel5.Text = "延时:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_Delay
            // 
            this.tbx_Delay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Delay.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Delay.Location = new System.Drawing.Point(134, 266);
            this.tbx_Delay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Delay.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Delay.Name = "tbx_Delay";
            this.tbx_Delay.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Delay.ShowText = false;
            this.tbx_Delay.Size = new System.Drawing.Size(229, 37);
            this.tbx_Delay.TabIndex = 99;
            this.tbx_Delay.Text = "0";
            this.tbx_Delay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Delay.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbx_Delay.Watermark = "输入延迟的时间";
            // 
            // Form_WorkOrderAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(753, 537);
            this.Controls.Add(this.tbx_Delay);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.tbx_ImagePath);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.tbx_Unit);
            this.Controls.Add(this.tbx_ProductNO);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.tbx_Weight);
            this.Controls.Add(this.tbx_Height);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.cbx_Drugs);
            this.Name = "Form_WorkOrderAdd";
            this.Text = "添加西林瓶配方";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Form_WorkOrderEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbx_Height;
        private Sunny.UI.UITextBox tbx_Weight;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox tbx_ProductNO;
        private Sunny.UI.UITextBox tbx_Unit;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Sunny.UI.UITextBox tbx_ImagePath;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbx_Delay;
        private Sunny.UI.UIComboBox cbx_Drugs;

        public EventHandler tbx_Weight_TextChanged { get; private set; }
    }
}