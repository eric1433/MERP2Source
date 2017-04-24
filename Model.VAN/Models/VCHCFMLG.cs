using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class VCHCFMLG
    {
        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public DateTime? CFM_DT { get; set; }
        public string C_CFM { get; set; }
        public string USR_NO { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
