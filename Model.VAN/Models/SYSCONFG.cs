using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class SYSCONFG
    {
        public Guid ID { get; set; }
        public string ROW_NO { get; set; }
        public string CURR_YM { get; set; }
        public DateTime? CLS_DT { get; set; }
        public string CURRENCY { get; set; }
        public string IVC_PAGE { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public int? ACT_CURR_YY { get; set; }
        public DateTime? ACT_CLS_DT { get; set; }
        public string PR_ACT_NO { get; set; }
        public string IN_ACT_NO { get; set; }
        public string OT_ACT_NO { get; set; }
        public string AP_ACT_NO { get; set; }
        public string NP_ACT_NO { get; set; }
        public string AR_ACT_NO { get; set; }
        public string NR_ACT_NO { get; set; }
        public string DS_ACT_NO { get; set; }
        public string DR_ACT_NO { get; set; }
        public string EAR_DIFF_ACT_NO { get; set; }
        public string SLY_NP_ACT_NO { get; set; }
        public string SLY_CASH_ACT_NO { get; set; }
        public string RAR_TY { get; set; }
        public string R_ACT_NO { get; set; }
        public string R_BCH_NO { get; set; }
        public string R_BANK_NO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
