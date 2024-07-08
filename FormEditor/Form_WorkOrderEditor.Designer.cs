namespace Cap.FormEditor
{
    partial class Form_WorkOrderEditor
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
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.lblProductNo = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_Count = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tbx_Delay = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Drugs
            // 
            this.cbx_Drugs.DataSource = null;
            this.cbx_Drugs.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbx_Drugs.DropDownWidth = 250;
            this.cbx_Drugs.FillColor = System.Drawing.Color.White;
            this.cbx_Drugs.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_Drugs.ItemHeight = 45;
            this.cbx_Drugs.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbx_Drugs.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbx_Drugs.Location = new System.Drawing.Point(16, 79);
            this.cbx_Drugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Drugs.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbx_Drugs.Name = "cbx_Drugs";
            this.cbx_Drugs.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbx_Drugs.ScrollBarHandleWidth = 22;
            this.cbx_Drugs.Size = new System.Drawing.Size(376, 64);
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
            this.uiButton2.Location = new System.Drawing.Point(111, 336);
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
            this.uiLabel1.Location = new System.Drawing.Point(420, 54);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(89, 67);
            this.uiLabel1.TabIndex = 18;
            this.uiLabel1.Text = "高度：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(420, 107);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 67);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "宽度：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_Height
            // 
            this.tbx_Height.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Height.Enabled = false;
            this.tbx_Height.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Height.Location = new System.Drawing.Point(502, 65);
            this.tbx_Height.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Height.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Height.Name = "tbx_Height";
            this.tbx_Height.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Height.ShowText = false;
            this.tbx_Height.Size = new System.Drawing.Size(229, 37);
            this.tbx_Height.TabIndex = 87;
            this.tbx_Height.Text = "0";
            this.tbx_Height.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Height.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbx_Height.Watermark = "输入西林瓶高度";
            // 
            // tbx_Weight
            // 
            this.tbx_Weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Weight.Enabled = false;
            this.tbx_Weight.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Weight.Location = new System.Drawing.Point(502, 123);
            this.tbx_Weight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Weight.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Weight.Name = "tbx_Weight";
            this.tbx_Weight.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Weight.ShowText = false;
            this.tbx_Weight.Size = new System.Drawing.Size(229, 37);
            this.tbx_Weight.TabIndex = 88;
            this.tbx_Weight.Text = "0";
            this.tbx_Weight.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Weight.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbx_Weight.Watermark = "输入西林瓶宽度";
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox1.Location = new System.Drawing.Point(421, 222);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(76, 56);
            this.uiCheckBox1.TabIndex = 89;
            this.uiCheckBox1.Text = "修改";
            this.uiCheckBox1.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox1_ValueChanged);
            this.uiCheckBox1.CheckedChanged += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(25, 230);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(136, 67);
            this.uiLabel3.TabIndex = 90;
            this.uiLabel3.Text = "PLC料号：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductNo
            // 
            this.lblProductNo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblProductNo.Location = new System.Drawing.Point(170, 230);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(68, 67);
            this.lblProductNo.TabIndex = 91;
            this.lblProductNo.Text = "0";
            this.lblProductNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(477, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_Count
            // 
            this.tbx_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Count.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Count.Location = new System.Drawing.Point(121, 177);
            this.tbx_Count.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Count.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Count.Name = "tbx_Count";
            this.tbx_Count.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Count.ShowText = false;
            this.tbx_Count.Size = new System.Drawing.Size(229, 40);
            this.tbx_Count.TabIndex = 93;
            this.tbx_Count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Count.Watermark = "输入剥盖数量";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(28, 162);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(89, 67);
            this.uiLabel4.TabIndex = 94;
            this.uiLabel4.Text = "数量：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // tbx_Delay
            // 
            this.tbx_Delay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_Delay.Enabled = false;
            this.tbx_Delay.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Delay.Location = new System.Drawing.Point(502, 180);
            this.tbx_Delay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbx_Delay.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbx_Delay.Name = "tbx_Delay";
            this.tbx_Delay.Padding = new System.Windows.Forms.Padding(5);
            this.tbx_Delay.ShowText = false;
            this.tbx_Delay.Size = new System.Drawing.Size(229, 37);
            this.tbx_Delay.TabIndex = 96;
            this.tbx_Delay.Text = "0";
            this.tbx_Delay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbx_Delay.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbx_Delay.Watermark = "输入西林瓶宽度";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(420, 162);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(89, 67);
            this.uiLabel5.TabIndex = 95;
            this.uiLabel5.Text = "延时:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_WorkOrderEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(753, 465);
            this.Controls.Add(this.tbx_Delay);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.tbx_Count);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProductNo);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiCheckBox1);
            this.Controls.Add(this.tbx_Weight);
            this.Controls.Add(this.tbx_Height);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.cbx_Drugs);
            this.Name = "Form_WorkOrderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "拨盖任务设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Form_WorkOrderEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox cbx_Drugs;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbx_Height;
        private Sunny.UI.UITextBox tbx_Weight;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lblProductNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox tbx_Count;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox tbx_Delay;
        private Sunny.UI.UILabel uiLabel5;
    }
}