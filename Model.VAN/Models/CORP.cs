using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class CORP
    {
        public Guid ID { get; set; }
        public string CORP_NO { get; set; }
        public string SHORT_NM { get; set; }
        public string CORP_NM { get; set; }
        public string ZNO_ADDR { get; set; }
        public string ADDR { get; set; }
        public string UNIQUE_NO { get; set; }
        public string TAXRGT_NO { get; set; }
        public string PROPRIETOR { get; set; }
        public string CONTACTER { get; set; }
        public string TEL_NO { get; set; }
        public string TEL_NO2 { get; set; }
        public string TEL_NO3 { get; set; }
        public string FAX_NO { get; set; }
        public string BANK_NO { get; set; }
        public string ACC_NM { get; set; }
        public string ACC_NO { get; set; }
        public string TAX_CITY { get; set; }
        public string TAX_DEPM { get; set; }
        public string GVM_NO { get; set; }
        public string DCL_NO { get; set; }
        public string DUTY_NM { get; set; }
        public string LIS_ID { get; set; }
        public string HIS_ID { get; set; }
        public string DR_ACT_NO { get; set; }
        public string CR_ACT_NO { get; set; }
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
