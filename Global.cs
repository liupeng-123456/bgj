using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap.Page.PLCControl;

namespace Cap
{
    public class Global
    {
        public static bool IsPlc_Connected { get; set; }

        public static bool IsCurrentFinish { get; set; }
        public static bool IsDBConnected { get; set; }
        public static bool IsLogin { get; set; }
        public static string LoginUser { get; set; }
        public static string CurrentUserCode { get; set; }

        /// <summary>
        /// 当前拨盖数量
        /// </summary>
        public static int CurrentFinishCount = 0;

        /// <summary>
        /// 拨盖计划总数
        /// </summary>
        public static int TotalCount = 0;

        public static SiemensPLC SiemensPLC = new SiemensPLC();

        /// <summary>
        /// 设备是否在报警
        /// </summary>
        public static bool IsDeviceAlarm;

        public static Dictionary<string, string> AlarmMap = new Dictionary<string, string>()
        {

        };

        public static List<PLCAlarmData> PlcAlarmList = new List<PLCAlarmData>();
    }

    public class PLCAlarmData
    {
        public string ID;
        public string Address;
        public string Name;

        public PLCAlarmData(string ID)
        {
            this.ID = ID;
        }
        public PLCAlarmData( )
        {

        }
    }

}
