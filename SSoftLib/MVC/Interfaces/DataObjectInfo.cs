using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSoft.MVC.Interfaces
{
    public class DataObjectInfo
    {
       
        public System.Type InputModelObjectType { get; set; }
        public System.Type QueryOutputModelObjectType { get; set; }

        public System.Type ConditionModelObjectType { get; set; }
        public List<SSoft.MVC.Interfaces.DataObjectInfo> DataObjectInfoes { get; set; }

        public List<string> VisualKeys { get; set; }
        public List<string> IncludeTables { get; set; }

        public List<string> DeliveryColumns { get; set; }
        public DataObjectInfo()
        {
            DataObjectInfoes = new List<DataObjectInfo>();
            IncludeTables = new List<string>();
        }
        public DataObjectInfo(System.Type inputModelObjectType, System.Type conditionModelObjectType)
            : this()
        {
            this.InputModelObjectType = inputModelObjectType;
            this.ConditionModelObjectType = conditionModelObjectType;
        }

        public DataObjectInfo(System.Type dataObjectSystemType, System.Type conditionModelObjectType, List<string> includeTables)
            : this()
        {
            this.InputModelObjectType = dataObjectSystemType;
            this.ConditionModelObjectType = conditionModelObjectType;
            this.IncludeTables = includeTables;
        }
    }
}
