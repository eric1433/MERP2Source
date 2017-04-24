using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPPAYFM
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string YYYYMM { get; set; }
        public string EMP_NO { get; set; }
        public string CORP_NO { get; set; }
        public string ID_NO { get; set; }
        public string FA_NM { get; set; }
        public string RELA { get; set; }
        public DateTime? BRD_DT { get; set; }
        public DateTime? ISU_DT { get; set; }
        public DateTime? RIS_DT { get; set; }
        public string ADD_NO { get; set; }
        public decimal? ADD_RT { get; set; }
        public string C_ISU { get; set; }
        public string C_SOURCE { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual EMPPAYMT P { get; set; }
    }
}
