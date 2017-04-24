using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class VENDOR
    {
        public Guid ID { get; set; }
        public string VD_NO { get; set; }
        public string SHORT_NM { get; set; }
        public string UNIQUE_NO { get; set; }
        public string FULL_NM { get; set; }
        public string ADDR_OFC { get; set; }
        public string ZNO_OFC { get; set; }
        public string PROPRIETOR { get; set; }
        public string CONTACTER { get; set; }
        public string CONTACTER2 { get; set; }
        public string CONTACTER3 { get; set; }
        public string TEL_NO { get; set; }
        public string TEL_NO2 { get; set; }
        public string TEL_NO3 { get; set; }
        public string FAX_NO { get; set; }
        public string E_MAIL { get; set; }
        public string WWW { get; set; }
        public string AP_ACT_NO { get; set; }
        public string AP_BCH_NO { get; set; }
        public string NP_ACT_NO { get; set; }
        public string NP_BCH_NO { get; set; }
        public string PP_ACT_NO { get; set; }
        public string PP_BCH_NO { get; set; }
        public string EAP_ACT_NO { get; set; }
        public string EAP_BCH_NO { get; set; }
        public int? AP_MM { get; set; }
        public int? AP_DD { get; set; }
        public int? NP_MM { get; set; }
        public int? NP_DD { get; set; }
        public int? CASH_MM { get; set; }
        public int? CASH_DD { get; set; }
        public string ACC_TY { get; set; }
        public string PAY_TY { get; set; }
        public string IVC_PAGE { get; set; }
        public string TAX_TY { get; set; }
        public decimal? TAX_RT { get; set; }
        public string BANK_ID { get; set; }
        public string ACC_NO { get; set; }
        public string ACC_NM { get; set; }
        public string BANK_NO { get; set; }
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
