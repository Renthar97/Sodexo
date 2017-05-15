namespace Sodexo.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atencions",
                c => new
                    {
                        AtencionId = c.Int(nullable: false, identity: true),
                        Comentario = c.String(),
                    })
                .PrimaryKey(t => t.AtencionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        NroTarjeta = c.Int(nullable: false),
                        TipoCliente = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Envios",
                c => new
                    {
                        EnvioId = c.Int(nullable: false, identity: true),
                        Direccion = c.String(),
                        Region = c.String(),
                        Provincia = c.String(),
                        Distrito = c.String(),
                        Persona_contacto = c.String(),
                        Telefono_contacto = c.String(),
                    })
                .PrimaryKey(t => t.EnvioId);
            
            CreateTable(
                "dbo.Llamadas",
                c => new
                    {
                        LlamadaId = c.Int(nullable: false, identity: true),
                        NroEntrante = c.Int(nullable: false),
                        Duracion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoAtencion = c.String(),
                    })
                .PrimaryKey(t => t.LlamadaId);
            
            CreateTable(
                "dbo.Operadors",
                c => new
                    {
                        OperadorId = c.Int(nullable: false, identity: true),
                        TipoOperador = c.String(),
                    })
                .PrimaryKey(t => t.OperadorId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido_Paterno = c.String(),
                        Apellido_Materno = c.String(),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.Reclamoes",
                c => new
                    {
                        ReclamoId = c.Int(nullable: false, identity: true),
                        Categoria = c.String(),
                        Subcategoria = c.String(),
                        Nivel = c.String(),
                        Comentario = c.String(),
                        Evidencia = c.String(),
                    })
                .PrimaryKey(t => t.ReclamoId);
            
            CreateTable(
                "dbo.ReposicionBloqueos",
                c => new
                    {
                        ReposicionBloqueoId = c.Int(nullable: false, identity: true),
                        Bloqueo = c.String(),
                        CostoReposicion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostoEnvio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ReposicionBloqueoId);
            
            CreateTable(
                "dbo.Tarjetas",
                c => new
                    {
                        TarjetaId = c.Int(nullable: false, identity: true),
                        Categoria = c.String(),
                        Tipo = c.String(),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TarjetaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tarjetas");
            DropTable("dbo.ReposicionBloqueos");
            DropTable("dbo.Reclamoes");
            DropTable("dbo.Personas");
            DropTable("dbo.Operadors");
            DropTable("dbo.Llamadas");
            DropTable("dbo.Envios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Atencions");
        }
    }
}
