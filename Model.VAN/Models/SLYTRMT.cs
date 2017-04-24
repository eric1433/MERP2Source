using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class SLYTRMT
    {
        public SLYTRMT()
        {
            SLYTRACT = new HashSet<SLYTRACT>();
            SLYTRDL = new HashSet<SLYTRDL>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime VCH_DT { get; set; }
        public string CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string YYYYMM { get; set; }
        public string C_PRD { get; set; }
        public string C_PAY_TY { get; set; }
        public string BANK_NO { get; set; }
        public string ACT_NO { get; set; }
        public DateTime? TR_DT { get; set; }
        public DateTime? DUE_DT { get; set; }
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

        public virtual ICollection<SLYTRACT> SLYTRACT { get; set; }
        public virtual ICollection<SLYTRDL> SLYTRDL { get; set; }
    }
}
