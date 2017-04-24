using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CPADDMT
    {
        public CPADDMT()
        {
            CPADDDL = new HashSet<CPADDDL>();
        }

        public Guid ID { get; set; }
        public string YYYYMM { get; set; }
        public string CORP_NO { get; set; }
        public decimal? SLY_AMT { get; set; }
        public decimal? OTH_AMT { get; set; }
        public decimal? HIS_AMT { get; set; }
        public decimal? ADD_EXP { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<CPADDDL> CPADDDL { get; set; }
    }
}
