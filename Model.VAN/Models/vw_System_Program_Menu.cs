using System;
using System.Collections.Generic;
using System.Text;

namespace Model.VAN.Models
{
    public partial class vw_System_Program_Menu
    {
        public Guid ID { get; set; }
        public string SYSNO { get; set; }
        public string SYSNO_NAME { get; set; }
        public string Kind_Name { get; set; }
        public string PRGNO { get; set; }
        public string PROGRAMNO_NAME { get; set; }
        public string PROG_URL1 { get; set; }
        public string PROG_URL2 { get; set; }
        public int SYSTEMNO_ORDERID { get; set; }
        public Guid SYS_SYSTEMNO_Id { get; set; }
        public string BASCodeTableDetail_OrderSR { get; set; }
        public Guid BASCodeTableDetail_Id { get; set; }
        public int PROGRAMNO_ORDERID { get; set; }
        public Guid PROGRAMNO_Id { get; set; }
        public string emp_no { get; set; }
        public int SYS_SR { get; set; }
    }
}
