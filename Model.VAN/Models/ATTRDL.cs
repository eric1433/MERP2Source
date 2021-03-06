﻿using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ATTRDL
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string ATTR_TY { get; set; }
        public string ATTR_NO { get; set; }
        public string ATTR_NM { get; set; }
        public string ATTR_SR { get; set; }
        public string C_TY { get; set; }
        public string TABLE_NM { get; set; }
        public string PRG_NO { get; set; }
        public string C_SOURCE { get; set; }
        public string C_STA { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ATTRMT P { get; set; }
    }
}
