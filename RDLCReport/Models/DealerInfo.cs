using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RDLCReport.Models
{
    public class DealerInfo
    {
        [Key]
        public int Id { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string DealerMobileNo { get; set; }
        public string ExecutiveName { get; set; }
        public string RSMName { get; set; }
        public string Zone { get; set; }
    }
}