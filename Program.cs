using LogTool;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoTF;

namespace Cap
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            try
            {
                bool canCreateNew;
                string mutexName = System.Reflection.Assembly.GetEntryAssembly().FullName;
                using (Mutex m = new Mutex(false, mutexName, out canCreateNew))
                {
                    if (!canCreateNew)
                    {
                        MessageBox.Show(null, "有一个和本程序相同的应用程序已经在运行，请不要同时运行多个本程序。\n\n这个程序即将退出。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Environment.Exit(1);
                    }
                    else
                    {
                       /*       Checker checkera = new Checker();
                        if (!checkera.CheckRegister())
                        {
                            MessageBox.Show("软件错误！请不要在其他机器运行!", "提示");
                            System.Environment.Exit(0);
                        }*/
                        PageLogin page = new PageLogin();
                        page.BringToFront();
                        page.ShowDialog();
                        if (!Global.IsLogin)
                        {
                            Environment.Exit(0);
                            return;
                        }

                        MainForm mainForm = MainForm.Instance;
                        mainForm.WindowState = FormWindowState.Maximized;
                        mainForm.FormClosing += MainForm_Closing;
                        Application.Run(mainForm);
                    }
                }
            }
            catch (Exception ex)
            {
                Application_ThreadException(null, new ThreadExceptionEventArgs(ex));
            }
            finally
            {
                LogMgr.Instance.Info("关闭应用程序！");
            }
        }

        private static void Application_ThreadException(object o, ThreadExceptionEventArgs ex)
        {
            LogMgr.Instance.Error("错误:" + ex?.Exception?.Message);
            MessageBox.Show(@"错误:" + ex?.Exception?.Message);
        }
 
        private static void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
