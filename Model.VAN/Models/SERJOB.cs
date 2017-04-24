using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class SERJOB
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string SER_NO { get; set; }
        public string JOB_NO { get; set; }
        public decimal? NM_HR_SLY_28 { get; set; }
        public decimal? NM_HR_SLY_29 { get; set; }
        public decimal? NM_HR_SLY_30 { get; set; }
        public decimal? NM_HR_SLY_31 { get; set; }
        public decimal? SP_HR_SLY_28 { get; set; }
        public decimal? SP_HR_SLY_29 { get; set; }
        public decimal? SP_HR_SLY_30 { get; set; }
        public decimal? SP_HR_SLY_31 { get; set; }
        public int BAS_HR_28 { get; set; }
        public int BAS_HR_29 { get; set; }
        public int BAS_HR_30 { get; set; }
        public int BAS_HR_31 { get; set; }
        public decimal? OVT_RT_28 { get; set; }
        public decimal? OVT_RT_29 { get; set; }
        public decimal? OVT_RT_30 { get; set; }
        public decimal? OVT_RT_31 { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual SERVE P { get; set; }
    }
}
