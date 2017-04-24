using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class IVCCNMT
    {
        public IVCCNMT()
        {
            IVCCNAR = new HashSet<IVCCNAR>();
            IVCCNDL = new HashSet<IVCCNDL>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public DateTime? IVC_DT { get; set; }
        public string YYYYMM { get; set; }
        public string IVC_GRP { get; set; }
        public string IVC_NO { get; set; }
        public string IVC_PAGE { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public decimal? IVC_AMT { get; set; }
        public decimal? IVC_TAX { get; set; }
        public string CORP_NO { get; set; }
        public string S_UNIQUE_NO { get; set; }
        public string CS_NO { get; set; }
        public string B_UNIQUE_NO { get; set; }
        public string FULL_NM { get; set; }
        public string C_SOURCE { get; set; }
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

        public virtual ICollection<IVCCNAR> IVCCNAR { get; set; }
        public virtual ICollection<IVCCNDL> IVCCNDL { get; set; }
    }
}
