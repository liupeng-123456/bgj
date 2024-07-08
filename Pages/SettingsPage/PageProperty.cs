using Sunny.UI;
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
using YWHSDK.CommonTool;

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
  
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            object oldVlaue = e.OldValue;
            string oldName = oldVlaue == null ? "" : oldVlaue.ToString();
            object newValue = e.ChangedItem.Value;
            string name = e.ChangedItem.PropertyDescriptor.Name;//变更的属性名
            if (oldName == newValue.ToString())
            {
                return;
            }
            //更换通信底层接口时,重新刷新ComboBoxItemTypeConvert里的下拉集合StandardValuesCollection
            //if (e.ChangedItem.PropertyDescriptor.PropertyType.ToString() == typeof(CommunicateTypeEnum).ToString())
            //{
            //    CommTool.AttributeEx.InitDict((CommunicateTypeEnum)e.ChangedItem.Value);
            //    return;
            //}
            var propertyGrid = s as PropertyGrid;

            var ps = propertyGrid.SelectedObject.GetType().GetProperty(name);//获得这个属性名对应的PropertyInfo
            if (ps == null || e.ChangedItem.PropertyDescriptor.ComponentType.ToString() != propertyGrid.SelectedObject.GetType().ToString())
            {
                //当要设置的是Struct类型时,暂时无法做判断
                //TODO:需要额外的代码来取得struct类型内部的属性并判断上下限,struct内部的属性只能共用同一个上下限
                return;
            }
            var attrr2 = ps.GetCustomAttribute(typeof(RangeAttribute), true) as RangeAttribute;//获得指定名称的自定义特性
            if (attrr2 == null)
            {
                return;
            }
            // PropertyDescriptorCollection props = TypeDescriptor.GetProperties(obj);

            if (typeof(Enum).IsInstanceOfType(newValue))
            {
                return;
            }
            if (!typeof(IConvertible).IsInstanceOfType(newValue))
            {
                return;
            }
            string range = attrr2.Range;
            //上下限必须在类似这样的格式内方可有效 (0,5] (0,5) [0,5) [0,5]
            if (!range.Contains("(") && !range.Contains("["))
            {
                return;
            }
            if (range.Contains("(") && range.Contains("["))
            {
                return;
            }
            if (!range.Contains(")") && !range.Contains("]"))
            {
                return;
            }
            if (range.Contains(")") && range.Contains("]"))
            {
                return;
            }
            if (!range.Contains(","))
            {
                return;
            }
            int index1, index2, index3 = 0;
            bool flag1 = range.Contains("(");//最小值是否是开区间
            bool flag2 = range.Contains(")");//最大值是否是开区间
            index1 = flag1 ? range.IndexOf("(") : range.IndexOf("[");
            index2 = range.IndexOf(",");
            index3 = flag2 ? range.IndexOf(")") : range.IndexOf("]");
            if (index2 > index3 || index2 < index1)
            {
                return;
            }
            decimal min = 0;
            decimal max = 0;
            string s1 = range.Substring(index1 + 1, index2 - index1 - 1);
            string s2 = range.Substring(index2 + 1, index3 - index2 - 1);
            if (!decimal.TryParse(s1, out min))
            {
                return;
            }
            if (!decimal.TryParse(s2, out max))
            {
                return;
            }
            if (min >= max)
            {
                return;
            }
            //TODO:如果当前属性类型不是double float decimal则把min max舍去小数点
            if (!typeof(double).IsInstanceOfType(newValue) && !typeof(float).IsInstanceOfType(newValue) && !typeof(decimal).IsInstanceOfType(newValue))
            {
                min = (int)min;
                max = (int)max;
            }
            bool result1 = true;
            bool result2 = true;

            //string类型单独处理
            if (typeof(string).IsInstanceOfType(newValue))
            {
                int length = newValue.ToString().Length;
                result1 &= flag1 ? length > min : length >= min;
                result2 &= flag2 ? length < max : length <= max;
                if (!result1)
                {
                    ps.SetValue(propertyGrid.SelectedObject, oldVlaue);
                    MessageBox.Show($@"输入字符串的长度不能小于下限!!!
实际长度:{length} 上下限: {range}");
                    return;
                }
                if (!result2)
                {
                    ps.SetValue(propertyGrid.SelectedObject, oldVlaue);
                    MessageBox.Show($@"输入字符串的长度不能大于上限!!!
实际长度:{length} 上下限: {range}");
                    return;
                }
            }
            else
            {
                var value = (newValue as IConvertible).ToDecimal(null);
                result1 &= flag1 ? value > min : value >= min;
                result2 &= flag2 ? value < max : value <= max;
                if (!result1)
                {
                    ps.SetValue(propertyGrid.SelectedObject, oldVlaue);
                    MessageBox.Show($@"输入值不能小于下限!!!
实际值:{newValue} 上下限: {range}");
                    return;
                }
                if (!result2)
                {
                    ps.SetValue(propertyGrid.SelectedObject, oldVlaue);
                    MessageBox.Show($@"输入值不能大于上限!!!
实际值:{newValue} 上下限: {range}");
                    return;
                }
            }
        }

        private void PageProperty_FormClosing(object sender, FormClosingEventArgs e)
        {

            SystemParams.Save();
            //SL.Save();
        }
    }
}
