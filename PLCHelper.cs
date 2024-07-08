using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogTool;

namespace Cap
{
    public static class PLCHelper
    {
       public static string alarmAddressPre = "DB533.";
        public static bool CheckPlcIsAlarm()
        {
            bool IsAlarm = false;
            if (Global.IsPlc_Connected)
            {
                foreach (PLCAlarmData data in Global.PlcAlarmList)
                {
                    string address = alarmAddressPre + data.Address;
                    Global.SiemensPLC.ReadBool(address, out bool res);
                    if (res)
                    {
                        IsAlarm = true;
                    }
                }
            }
            else
            {
                LogMgr.Instance.Error("PLC未连接...");
                IsAlarm = true;
            }
            return IsAlarm;
        }
    }
}
