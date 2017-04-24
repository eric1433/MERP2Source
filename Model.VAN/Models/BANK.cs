using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class BANK
    {
        public Guid ID { get; set; }
        public string BANK_NO { get; set; }
        public string BANK_NM { get; set; }
        public string BANK_NM_E { get; set; }
        public string FULL_NM { get; set; }
        public string FULL_NM_E { get; set; }
        public string BANK_ID { get; set; }
        public string ACC_NO { get; set; }
        public string ACT_NO { get; set; }
        public string BCH_NO { get; set; }
        public string NR_ACT_NO { get; set; }
        public string NR_BCH_NO { get; set; }
        public string NP_ACT_NO { get; set; }
        public string NP_BCH_NO { get; set; }
        public string DPS_KD { get; set; }
        public string CONTACTER { get; set; }
        public string CONTACTER2 { get; set; }
        public string CONTACTER3 { get; set; }
        public string TEL_NO { get; set; }
        public string TEL_NO2 { get; set; }
        public string TEL_NO3 { get; set; }
        public string FAX_NO { get; set; }
        public string E_MAIL { get; set; }
        public string WWW { get; set; }
        public string ADDR { get; set; }
        public string ADDR2 { get; set; }
        public string ADDR_E { get; set; }
        public string ADDR2_E { get; set; }
        public string CURRENCY { get; set; }
        public decimal? AMT { get; set; }
        public decimal? NT_AMT { get; set; }
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
