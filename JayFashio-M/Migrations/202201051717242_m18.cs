namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "PathImage", c => c.String(nullable: false));
            AddColumn("dbo.Items", "PathItem", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "PathItem");
            DropColumn("dbo.Images", "PathImage");
        }
    }
}
