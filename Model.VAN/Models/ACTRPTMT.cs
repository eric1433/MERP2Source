using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTRPTMT
    {
        public ACTRPTMT()
        {
            ACTRPTDL = new HashSet<ACTRPTDL>();
        }

        public Guid ID { get; set; }
        public string RPT_NO { get; set; }
        public string RPT_NM { get; set; }
        public string RPT_TY { get; set; }
        public string SIGN { get; set; }
        public string PRT_TY { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<ACTRPTDL> ACTRPTDL { get; set; }
    }
}
