using Sodexo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence.EntityTypeConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");

            HasKey(c => c.ClienteId);

            HasRequired(o => o.Persona)
                .WithOptional(p => p.Cliente)
                .Map(t => t.MapKey("Cliente_id"));
        }
    }
}
