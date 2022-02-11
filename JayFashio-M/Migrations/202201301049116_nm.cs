namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.categories", "categoryname", c => c.String());
            DropColumn("dbo.categories", "Menhoodi");
            DropColumn("dbo.categories", "Menjacket");
            DropColumn("dbo.categories", "Menshort");
            DropColumn("dbo.categories", "Mentshirt");
            DropColumn("dbo.categories", "womanhoodi");
            DropColumn("dbo.categories", "womanjacket");
            DropColumn("dbo.categories", "womanSweatshirt");
            DropColumn("dbo.categories", "womanshirt");
            DropColumn("dbo.categories", "kidhoodi");
            DropColumn("dbo.categories", "kidjacket");
            DropColumn("dbo.categories", "kidshort");
            DropColumn("dbo.categories", "kidtshirt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.categories", "kidtshirt", c => c.String());
            AddColumn("dbo.categories", "kidshort", c => c.String());
            AddColumn("dbo.categories", "kidjacket", c => c.String());
            AddColumn("dbo.categories", "kidhoodi", c => c.String());
            AddColumn("dbo.categories", "womanshirt", c => c.String());
            AddColumn("dbo.categories", "womanSweatshirt", c => c.String());
            AddColumn("dbo.categories", "womanjacket", c => c.String());
            AddColumn("dbo.categories", "womanhoodi", c => c.String());
            AddColumn("dbo.categories", "Mentshirt", c => c.String());
            AddColumn("dbo.categories", "Menshort", c => c.String());
            AddColumn("dbo.categories", "Menjacket", c => c.String());
            AddColumn("dbo.categories", "Menhoodi", c => c.String());
            DropColumn("dbo.categories", "categoryname");
        }
    }
}
