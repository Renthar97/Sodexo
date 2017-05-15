namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Cliente_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Cliente", "Cliente_id");
            AddForeignKey("dbo.Cliente", "Cliente_id", "dbo.Persona", "PersonaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "Cliente_id", "dbo.Persona");
            DropIndex("dbo.Cliente", new[] { "Cliente_id" });
            DropColumn("dbo.Cliente", "Cliente_id");
        }
    }
}
