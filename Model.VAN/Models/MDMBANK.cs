using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class MDMBANK
    {
        public Guid ID { get; set; }
        public string BANK_NO { get; set; }
        public string C_TY { get; set; }
        public int SR_NO { get; set; }
        public int? LENGTH { get; set; }
        public string FLD_NM { get; set; }
        public string FIX_CHAR { get; set; }
        public string FLD_TITLE { get; set; }
        public string C_CTL { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
