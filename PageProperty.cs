﻿using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoTF
{
    public partial class PageProperty : UIForm
    {
        public SystemParams Instance;
        public PageProperty(object instance)
        {
            InitializeComponent();
            this.Instance = instance as SystemParams;
        }
        private void PageProperty_Load(object sender, EventArgs e)
        {
         
            propertyGrid1.SelectedObject = Instance;
            //todo: propertyGrid1的行高修改
            //todo: propertyGrid1的描述修改
            //todo: List改下拉
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            propertyGrid1.Controls[1].Height -= 100;
            propertyGrid1.Controls[3].Top -= 100;
            propertyGrid1.Controls[3].Height += 100;
            base.OnPaint(e);
        }
       
        public void InitPage()
        {

        }

        private void PageProperty_FormClosing(object sender, FormClosingEventArgs e)
        {

            SystemParams.Save();
            //SL.Save();
        }
    }
}
