namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class l10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Menhoodi = c.String(),
                        Menjacket = c.String(),
                        Menshort = c.String(),
                        Mentshirt = c.String(),
                        womanhoodi = c.String(),
                        womanjacket = c.String(),
                        womanSweatshirt = c.String(),
                        womanshirt = c.String(),
                        kidhoodi = c.String(),
                        kidjacket = c.String(),
                        kidshort = c.String(),
                        kidtshirt = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Items", "categoryID", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "coun", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "categoryID");
            AddForeignKey("dbo.Items", "categoryID", "dbo.categories", "ID", cascadeDelete: true);
            DropColumn("dbo.Images", "Width");
            DropColumn("dbo.Images", "Height");
            DropColumn("dbo.Images", "SizeMultiplier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "SizeMultiplier", c => c.Int(nullable: false));
            AddColumn("dbo.Images", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.Images", "Width", c => c.Int(nullable: false));
            DropForeignKey("dbo.Items", "categoryID", "dbo.categories");
            DropIndex("dbo.Items", new[] { "categoryID" });
            DropColumn("dbo.Items", "coun");
            DropColumn("dbo.Items", "categoryID");
            DropTable("dbo.categories");
        }
    }
}
