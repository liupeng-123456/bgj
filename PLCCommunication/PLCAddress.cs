using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTF.PLC
{
    internal class PLCAddress
    {
       

        /// <summary>
        /// 框位层数 上下层信息 上层写0 下层写1
        /// </summary>
        public static readonly string FrameLayer = "D5004";


        /// <summary>
        /// 放入哪个框位 1-18
        /// </summary>
        public static readonly string FramePos = "D5003";

        /// <summary>
        /// 哪个框位已经满了
        /// </summary>
        public static readonly string SendFrameFull = "D5002";

        //设定容量 D5005 - D5040
        //当前容量 D5041 - D5076

        /// <summary>
        /// 框位设定容量起始地址 长度36
        /// </summary>
        public static readonly string SetCapacityStart = "D5005";

        /// <summary>
        /// 框位当前容量起始地址 长度36
        /// </summary>
        public static readonly string CurrentCapacityStart = "D5041";

        #region 贴签机地址

        /// <summary>
        /// PLC触发拍照
        /// </summary>
        public static readonly string TriggerPhoto = "DB12.2";

        /// <summary>
        /// 拍照结果
        /// </summary>
        public static readonly string PhotoResult = "DB12.4";

        /// <summary>
        /// PLC触发打印
        /// </summary>
        public static readonly string TriggerPrint = "DB12.6";

        /// <summary>
        /// 打印完成
        /// </summary>
        public static readonly string PrintFinish = "DB12.14";

        /// <summary>
        /// 输液袋料号信息
        /// </summary>
        public static readonly string ProdType = "DB12.8";

        /// <summary>
        /// 贴签结果
        /// </summary>
        public static readonly string PrintResult = "DB12.14";

        /// <summary>
        /// PLC触发去扫码
        /// </summary>
        public static readonly string TriggerScan = "DB12.10";

        /// <summary>
        /// 通知PLC扫码结果
        /// 扫码OK 1  扫码NG 2
        /// </summary>
        public static readonly string ScanResult = "DB12.12";

        /// <summary>
        /// 读取报警信息 Bool 类型 从DB12.30.0 开始  32个
        /// </summary>
        public static readonly string AlarmStart = "DB12.30";


        #region HMI人机操作部分
        /// <summary>
        /// 停止按钮 Bool 类型
        /// </summary>
        public static readonly string StopSignal = "DB12.0.0";

        /// <summary>
        /// 手自动切换
        /// </summary>
        public static readonly string ManualSwitch = "DB12.0.1";

        /// <summary>
        /// 测试打印
        /// </summary>
        public static readonly string PrintControl = "DB12.1.1";

        /// <summary>
        /// 上位机复位
        /// </summary>
        public static readonly string PCReset = "DB12.0.2";

        /// <summary>
        /// 初始化
        /// </summary>
        public static readonly string InitSingal = "DB12.0.3";

        /// <summary>
        /// 初始化完成
        /// </summary>
        public static readonly string InitFinish = "DB12.0.4";

        /// <summary>
        /// 输送带1屏蔽
        /// </summary>
        public static readonly string Belt1Shield = "DB12.0.5";

        /// <summary>
        /// 输送带2屏蔽
        /// </summary>
        public static readonly string Belt2Shield = "DB12.0.6";

        /// <summary>
        /// 视觉屏蔽
        /// </summary>
        public static readonly string VisionShield = "DB12.0.7";

        /// <summary>
        /// 扫码枪屏蔽
        /// </summary>
        public static readonly string ScannerShield = "DB12.1.0";


        #endregion

        #endregion
    }
}
