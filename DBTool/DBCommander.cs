
using LogTool;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Cap;
using System.Windows.Forms;

namespace AutoTF.DBTool
{

    public class DBCommander
    {

        public static List<tbDrugConfig> GetAllDrugConfig()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                List<tbDrugConfig> list = db.tbDrugConfig.ToList();
                return list;
            }
        }

        public static tbDrugConfig GetDrugConfig(string DrugCode)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext(1))
                {
                    tbDrugConfig drugConfig = db.tbDrugConfig.FirstOrDefault(r => r.DrugCode == DrugCode);
                    return drugConfig;
                }
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"获取药品配方失败 药品编号[{DrugCode}]");
            }

            return null;
        }

        public static List<tbTestDrug> GetAllDrugName()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                List<tbTestDrug> list = db.tbTestDrug.ToList();
                return list;
            }
        }

        public static List<tbDrugConfig> GetAllDrugConfigByName( string name)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext(1))
            {
                List<tbDrugConfig> list = db.tbDrugConfig.Where(r=>r.DrugName.Contains(name)).ToList();
                return list;
            }
        }
    }
}
