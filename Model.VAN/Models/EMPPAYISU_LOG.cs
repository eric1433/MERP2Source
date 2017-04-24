using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPPAYISU_LOG
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
        public string ISU_CORP_NO { get; set; }
        public string ISU_NO { get; set; }
        public decimal ISU_SLY { get; set; }
        public DateTime? ISU_DT { get; set; }
        public DateTime? RIS_DT { get; set; }
        public string ADD_NO { get; set; }
        public decimal? ADD_RT { get; set; }
        public decimal? CORP_EXP { get; set; }
        public decimal? EMP_EXP { get; set; }
        public decimal? FM_EXP { get; set; }
        public decimal? ADD_EXP { get; set; }
        public decimal? CORP_PNS { get; set; }
        public decimal? EMP_PNS { get; set; }
        public int FM_MS { get; set; }
        public decimal? FM_ADD_RT { get; set; }
        public int PT_DAY { get; set; }
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
