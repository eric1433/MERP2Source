using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPPAYMT
    {
        public EMPPAYMT()
        {
            EMPPAYACT = new HashSet<EMPPAYACT>();
            EMPPAYAJS = new HashSet<EMPPAYAJS>();
            EMPPAYDL = new HashSet<EMPPAYDL>();
            EMPPAYDPC = new HashSet<EMPPAYDPC>();
            EMPPAYDRAW = new HashSet<EMPPAYDRAW>();
            EMPPAYEQUIP = new HashSet<EMPPAYEQUIP>();
            EMPPAYFM = new HashSet<EMPPAYFM>();
            EMPPAYFRL = new HashSet<EMPPAYFRL>();
            EMPPAYIJT = new HashSet<EMPPAYIJT>();
            EMPPAYISU = new HashSet<EMPPAYISU>();
            EMPPAYOTH = new HashSet<EMPPAYOTH>();
            EMPPAYWRK = new HashSet<EMPPAYWRK>();
        }

        public Guid ID { get; set; }
        public string YYYYMM { get; set; }
        public string EMP_NO { get; set; }
        public string CORP_NO { get; set; }
        public string DCL_CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string SER_NO { get; set; }
        public string JOB_NO { get; set; }
        public string C_SAL_TY { get; set; }
        public decimal? HR_SLY { get; set; }
        public DateTime? ARV_DT { get; set; }
        public DateTime? LEV_DT { get; set; }
        public int? PT_DAY { get; set; }
        public decimal? TAX_INC { get; set; }
        public decimal? EXP_AMT { get; set; }
        public decimal? AMT { get; set; }
        public string C_SOURCE { get; set; }
        public string C_AJS { get; set; }
        public string AVCH_TY { get; set; }
        public string AVCH_NO { get; set; }
        public string REMK { get; set; }
        public string C_CFM { get; set; }
        public DateTime? CFM_DT { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string CFM_USR_NO { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<EMPPAYACT> EMPPAYACT { get; set; }
        public virtual ICollection<EMPPAYAJS> EMPPAYAJS { get; set; }
        public virtual ICollection<EMPPAYDL> EMPPAYDL { get; set; }
        public virtual ICollection<EMPPAYDPC> EMPPAYDPC { get; set; }
        public virtual ICollection<EMPPAYDRAW> EMPPAYDRAW { get; set; }
        public virtual ICollection<EMPPAYEQUIP> EMPPAYEQUIP { get; set; }
        public virtual ICollection<EMPPAYFM> EMPPAYFM { get; set; }
        public virtual ICollection<EMPPAYFRL> EMPPAYFRL { get; set; }
        public virtual ICollection<EMPPAYIJT> EMPPAYIJT { get; set; }
        public virtual ICollection<EMPPAYISU> EMPPAYISU { get; set; }
        public virtual ICollection<EMPPAYOTH> EMPPAYOTH { get; set; }
        public virtual ICollection<EMPPAYWRK> EMPPAYWRK { get; set; }
    }
}
