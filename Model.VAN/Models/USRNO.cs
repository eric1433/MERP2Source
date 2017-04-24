using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class USRNO
    {
        public USRNO()
        {
            USRARDEPM = new HashSet<USRARDEPM>();
            USRGRP = new HashSet<USRGRP>();
            USRIVCDEPM = new HashSet<USRIVCDEPM>();
            USRPMS = new HashSet<USRPMS>();
            USRRARDEPM = new HashSet<USRRARDEPM>();
        }

        public Guid ID { get; set; }
        public string USR_NO { get; set; }
        public string USR_NM { get; set; }
        public string CORP_NO { get; set; }
        public string GRP_NO { get; set; }
        public string SLY_DEPM_NO { get; set; }
        public string USR_PW { get; set; }
        public string C_SUPER { get; set; }
        public DateTime? EFF_DT { get; set; }
        public DateTime? EXP_DT { get; set; }
        public DateTime? PW_DT { get; set; }
        public int? VLD_DAY { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<USRARDEPM> USRARDEPM { get; set; }
        public virtual ICollection<USRGRP> USRGRP { get; set; }
        public virtual ICollection<USRIVCDEPM> USRIVCDEPM { get; set; }
        public virtual ICollection<USRPMS> USRPMS { get; set; }
        public virtual ICollection<USRRARDEPM> USRRARDEPM { get; set; }
    }
}
