using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPEXAM
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string EMP_NO { get; set; }
        public DateTime EXAM_DT { get; set; }
        public DateTime? NEXT_DT { get; set; }
        public decimal HEIGHT { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? BMI { get; set; }
        public decimal? SBP { get; set; }
        public decimal? DBP { get; set; }
        public decimal? AC { get; set; }
        public decimal? CHOL { get; set; }
        public decimal? TG { get; set; }
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
