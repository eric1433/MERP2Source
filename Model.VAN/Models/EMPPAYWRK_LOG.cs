using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPPAYWRK_LOG
    {
        public long LogId { get; set; }
        public string CHG_TYPE { get; set; }
        public DateTime? CHG_DATE { get; set; }
        public string CHG_USER { get; set; }
        public string CHG_COMPUTER_NAME { get; set; }
        public string CHG_DB_USER { get; set; }
        public string CHG_DB_ROLE { get; set; }
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string YYYYMM { get; set; }
        public string EMP_NO { get; set; }
        public string CORP_NO { get; set; }
        public string CN_NO { get; set; }
        public string SER_NO { get; set; }
        public string JOB_NO { get; set; }
        public string C_TY { get; set; }
        public string SER_CORP_NO { get; set; }
        public decimal? WRK_HR { get; set; }
        public decimal? HR_SLY { get; set; }
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
