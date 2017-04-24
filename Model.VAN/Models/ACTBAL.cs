using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTBAL
    {
        public Guid ID { get; set; }
        public string CORP_NO { get; set; }
        public int YYYY { get; set; }
        public string ACT_NO { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? CR_AMT { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
