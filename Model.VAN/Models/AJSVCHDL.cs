using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class AJSVCHDL
    {
        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public string C_SOURCE { get; set; }
        public DateTime VCH_DT { get; set; }
        public string AVCH_TY { get; set; }
        public string AVCH_NO { get; set; }
        public DateTime? AVCH_DT { get; set; }
        public DateTime? AJS_DT { get; set; }
        public string AJS_USR_NO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
