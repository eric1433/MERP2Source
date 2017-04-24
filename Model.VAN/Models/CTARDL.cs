using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CTARDL
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string CONTR_TY { get; set; }
        public string CONTR_NO { get; set; }
        public int? CONTR_SR { get; set; }
        public int? CITEM_SR { get; set; }
        public decimal? AR_AMT { get; set; }
        public decimal? TAX_AMT { get; set; }
        public decimal? RCD_AMT { get; set; }
        public decimal? DS_AMT { get; set; }
        public decimal? IVC_AMT { get; set; }
        public decimal? IVC_TAX { get; set; }
        public decimal? DR_AMT { get; set; }
        public DateTime? B_DT { get; set; }
        public DateTime? E_DT { get; set; }
        public string ACT_NO { get; set; }
        public string BCH_NO { get; set; }
        public string ACT_REMK { get; set; }
        public string C_PR { get; set; }
        public string PR_TY { get; set; }
        public string PR_NO { get; set; }
        public int? PR_SR { get; set; }
        public decimal? CPS_AMT { get; set; }
        public decimal? CPS_TAX { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
        public string C_SOURCE { get; set; }

        public virtual CTARMT P { get; set; }
    }
}
