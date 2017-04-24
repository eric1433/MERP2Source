using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTDRDL
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string IVC_NO { get; set; }
        public string IVC_PAGE { get; set; }
        public DateTime? IVC_DT { get; set; }
        public string VITEM_NO { get; set; }
        public string VITEM_NM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? PRC { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? IVC_TAX { get; set; }
        public string UNIT { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual CTDRMT P { get; set; }
    }
}
