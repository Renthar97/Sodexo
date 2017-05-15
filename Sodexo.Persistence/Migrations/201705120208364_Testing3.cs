namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operador", "Tipo_Operador", c => c.String());
            AddColumn("dbo.Operador", "Operador_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Operador", "Operador_Id");
            AddForeignKey("dbo.Operador", "Operador_Id", "dbo.Persona", "PersonaId");
            DropColumn("dbo.Operador", "TipoOperador");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Operador", "TipoOperador", c => c.String());
            DropForeignKey("dbo.Operador", "Operador_Id", "dbo.Persona");
            DropIndex("dbo.Operador", new[] { "Operador_Id" });
            DropColumn("dbo.Operador", "Operador_Id");
            DropColumn("dbo.Operador", "Tipo_Operador");
        }
    }
}
