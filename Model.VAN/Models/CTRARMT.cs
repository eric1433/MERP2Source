using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTRARMT
    {
        public CTRARMT()
        {
            CTRARACT = new HashSet<CTRARACT>();
            CTRARDL = new HashSet<CTRARDL>();
            CTRARML = new HashSet<CTRARML>();
            CTRARNOTR = new HashSet<CTRARNOTR>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public string CORP_NO { get; set; }
        public string CS_NO { get; set; }
        public decimal? CPS_AMT { get; set; }
        public string C_AJS { get; set; }
        public string AVCH_TY { get; set; }
        public string AVCH_NO { get; set; }
        public string REMK { get; set; }
        public int? N_PRT { get; set; }
        public string C_SIGN { get; set; }
        public string C_CFM { get; set; }
        public DateTime? CFM_DT { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string CFM_USR_NO { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<CTRARACT> CTRARACT { get; set; }
        public virtual ICollection<CTRARDL> CTRARDL { get; set; }
        public virtual ICollection<CTRARML> CTRARML { get; set; }
        public virtual ICollection<CTRARNOTR> CTRARNOTR { get; set; }
    }
}
