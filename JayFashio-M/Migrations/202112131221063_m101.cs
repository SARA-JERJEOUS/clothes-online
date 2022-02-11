namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m101 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Description", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
