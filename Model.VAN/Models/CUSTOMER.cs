using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CUSTOMER
    {
        public Guid ID { get; set; }
        public string CS_NO { get; set; }
        public string SHORT_NM { get; set; }
        public string FULL_NM { get; set; }
        public string ADDR { get; set; }
        public string UNIQUE_NO { get; set; }
        public string PROPRIETOR { get; set; }
        public string CONTACTER { get; set; }
        public string CONTACTER2 { get; set; }
        public string CONTACTER3 { get; set; }
        public string TEL_NO { get; set; }
        public string TEL_NO2 { get; set; }
        public string TEL_NO3 { get; set; }
        public string FAX_NO { get; set; }
        public string CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string IVC_MODE { get; set; }
        public int? IVC_MM { get; set; }
        public int? IVC_DAY { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public string AR_ACT_NO { get; set; }
        public string AR_BCH_NO { get; set; }
        public string NR_ACT_NO { get; set; }
        public string NR_BCH_NO { get; set; }
        public string PR_ACT_NO { get; set; }
        public string PR_BCH_NO { get; set; }
        public string EAR_ACT_NO { get; set; }
        public string EAR_BCH_NO { get; set; }
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
