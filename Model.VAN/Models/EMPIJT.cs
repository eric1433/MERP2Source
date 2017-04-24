using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPIJT
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string EMP_NO { get; set; }
        public string IJT_NO { get; set; }
        public DateTime? IJT_DT { get; set; }
        public DateTime? DDT_DT { get; set; }
        public string DOC_NO { get; set; }
        public string C_PRO { get; set; }
        public string DED_SR { get; set; }
        public string BANK_NO { get; set; }
        public decimal? AMT { get; set; }
        public decimal? INT { get; set; }
        public decimal? MM_DED_AMT { get; set; }
        public decimal? AMTED { get; set; }
        public decimal? FEE { get; set; }
        public string FEE_NO { get; set; }
        public decimal? DED_WT { get; set; }
        public string C_DED_TY { get; set; }
        public string ACC_NO { get; set; }
        public string ACC_NM { get; set; }
        public string C_SOURCE { get; set; }
        public string C_CLS { get; set; }
        public string CONTACTER { get; set; }
        public string TEL_NO { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual EMPLOYEE P { get; set; }
    }
}
