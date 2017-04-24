using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSoft.MVC
{
    public class DisplayValue
    {
        public string Display { get; set; }
        public string Display1 { get; set; }
        public string Display2 { get; set; }
        public string Display3 { get; set; }
        public string Value { get; set; }
        public int intValue { get; set; }
        public decimal decimalValue { get; set; }
        public bool BooleanValue { get; set; }
        public List<DisplayValue> ChildDisplayValues { get; set; }

        public DisplayValue()
        {
            ChildDisplayValues = new List<DisplayValue>();
        }
       
    }
}
