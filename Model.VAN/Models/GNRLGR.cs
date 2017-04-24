using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class GNRLGR
    {
        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NO { get; set; }
        public int VCH_SR { get; set; }
        public string CORP_NO { get; set; }
        public string ACT_NO { get; set; }
        public DateTime? VCH_DT { get; set; }
        public string DEPM_NO { get; set; }
        public string CN_NO { get; set; }
        public string SER_NO { get; set; }
        public string CS_NO { get; set; }
        public string VD_NO { get; set; }
        public string EMP_NO { get; set; }
        public string BCH_NO { get; set; }
        public string C_CLS { get; set; }
        public DateTime? CLS_DT { get; set; }
        public string REMK { get; set; }
        public int? C_DCR { get; set; }
        public decimal? AMT { get; set; }
        public string ITEM_NM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? PRC { get; set; }
        public string SVCH_TY { get; set; }
        public string SVCH_NO { get; set; }
        public int? SVCH_SR { get; set; }
        public string PRJ_NO { get; set; }
        public string CFW_NO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
