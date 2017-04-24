using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class PMSNO
    {
        public Guid ID { get; set; }
        public string PMS_NO { get; set; }
        public string PMS_NM { get; set; }
        public string NAME_NO_1 { get; set; }
        public string NAME_NO_2 { get; set; }
        public string DR_ACT_NO { get; set; }
        public string C_DEPM_DR { get; set; }
        public string C_EMP_DR { get; set; }
        public string CR_ACT_NO { get; set; }
        public string C_DEPM_CR { get; set; }
        public string C_EMP_CR { get; set; }
        public int? IO { get; set; }
        public string C_SLY { get; set; }
        public string C_WF { get; set; }
        public string C_ADD { get; set; }
        public string C_IJT { get; set; }
        public string C_FRL { get; set; }
        public string C_TAX { get; set; }
        public string C_CST { get; set; }
        public string C_CAL_TY { get; set; }
        public decimal? AMT { get; set; }
        public string CAL_SR { get; set; }
        public string ALT_SR { get; set; }
        public string DISP_SR { get; set; }
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
