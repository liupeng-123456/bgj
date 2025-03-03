﻿using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap;

namespace AutoTF.Pages.User
{
    public partial class FormUserEditor : UIForm
    {
        private tbOpUser OpUser;

        private int ID;

        private bool isInsert =false;
        public FormUserEditor(tbOpUser opUser)
        {
            InitializeComponent();
            this.OpUser = opUser;
        }
        public FormUserEditor()
        {
            InitializeComponent();
            this.OpUser = new tbOpUser(); 
            isInsert = true;
        }

        public FormUserEditor(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private Dictionary<int,string> opMap = new Dictionary<int, string>()
        {
            {1,"剥盖操作员" },
            {10,"系统管理员"},
        };
        private void FormUserEditor_Load(object sender, EventArgs e)
        {
            uiComboBox1.DataSource = new BindingSource(opMap,null);
            //实际显示的信息
            uiComboBox1.DisplayMember = "Value";
            uiComboBox1.ValueMember = "Key";
            List<string> names = new List<string>();


            if(isInsert)
            {
                InsertUser();
            }
            else
            {
                LoadUser();
            }
           
        }

        /// <summary>
        /// 加载原来的用户信息
        /// </summary>
        private void LoadUser()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                try
                {
                    tbOpUser user = db.tbOpUser
                        .Where(r => r.ID == ID)
                        .FirstOrDefault();
                    if(user != null)
                    {
                        LoadUI(user);
                    }
                    else
                    {
                        UIMessageBox.Show("查询不到当前用户信息");
                    }
                }
                catch(Exception ex)
                {
                    UIMessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadUI(tbOpUser user)
        {
            OpUser = user;
            tbxPassword.Text = user.Password;
            tbxUserCode.Text = user.UserCode;
            tbxUserName.Text = user.UserName;
            int opType = user.OpType;
            uiComboBox1.Text = opMap[opType];
        }

        /// <summary>
        /// 插入新用户
        /// </summary>
        private void InsertUser()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                try
                {
                    tbOpUser user = new tbOpUser();
                    //默认插入普通操作员
                    user.OpType = 1;
                 /*   db.tbOpUser.InsertOnSubmit(user);
                    db.SubmitChanges();*/
                    LoadUI(user);
                }
                catch(Exception ex)
                {
                    UIMessageBox.Show("插入用户失败"+ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
            {
                return;
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                try
                {
                    OpUser = db.tbOpUser.SingleOrDefault(u=>u.ID==ID);
                    if(OpUser == null && !isInsert)
                    {
                        UIMessageBox.Show("查选不到当前修改用户信息");
                        return;
                    }
                    if(isInsert)
                    {
                        OpUser = new tbOpUser();
                    }
                
                    OpUser.UserName = tbxUserName.Text;
                    OpUser.Password = tbxPassword.Text;
                    OpUser.UserCode = tbxUserCode.Text;
                    object selectedValue = uiComboBox1.SelectedValue;
                    OpUser.OpType = (int)selectedValue;
                    if(isInsert)
                    {
                        db.tbOpUser.InsertOnSubmit(OpUser);
                    }
                    db.SubmitChanges();
                    UIMessageBox.Show("修改成功");
                    this.Close();
                }
                catch(Exception ex)
                {
                    if (ex.Message.StartsWith("违反了 UNIQUE KEY 约束“工号"))
                    {
                        UIMessageBox.ShowError("工号已经存在，请重新输入");
                    }
                    else
                    {
                        UIMessageBox.ShowError(ex.Message);
                    }
                
                }
            }
   
        }

        private bool CheckInput()
        {
            bool isCheck =false;
            if(tbxUserName.Text == "")
            {
                UIMessageBox.Show("请输入名称");
                return isCheck;
            }
            if(tbxUserCode.Text == "")
            {
                UIMessageBox.Show("请输入工号");
                return isCheck;
            }
            if(uiComboBox1.SelectedValue == null)
            {
                UIMessageBox.Show("请选择权限类型");
                return isCheck;
            }

            isCheck = true;
            return isCheck;
        }
    }
}
