namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "DateOFbirth", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.String());
            DropColumn("dbo.Users", "PurchasedItems");
            DropColumn("dbo.Items", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "PurchasedItems", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "DateOFbirth", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 26));
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
