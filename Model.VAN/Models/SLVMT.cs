using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class SLVMT
    {
        public SLVMT()
        {
            SLVDL = new HashSet<SLVDL>();
            SLVISU = new HashSet<SLVISU>();
        }

        public Guid ID { get; set; }
        public string CORP_NO { get; set; }
        public string SLV_NO { get; set; }
        public string SLV_NM { get; set; }
        public decimal? AMT { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ICollection<SLVDL> SLVDL { get; set; }
        public virtual ICollection<SLVISU> SLVISU { get; set; }
    }
}
