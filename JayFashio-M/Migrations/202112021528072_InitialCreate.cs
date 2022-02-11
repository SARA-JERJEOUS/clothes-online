namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 26),
                        Password = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 25),
                        DateOFbirth = c.Int(nullable: false),
                        Role = c.String(),
                        CityId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Extension = c.String(nullable: false, maxLength: 25),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        SizeMultiplier = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Description = c.String(nullable: false, maxLength: 25),
                        Color = c.String(nullable: false, maxLength: 25),
                        Size = c.String(nullable: false, maxLength: 25),
                        Rating = c.Single(nullable: false),
                        Material = c.String(nullable: false, maxLength: 25),
                        Price = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Users", "CityId", "dbo.Cities");
            DropIndex("dbo.Images", new[] { "ItemId" });
            DropIndex("dbo.Users", new[] { "CityId" });
            DropTable("dbo.Items");
            DropTable("dbo.Images");
            DropTable("dbo.Users");
            DropTable("dbo.Cities");
        }
    }
}
