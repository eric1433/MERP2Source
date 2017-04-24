using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CONTRCITEM
    {
        public CONTRCITEM()
        {
            CONTRCITEMAR = new HashSet<CONTRCITEMAR>();
        }

        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string CITEM_NO { get; set; }
        public string ACT_NO { get; set; }
        public string BCH_NO { get; set; }
        public DateTime? B_DT { get; set; }
        public DateTime? E_DT { get; set; }
        public int? IVC_TY { get; set; }
        public string IVC_MODE { get; set; }
        public int? IVC_MM { get; set; }
        public int? IVC_DAY { get; set; }
        public decimal? AMT_MM { get; set; }
        public int? SRV_MM { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AR_PRD { get; set; }
        public int? PRD { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public string C_STA { get; set; }
        public string C_EXP { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<CONTRCITEMAR> CONTRCITEMAR { get; set; }
        public virtual CONTRMT P { get; set; }
    }
}
