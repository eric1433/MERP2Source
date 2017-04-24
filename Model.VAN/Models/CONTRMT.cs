using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CONTRMT
    {
        public CONTRMT()
        {
            CONTRBUG = new HashSet<CONTRBUG>();
            CONTRCITEM = new HashSet<CONTRCITEM>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public string CN_NO { get; set; }
        public string SER_NO { get; set; }
        public string CS_NO { get; set; }
        public string CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public DateTime? B_DT { get; set; }
        public DateTime? E_DT { get; set; }
        public DateTime? T_DT { get; set; }
        public string C_STA { get; set; }
        public int? PRD { get; set; }
        public string IVC_MODE { get; set; }
        public int? IVC_TY { get; set; }
        public int? IVC_MM { get; set; }
        public int? IVC_DAY { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public string IVC_GRP { get; set; }
        public string AR_DEPM_NO { get; set; }
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

        public virtual ICollection<CONTRBUG> CONTRBUG { get; set; }
        public virtual ICollection<CONTRCITEM> CONTRCITEM { get; set; }
    }
}
