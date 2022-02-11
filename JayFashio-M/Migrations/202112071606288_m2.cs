namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Images", "Extension");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Extension", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
