using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class IVCMM
    {
        public IVCMM()
        {
            IVCMMDEPM = new HashSet<IVCMMDEPM>();
            IVCMMUSR = new HashSet<IVCMMUSR>();
            IVCMMVCH = new HashSet<IVCMMVCH>();
        }

        public Guid ID { get; set; }
        public string YYYYMM { get; set; }
        public string IVC_GRP { get; set; }
        public string IVC_NO { get; set; }
        public string IVC_NO_E { get; set; }
        public string YYYYMM_E { get; set; }
        public string C_VCH { get; set; }
        public string C_DEPM { get; set; }
        public string C_USR { get; set; }
        public string CORP_NO { get; set; }
        public string UNIQUE_NO { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
        public string IVC_PAGE { get; set; }

        public virtual ICollection<IVCMMDEPM> IVCMMDEPM { get; set; }
        public virtual ICollection<IVCMMUSR> IVCMMUSR { get; set; }
        public virtual ICollection<IVCMMVCH> IVCMMVCH { get; set; }
    }
}
