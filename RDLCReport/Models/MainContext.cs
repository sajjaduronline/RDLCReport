
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RDLCReport.Models
{
    public class MainContext : DbContext
    {
        public MainContext() : base("MainContext")
        {
        }


        public DbSet<RetailSale> RetailSales { get; set; }
 
        public DbSet<DealerInfo> DealerInfos { get; set; }
        





    }
}