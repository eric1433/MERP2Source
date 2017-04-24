using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTRARML
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string RAR_TY { get; set; }
        public decimal? AMT { get; set; }
        public string ACT_NO { get; set; }
        public string BCH_NO { get; set; }
        public string ACT_REMK { get; set; }
        public DateTime? DW_DT { get; set; }
        public string BANK_NO { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual CTRARMT P { get; set; }
    }
}
