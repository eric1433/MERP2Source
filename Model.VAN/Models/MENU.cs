using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class MENU
    {
        public Guid ID { get; set; }
        public string SYS_NO { get; set; }
        public int PRG_SR { get; set; }
        public string PRG_NO { get; set; }
        public string PRG_TY { get; set; }
        public string USE_TO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
