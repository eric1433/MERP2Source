using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPLOYEE
    {
        public EMPLOYEE()
        {
            EMPALW = new HashSet<EMPALW>();
            EMPCORP = new HashSet<EMPCORP>();
            EMPDRAW = new HashSet<EMPDRAW>();
            EMPEQUIP = new HashSet<EMPEQUIP>();
            EMPEXAM = new HashSet<EMPEXAM>();
            EMPFM = new HashSet<EMPFM>();
            EMPFMCHG = new HashSet<EMPFMCHG>();
            EMPIJT = new HashSet<EMPIJT>();
            EMPISU = new HashSet<EMPISU>();
            EMPISUCHG = new HashSet<EMPISUCHG>();
            EMPPMS = new HashSet<EMPPMS>();
        }

        public Guid ID { get; set; }
        public string EMP_NO { get; set; }
        public string EMP_NM { get; set; }
        public string CORP_NO { get; set; }
        public string DEPM_NO { get; set; }
        public string SER_NO { get; set; }
        public string OEMP_NO { get; set; }
        public string JOB_NO { get; set; }
        public string JOB_TITLE { get; set; }
        public string JOB_RK { get; set; }
        public string C_SAL_TY { get; set; }
        public string SLV_NO { get; set; }
        public string C_PAY_TY { get; set; }
        public string DW_PRD { get; set; }
        public decimal? IJT_RT { get; set; }
        public int? IJT_BASE { get; set; }
        public string ID_NO { get; set; }
        public string BANK_NO { get; set; }
        public string BANK_ID { get; set; }
        public string ACC_NM { get; set; }
        public string ACC_NO { get; set; }
        public string ACC_ID_NO { get; set; }
        public string C_STA { get; set; }
        public string SEX { get; set; }
        public DateTime? BRD_DT { get; set; }
        public string MRD { get; set; }
        public string BLOOD { get; set; }
        public string ADDR_RGS { get; set; }
        public string ZNO_RGS { get; set; }
        public string ADDR_MAL { get; set; }
        public string ZNO_MAL { get; set; }
        public string CONTACTER { get; set; }
        public string RELA { get; set; }
        public string CON_TEL_NO { get; set; }
        public string TEL_NO { get; set; }
        public string TEL_NO2 { get; set; }
        public string TEL_NO3 { get; set; }
        public string E_MAIL { get; set; }
        public DateTime? ARV_DT { get; set; }
        public DateTime? LEV_DT { get; set; }
        public DateTime? SPS_DT { get; set; }
        public DateTime? RSU_DT { get; set; }
        public DateTime? CHK_DT { get; set; }
        public DateTime? ETR_DT { get; set; }
        public DateTime? RTN_DT { get; set; }
        public DateTime? ISU_DT { get; set; }
        public DateTime? RIS_DT { get; set; }
        public int LAB_WYR_YY { get; set; }
        public int LAB_WYR_DD { get; set; }
        public DateTime? WYR_DT { get; set; }
        public string EDU_NO { get; set; }
        public string SCH_NO { get; set; }
        public string MJR_NO { get; set; }
        public string LEV_NO { get; set; }
        public int? ATTR { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<EMPALW> EMPALW { get; set; }
        public virtual ICollection<EMPCORP> EMPCORP { get; set; }
        public virtual ICollection<EMPDRAW> EMPDRAW { get; set; }
        public virtual ICollection<EMPEQUIP> EMPEQUIP { get; set; }
        public virtual ICollection<EMPEXAM> EMPEXAM { get; set; }
        public virtual ICollection<EMPFM> EMPFM { get; set; }
        public virtual ICollection<EMPFMCHG> EMPFMCHG { get; set; }
        public virtual ICollection<EMPIJT> EMPIJT { get; set; }
        public virtual ICollection<EMPISU> EMPISU { get; set; }
        public virtual ICollection<EMPISUCHG> EMPISUCHG { get; set; }
        public virtual ICollection<EMPPMS> EMPPMS { get; set; }
    }
}
