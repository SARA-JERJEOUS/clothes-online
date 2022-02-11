namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m111 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Items", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Description", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
