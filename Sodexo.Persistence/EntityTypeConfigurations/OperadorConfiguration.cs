using Sodexo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence.EntityTypeConfigurations
{
    public class OperadorConfiguration : EntityTypeConfiguration<Operador>
    {
        public OperadorConfiguration()
        {
            ToTable("Operador");

            HasKey(o => o.OperadorId);

            HasRequired(o => o.Persona)
                .WithOptional(p => p.Operador)
                .Map(t => t.MapKey("Operador_Id"));
        }
                
            
        
    }
}
