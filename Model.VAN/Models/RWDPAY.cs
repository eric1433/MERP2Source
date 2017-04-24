using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class RWDPAY
    {
        public Guid ID { get; set; }
        public DateTime PAY_DT { get; set; }
        public string RWD_NO { get; set; }
        public string CORP_NO { get; set; }
        public string C_PRD { get; set; }
        public string EMP_NO { get; set; }
        public decimal? TAX_RT { get; set; }
        public decimal? PAY_AMT { get; set; }
        public decimal? TAX { get; set; }
        public decimal? ADD_EXP { get; set; }
        public string C_SOURCE { get; set; }
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
