using System;
using System.Collections.Generic;

namespace Model.VAN.Models
{
    public partial class ErrorLog
    {
        public Guid ID { get; set; }
        public string ErroFunction { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime? Date { get; set; }
    }
}
