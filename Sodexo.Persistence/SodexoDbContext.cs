using Sodexo.Entities;
using Sodexo.Entities.Entities;
using Sodexo.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence
{
    public class SodexoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Operador> Operador { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Llamada> Llamada { get; set; }
        public DbSet<Reclamo> Reclamo { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<ReposicionBloqueo> ReposicionBloqueo { get; set; }
        public DbSet<Atencion> Atencion { get; set; }
        public DbSet<Envio> Envio { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AtencionConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EnvioConfiguration());
            modelBuilder.Configurations.Add(new LlamadaConfiguration());
            modelBuilder.Configurations.Add(new OperadorConfiguration());
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new ReclamoConfiguration());
            modelBuilder.Configurations.Add(new ReposicionBloqueoConfiguration());
            modelBuilder.Configurations.Add(new TarjetaConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        }
}
