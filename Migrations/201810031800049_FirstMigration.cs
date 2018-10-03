namespace CrudResourceIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Address = c.String(maxLength: 100, unicode: false),
                        Phone = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 100, unicode: false),
                        LastName = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        IdDetails = c.Guid(nullable: false),
                        Detail_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Details", t => t.Detail_Id)
                .Index(t => t.Detail_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Detail_Id", "dbo.Details");
            DropIndex("dbo.Users", new[] { "Detail_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Details");
        }
    }
}
