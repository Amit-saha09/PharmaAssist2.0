namespace PharmaAssist2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "LoginId", "dbo.Logins");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "LoginId" });
            AddColumn("dbo.OrderDetails", "InvoiceNumber", c => c.String());
            AddColumn("dbo.OrderDetails", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ConsumerId", c => c.Int());
            AddColumn("dbo.Orders", "InvoiceNumber", c => c.String());
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderDetails", "OrderId");
            CreateIndex("dbo.Orders", "ConsumerId");
            AddForeignKey("dbo.Orders", "ConsumerId", "dbo.Consumers", "Id");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "LoginId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "LoginId", c => c.Int());
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ConsumerId", "dbo.Consumers");
            DropIndex("dbo.Orders", new[] { "ConsumerId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.Int());
            DropColumn("dbo.Orders", "InvoiceNumber");
            DropColumn("dbo.Orders", "ConsumerId");
            DropColumn("dbo.OrderDetails", "Quantity");
            DropColumn("dbo.OrderDetails", "InvoiceNumber");
            CreateIndex("dbo.Orders", "LoginId");
            CreateIndex("dbo.OrderDetails", "OrderId");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "LoginId", "dbo.Logins", "Id");
        }
    }
}
