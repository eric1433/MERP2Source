using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTNO
    {
        public Guid ID { get; set; }
        public string ACT_NO { get; set; }
        public string ACT_NM { get; set; }
        public string ENG_NM { get; set; }
        public string C_CTRL { get; set; }
        public string C_DEPM { get; set; }
        public string S_DEPM { get; set; }
        public string C_BCH { get; set; }
        public string C_BCH_SOURCE { get; set; }
        public string C_CLAS { get; set; }
        public string C_CURRENCY { get; set; }
        public int? C_DCR { get; set; }
        public int? C_LEV { get; set; }
        public string U_ACT_NO { get; set; }
        public string MGT_CODE { get; set; }
        public string CURRENCY { get; set; }
        public string EXCH_RT_TY { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    }
}
