using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class FILEDL
    {
        public Guid ID { get; set; }
        public Guid PID { get; set; }
        public string GUID { get; set; }
        public string FILENAME { get; set; }
        public byte[] FILECONTENT { get; set; }
        public string FILETYPE { get; set; }
        public int? FILELENGTH { get; set; }
        public string FILEEXTNAME { get; set; }
        public string PATH { get; set; }
        public string FULLPATH { get; set; }
        public DateTime? CREATETIME { get; set; }
        public DateTime? LASTWRITETIME { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public DateTime? ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public DateTime? MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }

        public virtual FILEMT P { get; set; }
    }
}
