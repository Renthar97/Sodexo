namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Usuario = c.String(),
                        Password = c.String(),
                        Anexo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
