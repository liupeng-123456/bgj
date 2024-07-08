using System.Windows.Forms;

namespace Cap
{
    partial class DeviceControlPage
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiListBox2 = new Sunny.UI.UIListBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTurnSwitch2 = new Sunny.UI.UITurnSwitch();
            this.btn1 = new System.Windows.Forms.Button();
            this.uiLight1 = new Sunny.UI.UILight();
            this.button1 = new System.Windows.Forms.Button();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.button1);
            this.uiPanel1.Controls.Add(this.button2);
            this.uiPanel1.Controls.Add(this.uiLabel9);
            this.uiPanel1.Controls.Add(this.uiListBox2);
            this.uiPanel1.Controls.Add(this.uiLabel8);
            this.uiPanel1.Controls.Add(this.uiListBox1);
            this.uiPanel1.Controls.Add(this.uiLabel7);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiTurnSwitch2);
            this.uiPanel1.Controls.Add(this.btn1);
            this.uiPanel1.Controls.Add(this.uiLight1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1851, 1007);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.uiPanel1.Click += new System.EventHandler(this.uiPanel1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("黑体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(366, 180);
            this.button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 93);
            this.button2.TabIndex = 24;
            this.button2.Text = "复位";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(17, 388);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(233, 49);
            this.uiLabel9.TabIndex = 23;
            this.uiLabel9.Text = "运行日志";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiListBox2
            // 
            this.uiListBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiListBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiListBox2.ItemSelectForeColor = System.Drawing.Color.White;
            this.uiListBox2.Location = new System.Drawing.Point(22, 444);
            this.uiListBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox2.Name = "uiListBox2";
            this.uiListBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox2.ScrollBarWidth = 5;
            this.uiListBox2.ShowText = false;
            this.uiListBox2.Size = new System.Drawing.Size(750, 468);
            this.uiListBox2.TabIndex = 22;
            this.uiListBox2.Text = "设备报警信息";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(846, 388);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(233, 49);
            this.uiLabel8.TabIndex = 21;
            this.uiLabel8.Text = "报警信息实时";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.Click += new System.EventHandler(this.uiLabel8_Click);
            // 
            // uiListBox1
            // 
            this.uiListBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiListBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.White;
            this.uiListBox1.Location = new System.Drawing.Point(852, 444);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.ShowText = false;
            this.uiListBox1.Size = new System.Drawing.Size(821, 468);
            this.uiListBox1.TabIndex = 20;
            this.uiListBox1.Text = "设备报警信息";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(598, 193);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(168, 67);
            this.uiLabel7.TabIndex = 17;
            this.uiLabel7.Text = "PLC连接状态";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(758, 59);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(165, 67);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "未初始化";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(598, 59);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(168, 67);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "初始化状态：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTurnSwitch2
            // 
            this.uiTurnSwitch2.ActiveColor = System.Drawing.Color.DarkOrange;
            this.uiTurnSwitch2.ActiveText = "手动";
            this.uiTurnSwitch2.BackSize = 120;
            this.uiTurnSwitch2.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch2.InActiveColor = System.Drawing.Color.Lime;
            this.uiTurnSwitch2.InActiveText = "自动";
            this.uiTurnSwitch2.Location = new System.Drawing.Point(52, 63);
            this.uiTurnSwitch2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch2.Name = "uiTurnSwitch2";
            this.uiTurnSwitch2.Size = new System.Drawing.Size(272, 201);
            this.uiTurnSwitch2.TabIndex = 6;
            this.uiTurnSwitch2.Text = "设备停止";
            this.uiTurnSwitch2.ValueChanged += new Sunny.UI.UITurnSwitch.OnValueChanged(this.uiTurnSwitch2_ValueChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("黑体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(366, 52);
            this.btn1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(170, 93);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "初始化";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.uiButton1_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiButton1_MouseDown);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiButton1_MouseUp);
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(794, 189);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.OffColor = System.Drawing.Color.Red;
            this.uiLight1.Radius = 69;
            this.uiLight1.Size = new System.Drawing.Size(69, 78);
            this.uiLight1.TabIndex = 4;
            this.uiLight1.Text = "uiLight1";
            this.uiLight1.Click += new System.EventHandler(this.uiLight1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("黑体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1057, 59);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 93);
            this.button1.TabIndex = 25;
            this.button1.Text = "报警配置";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeviceControlPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1851, 1007);
            this.Controls.Add(this.uiPanel1);
            this.Name = "DeviceControlPage";
            this.Text = "贴签机控制";
            this.Load += new System.EventHandler(this.DeviceControlPage_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILight uiLight1;
        private Button btn1;
        private Sunny.UI.UITurnSwitch uiTurnSwitch2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIListBox uiListBox1;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIListBox uiListBox2;
        private Button button2;
        private Button button1;
    }
}