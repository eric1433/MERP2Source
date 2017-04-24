using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class PNLCFG
    {
        public Guid ID { get; set; }
        public string ROW_NO { get; set; }
        public decimal? HR_SLY_28 { get; set; }
        public decimal? HR_SLY_29 { get; set; }
        public decimal? HR_SLY_30 { get; set; }
        public decimal? HR_SLY_31 { get; set; }
        public string SPP_PMS_NO { get; set; }
        public string FRL_PMS_NO { get; set; }
        public string LIS_ISU_NO { get; set; }
        public string LIS_PMS_NO { get; set; }
        public string HIS_ISU_NO { get; set; }
        public string HIS_PMS_NO { get; set; }
        public string WF_PMS_NO { get; set; }
        public string IJT_PMS_NO { get; set; }
        public string IJT_FEE_PMS_NO { get; set; }
        public string EQUIP_PMS_NO { get; set; }
        public string DRAW_PMS_NO { get; set; }
        public decimal? HTH_AVG_PR { get; set; }
        public int? HTH_MAX_PR { get; set; }
        public decimal? RET_YEE_RT { get; set; }
        public decimal? RET_YER_RT { get; set; }
        public decimal? ADD_EXP_RT { get; set; }
        public string ADD_EXP_PMS_NO { get; set; }
        public decimal? ADD_EXP_DDT { get; set; }
        public string RET_PMS_NO { get; set; }
        public string TAX_PMS_NO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
