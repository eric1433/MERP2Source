using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CONTR
    {
        public Guid ID { get; set; }
        public string CN_NO { get; set; }
        public string DOC_NO { get; set; }
        public string FULL_NM { get; set; }
        public string SHORT_NM { get; set; }
        public string CN_TY { get; set; }
        public string CS_NO { get; set; }
        public string CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string ADDR { get; set; }
        public DateTime? B_DT { get; set; }
        public DateTime? E_DT { get; set; }
        public DateTime? T_DT { get; set; }
        public string C_STA { get; set; }
        public int? PRD { get; set; }
        public string IVC_MODE { get; set; }
        public int? IVC_TY { get; set; }
        public int? IVC_MM { get; set; }
        public int? IVC_DAY { get; set; }
        public decimal? DEPOSIT { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public string IVC_GRP { get; set; }
        public string IVC_DEPM_NO { get; set; }
        public string IVC_REMK { get; set; }
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
