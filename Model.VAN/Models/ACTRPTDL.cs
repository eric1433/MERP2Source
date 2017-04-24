using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ACTRPTDL
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string RPT_NO { get; set; }
        public int RPT_SR { get; set; }
        public string ACT_NO { get; set; }
        public string ACT_NM { get; set; }
        public string ROW_NO { get; set; }
        public int? C_DCR { get; set; }
        public string C_SOURCE { get; set; }
        public string C_POSI { get; set; }
        public string C_DISP { get; set; }
        public string C_DNN { get; set; }
        public string C_ZERO { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual ACTRPTMT P { get; set; }
    }
}
