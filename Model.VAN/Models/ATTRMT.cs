using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ATTRMT
    {
        public ATTRMT()
        {
            ATTRDL = new HashSet<ATTRDL>();
        }

        public Guid ID { get; set; }
        public string ATTR_TY { get; set; }
        public string ATTR_NM { get; set; }
        public string C_SOURCE { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<ATTRDL> ATTRDL { get; set; }
    }
}
