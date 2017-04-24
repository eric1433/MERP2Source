using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTDRMT
    {
        public CTDRMT()
        {
            CTDRACT = new HashSet<CTDRACT>();
            CTDRAR = new HashSet<CTDRAR>();
            CTDRDL = new HashSet<CTDRDL>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? IVC_TAX { get; set; }
        public decimal? RCD_AMT { get; set; }
        public decimal? DS_AMT { get; set; }
        public string AR_ACT_NO { get; set; }
        public string AR_BCH_NO { get; set; }
        public string CORP_NO { get; set; }
        public string S_UNIQUE_NO { get; set; }
        public string CS_NO { get; set; }
        public string B_UNIQUE_NO { get; set; }
        public string FULL_NM { get; set; }
        public string CS_ADDR { get; set; }
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

        public virtual ICollection<CTDRACT> CTDRACT { get; set; }
        public virtual ICollection<CTDRAR> CTDRAR { get; set; }
        public virtual ICollection<CTDRDL> CTDRDL { get; set; }
    }
}
