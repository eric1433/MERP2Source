using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EIPWRK
    {
        public Guid ID { get; set; }
        public DateTime WRK_DT { get; set; }
        public string EMP_NO { get; set; }
        public string SER_NO { get; set; }
        public string JOB_NO { get; set; }
        public decimal? WRK_HR { get; set; }
        public Guid? SID { get; set; }
        public string REMK { get; set; }
        public string C_CFM { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
