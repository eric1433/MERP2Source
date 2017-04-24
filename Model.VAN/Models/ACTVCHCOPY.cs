using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTVCHCOPY
    {
        public Guid ID { get; set; }
        public string COPY_NO { get; set; }
        public int VCH_SR { get; set; }
        public string ACT_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string CN_NO { get; set; }
        public string SER_NO { get; set; }
        public string CS_NO { get; set; }
        public string VD_NO { get; set; }
        public string EMP_NO { get; set; }
        public string BCH_NO { get; set; }
        public int? C_DCR { get; set; }
        public decimal? AMT { get; set; }
        public string SVCH_TY { get; set; }
        public string SVCH_NO { get; set; }
        public int? SVCH_SR { get; set; }
        public string PRJ_NO { get; set; }
        public string CFW_NO { get; set; }
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
