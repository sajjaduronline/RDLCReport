using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDLCReport.Models
{
    public class TMSaleReport
    {
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
    
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemModel { get; set; }
        public string Color { get; set; }
        public string EngineNo { get; set; }

        public string ChassisNo { get; set; }

        public string RetailCustomerName { get; set; }

        public string RetailCustomerMobileNo { get; set; }
        public string RetailCustomerAddress { get; set; }

        public DateTime? SaleDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Remark { get; set; }
        public string Executive { get; set; }
        public string RSM { get; set; }
        public string Zone { get; set; }
    
    }
}