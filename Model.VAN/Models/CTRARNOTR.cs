using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTRARNOTR
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string NOT_NO { get; set; }
        public decimal? AMT { get; set; }
        public DateTime? RCV_DT { get; set; }
        public DateTime? DUE_DT { get; set; }
        public DateTime? PCASH_DT { get; set; }
        public string P_BANK_NM { get; set; }
        public string P_ACC_NO { get; set; }
        public string C_CS { get; set; }
        public string C_BANK_NO { get; set; }
        public string ACT_NO { get; set; }
        public string BCH_NO { get; set; }
        public string ACT_REMK { get; set; }
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
