namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Atencions", newName: "Atencion");
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            RenameTable(name: "dbo.Envios", newName: "Envio");
            RenameTable(name: "dbo.Llamadas", newName: "Llamada");
            RenameTable(name: "dbo.Operadors", newName: "Operador");
            RenameTable(name: "dbo.Personas", newName: "Persona");
            RenameTable(name: "dbo.Reclamoes", newName: "Reclamo");
            RenameTable(name: "dbo.ReposicionBloqueos", newName: "Reposicion_Bloqueo");
            RenameTable(name: "dbo.Tarjetas", newName: "Tarjeta");
            RenameTable(name: "dbo.Users", newName: "Usuario");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Usuario", newName: "Users");
            RenameTable(name: "dbo.Tarjeta", newName: "Tarjetas");
            RenameTable(name: "dbo.Reposicion_Bloqueo", newName: "ReposicionBloqueos");
            RenameTable(name: "dbo.Reclamo", newName: "Reclamoes");
            RenameTable(name: "dbo.Persona", newName: "Personas");
            RenameTable(name: "dbo.Operador", newName: "Operadors");
            RenameTable(name: "dbo.Llamada", newName: "Llamadas");
            RenameTable(name: "dbo.Envio", newName: "Envios");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
            RenameTable(name: "dbo.Atencion", newName: "Atencions");
        }
    }
}
