using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EIPFRL
    {
        public Guid ID { get; set; }
        public DateTime FRL_DT { get; set; }
        public string EMP_NO { get; set; }
        public string FRL_NO { get; set; }
        public decimal? FRL_HR { get; set; }
        public Guid? SID { get; set; }
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
