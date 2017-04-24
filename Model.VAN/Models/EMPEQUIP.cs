using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPEQUIP
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string EMP_NO { get; set; }
        public string EQUIP_NO { get; set; }
        public DateTime ISS_DT { get; set; }
        public DateTime? DDT_DT { get; set; }
        public decimal? QTY { get; set; }
        public decimal? PRC { get; set; }
        public decimal? ISS_AMT { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AMTED { get; set; }
        public decimal? MM_AMT { get; set; }
        public string C_SOURCE { get; set; }
        public string C_CLS { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual EMPLOYEE P { get; set; }
    }
}
