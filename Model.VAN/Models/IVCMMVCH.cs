using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class IVCMMVCH
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string YYYYMM { get; set; }
        public string IVC_GRP { get; set; }
        public string VCH_TY { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual IVCMM P { get; set; }
    }
}
