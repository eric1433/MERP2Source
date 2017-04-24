using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CITEM
    {
        public Guid ID { get; set; }
        public string CITEM_NO { get; set; }
        public string CITEM_NM { get; set; }
        public string CITEM_TY { get; set; }
        public string VITEM_NO { get; set; }
        public string DR_ACT_NO { get; set; }
        public string DR_BCH_NO { get; set; }
        public string CR_ACT_NO { get; set; }
        public string CR_BCH_NO { get; set; }
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
