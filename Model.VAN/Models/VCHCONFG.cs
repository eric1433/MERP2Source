using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class VCHCONFG
    {
        public VCHCONFG()
        {
            VCHUSR = new HashSet<VCHUSR>();
        }

        public Guid ID { get; set; }
        public string VCH_TY { get; set; }
        public string VCH_NM { get; set; }
        public string EXCH_TY { get; set; }
        public string ATTR { get; set; }
        public int? IO { get; set; }
        public string CODE_TY { get; set; }
        public int? CODE_LEN { get; set; }
        public string DR_ACT_NO { get; set; }
        public string CR_ACT_NO { get; set; }
        public string C_USR { get; set; }
        public string C_SIGN { get; set; }
        public string PRG_NO { get; set; }
        public DateTime? CLS_DT { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<VCHUSR> VCHUSR { get; set; }
    }
}
