using AutoTF;
using LogTool;
using System;
using System.Threading;

namespace Cap
{
    public class Mainfunc
    {
        private static Mainfunc _instance;

        // 3. 提供一个公共的静态方法，用于获取单例对象
        public static Mainfunc Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(Mainfunc))
                    {
                        if (_instance == null)
                        {
                            _instance = new Mainfunc();
                        }
                    }
                }
                return _instance;
            }
        }
        // 定义委托  
        public delegate void RecivePCLDataHandle( int productID,int finishCount);

        // 定义事件  
        public static event RecivePCLDataHandle RecivePCLDataEvent;


        public LogMgr Logger = LogMgr.Instance;

        public static void PLCMainWork()
        {
            while (true)
            {
                try
                {
                    //连上PLC的处理过程 一直循环读取数据
                    if (Global.IsPlc_Connected)
                    {
                        //读取PLC的触发指令
                        bool readResult = Global.SiemensPLC.ReadInt16(PLCAddress.ProdType, out var ProductNo);
                        //判断能不能成功读取数据 验证通讯没问题
                        if (readResult)
                        {
                            Global.SiemensPLC.ReadInt16(PLCAddress.FinishCount, out var finishCount);
                            Global.CurrentFinishCount =finishCount;
                            RecivePCLDataEvent?.Invoke(ProductNo,finishCount);
                        }
                        else
                        {
                            LogMgr.Instance.Error("读取PLC信号失败");
                        }
                    }
                    else
                    {
                       // LogMgr.Instance.Error("PLC连接失败");
                    }
                }
                catch (Exception e)
                {
                    LogMgr.Instance.Error("错误" + e.Message);
               
                }
                Thread.Sleep(100);

            }
        }

        public Mainfunc()
        {
        
        }

        public  void Start()
        {
            //启动PLC监控线程
            Thread t = new Thread(ConnStatusMonitor);
            t.Start();
            Thread.Sleep(300);
            Thread t2 = new Thread(PLCMainWork);
            t2.Start();
        }


        #region 后台监控线程

        /// <summary>
        /// 后台线程，监测连接状态
        /// </summary>
        private  void ConnStatusMonitor()
        {
            while (true)
            {
                if (!Global.IsPlc_Connected)
                {
                    Logger.Info("PLC连接中");
                    if (Global.SiemensPLC.Connect(SystemParams.Instance.PlcIP))
                    {
                        Logger.Debug("PLC连接成功");
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Logger.Debug("尝试重连PLC");
                    }
                }
                Thread.Sleep(1000);
            }
        }

        #endregion
    }
}
