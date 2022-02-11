namespace JayFashio_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vb : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.carts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        path = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
