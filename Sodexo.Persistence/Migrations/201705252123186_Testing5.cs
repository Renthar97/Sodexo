namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Atencion", "Cliente_Id_ClienteId", c => c.Int());
            AddColumn("dbo.Atencion", "Llamada_id_LlamadaId", c => c.Int());
            AddColumn("dbo.Atencion", "Operarodor_id_OperadorId", c => c.Int());
            AddColumn("dbo.Atencion", "Reclamo_id_ReclamoId", c => c.Int());
            AddColumn("dbo.Atencion", "ReposicionBloqueo_id_ReposicionBloqueoId", c => c.Int());
            AddColumn("dbo.Reposicion_Bloqueo", "Persona_id_PersonaId", c => c.Int());
            AddColumn("dbo.Reposicion_Bloqueo", "Tarjeta_id_TarjetaId", c => c.Int());
            CreateIndex("dbo.Atencion", "Cliente_Id_ClienteId");
            CreateIndex("dbo.Atencion", "Llamada_id_LlamadaId");
            CreateIndex("dbo.Atencion", "Operarodor_id_OperadorId");
            CreateIndex("dbo.Atencion", "Reclamo_id_ReclamoId");
            CreateIndex("dbo.Atencion", "ReposicionBloqueo_id_ReposicionBloqueoId");
            CreateIndex("dbo.Reposicion_Bloqueo", "Persona_id_PersonaId");
            CreateIndex("dbo.Reposicion_Bloqueo", "Tarjeta_id_TarjetaId");
            AddForeignKey("dbo.Atencion", "Cliente_Id_ClienteId", "dbo.Cliente", "ClienteId");
            AddForeignKey("dbo.Atencion", "Llamada_id_LlamadaId", "dbo.Llamada", "LlamadaId");
            AddForeignKey("dbo.Atencion", "Operarodor_id_OperadorId", "dbo.Operador", "OperadorId");
            AddForeignKey("dbo.Atencion", "Reclamo_id_ReclamoId", "dbo.Reclamo", "ReclamoId");
            AddForeignKey("dbo.Reposicion_Bloqueo", "Persona_id_PersonaId", "dbo.Persona", "PersonaId");
            AddForeignKey("dbo.Reposicion_Bloqueo", "Tarjeta_id_TarjetaId", "dbo.Tarjeta", "TarjetaId");
            AddForeignKey("dbo.Atencion", "ReposicionBloqueo_id_ReposicionBloqueoId", "dbo.Reposicion_Bloqueo", "ReposicionBloqueoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atencion", "ReposicionBloqueo_id_ReposicionBloqueoId", "dbo.Reposicion_Bloqueo");
            DropForeignKey("dbo.Reposicion_Bloqueo", "Tarjeta_id_TarjetaId", "dbo.Tarjeta");
            DropForeignKey("dbo.Reposicion_Bloqueo", "Persona_id_PersonaId", "dbo.Persona");
            DropForeignKey("dbo.Atencion", "Reclamo_id_ReclamoId", "dbo.Reclamo");
            DropForeignKey("dbo.Atencion", "Operarodor_id_OperadorId", "dbo.Operador");
            DropForeignKey("dbo.Atencion", "Llamada_id_LlamadaId", "dbo.Llamada");
            DropForeignKey("dbo.Atencion", "Cliente_Id_ClienteId", "dbo.Cliente");
            DropIndex("dbo.Reposicion_Bloqueo", new[] { "Tarjeta_id_TarjetaId" });
            DropIndex("dbo.Reposicion_Bloqueo", new[] { "Persona_id_PersonaId" });
            DropIndex("dbo.Atencion", new[] { "ReposicionBloqueo_id_ReposicionBloqueoId" });
            DropIndex("dbo.Atencion", new[] { "Reclamo_id_ReclamoId" });
            DropIndex("dbo.Atencion", new[] { "Operarodor_id_OperadorId" });
            DropIndex("dbo.Atencion", new[] { "Llamada_id_LlamadaId" });
            DropIndex("dbo.Atencion", new[] { "Cliente_Id_ClienteId" });
            DropColumn("dbo.Reposicion_Bloqueo", "Tarjeta_id_TarjetaId");
            DropColumn("dbo.Reposicion_Bloqueo", "Persona_id_PersonaId");
            DropColumn("dbo.Atencion", "ReposicionBloqueo_id_ReposicionBloqueoId");
            DropColumn("dbo.Atencion", "Reclamo_id_ReclamoId");
            DropColumn("dbo.Atencion", "Operarodor_id_OperadorId");
            DropColumn("dbo.Atencion", "Llamada_id_LlamadaId");
            DropColumn("dbo.Atencion", "Cliente_Id_ClienteId");
        }
    }
}
