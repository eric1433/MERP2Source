﻿using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class EMPCORP
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string EMP_NO { get; set; }
        public string CORP_NO { get; set; }
        public DateTime? ARV_DT { get; set; }
        public DateTime? LEV_DT { get; set; }
        public string DEPM_NO { get; set; }
        public string SER_NO { get; set; }
        public string C_SAL_TY { get; set; }
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
