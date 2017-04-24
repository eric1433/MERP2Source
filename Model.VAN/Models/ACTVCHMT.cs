using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTVCHMT
    {
        public ACTVCHMT()
        {
            ACTVCHDL = new HashSet<ACTVCHDL>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public string CORP_NO { get; set; }
        public string EMP_NO { get; set; }
        public string C_SOURCE { get; set; }
        public string SVCH_TY { get; set; }
        public string SVCH_NO { get; set; }
        public string OVCH_TY { get; set; }
        public string OVCH_NO { get; set; }
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

        public virtual ICollection<ACTVCHDL> ACTVCHDL { get; set; }
    }
}
