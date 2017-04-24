using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class FRLNO
    {
        public Guid ID { get; set; }
        public string FRL_NO { get; set; }
        public string FRL_NM { get; set; }
        public string C_DDT { get; set; }
        public decimal? DDT_RT { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
