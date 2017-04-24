using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class IVCCNAR
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string C_SOURCE { get; set; }
        public string AR_TY { get; set; }
        public string AR_NO { get; set; }
        public int? AR_SR { get; set; }
        public decimal? IVC_AMT { get; set; }
        public decimal? IVC_TAX { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual IVCCNMT P { get; set; }
    }
}
