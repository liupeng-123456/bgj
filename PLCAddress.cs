using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    internal class PLCAddress
    {
        /// <summary>
        /// 手自动切换
        /// </summary>
        public static readonly string ManualSwitch = "DB533.24";

        /// <summary>
        /// 初始化触发
        /// </summary>
        public static readonly string InitSingal = "DB533.2";

        /// <summary>
        /// 初始化完成
        /// </summary>
        public static readonly string InitFinish = "DB533.68.2";

        /// <summary>
        /// 上位机状态
        /// </summary>
        public static readonly string PCStatu = "DB533.4";

        /// <summary>
        /// 设备故障
        /// </summary>
        public static readonly string DeviceErr = "DB533.6";


        /// <summary>
        /// 拨盖任务数量 总数
        /// </summary>
        public static readonly string TaskTotalCount = "DB533.8";

        /// <summary>
        /// 当前拨盖数量 完成数
        /// </summary>
        public static readonly string FinishCount = "DB533.10";

        /// <summary>
        /// 西林瓶料号信息
        /// </summary>
        public static readonly string ProdType = "DB533.12";

        /// <summary>
        /// 上位机状态
        /// </summary>
        public static readonly string DeviceReset = "DB533.14";


        /// <summary>
        /// 定位轴位置
        /// </summary>
        public static readonly string Weight = "DB533.16";

        /// <summary>
        /// 理料轴位置
        /// </summary>
        public static readonly string Height = "DB533.20";


        /// <summary>
        /// 原点补偿时间
        /// </summary>
        public static readonly string DelayTime = "DB533.54";

        /// <summary>
        /// 当前任务完成提示
        /// </summary>
        public static readonly string TaskFinish = "DB533.58";

        /// <summary>
        /// 消毒时间
        /// </summary>
        public static readonly string DisinfectTime = "DB533.64";

        /// <summary>
        /// 消毒按钮  bool
        /// </summary>
        public static readonly string DisinfectStart = "DB533.68.0";

        /// <summary>
        /// 消毒完成
        /// </summary>
        public static readonly string DisinfectFinish = "DB533.68.1";

        #region 贴签机地址



        #region HMI人机操作部分

        #endregion

        #endregion

        public static string StopSignal { get; set; }
    }
}
