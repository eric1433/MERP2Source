using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class VCHUSR
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string VCH_TY { get; set; }
        public string USR_NO { get; set; }
        public string C_RUN { get; set; }
        public string C_ADD { get; set; }
        public string C_QRY { get; set; }
        public string C_MDY { get; set; }
        public string C_CFM { get; set; }
        public string C_UCF { get; set; }
        public string C_DEL { get; set; }
        public string C_CST { get; set; }
        public string C_CPY { get; set; }
        public string C_EML { get; set; }
        public string C_ATT { get; set; }
        public string C_SIN { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual VCHCONFG P { get; set; }
    }
}
