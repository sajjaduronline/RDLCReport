using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDLCReport.Models
{

   
    public class RetailSale
    {
        [Key]  
        public int Id { get; set; }
        [Required] 
        public string DealerCode { get; set;}
        [Required]
        public string ItemCode { get; set;}
        public string ItemName { get; set; }
        public string ItemModel { get; set; }
        public string Color { get; set; }
        [Required]
        public double Quantity { get; set; }
        
        public string EngineNo { get; set; }
      
        public string ChassisNo { get; set; }
        
        public string RetailCustomerName { get; set; }
      
        public string RetailCustomerMobileNo { get; set; }
        public string RetailCustomerAddress { get; set; }
     
        public DateTime? SaleDate { get; set;}
        public DateTime? EntryDate { get; set; }
       
  
        
        [Required]
        public string CreatedBy { get; set;}
        public string Remark { get; set; }


    }
}