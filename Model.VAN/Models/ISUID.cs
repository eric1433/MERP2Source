using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ISUID
    {
        public Guid ID { get; set; }
        public string ISU_NO { get; set; }
        public string ISU_NM { get; set; }
        public string ISU_TY { get; set; }
        public string GRD_NO { get; set; }
        public string C_PRD { get; set; }
        public string PMS_NO { get; set; }
        public decimal? EXP_RT { get; set; }
        public decimal? YEE_RT { get; set; }
        public decimal? YER_RT { get; set; }
        public int MAX_GRD { get; set; }
        public string DR_ACT_NO { get; set; }
        public string C_DEPM_DR { get; set; }
        public string C_EMP_DR { get; set; }
        public string CR_ACT_NO { get; set; }
        public string C_DEPM_CR { get; set; }
        public string C_EMP_CR { get; set; }
        public string C_PT_TY { get; set; }
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
