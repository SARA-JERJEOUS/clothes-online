namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DateOFbirth", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DateOFbirth", c => c.Int(nullable: false));
        }
    }
}
