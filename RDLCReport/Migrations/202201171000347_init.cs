namespace RDLCReport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DealerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DealerCode = c.String(),
                        DealerName = c.String(),
                        DealerMobileNo = c.String(),
                        ExecutiveName = c.String(),
                        RSMName = c.String(),
                        Zone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RetailSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DealerCode = c.String(nullable: false),
                        ItemCode = c.String(nullable: false),
                        ItemName = c.String(),
                        ItemModel = c.String(),
                        Color = c.String(),
                        Quantity = c.Double(nullable: false),
                        EngineNo = c.String(),
                        ChassisNo = c.String(),
                        RetailCustomerName = c.String(),
                        RetailCustomerMobileNo = c.String(),
                        RetailCustomerAddress = c.String(),
                        SaleDate = c.DateTime(),
                        EntryDate = c.DateTime(),
                        CreatedBy = c.String(nullable: false),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RetailSales");
            DropTable("dbo.DealerInfoes");
        }
    }
}
