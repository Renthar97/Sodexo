using Sodexo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Persistence.EntityTypeConfigurations
{
    public class ReposicionBloqueoConfiguration : EntityTypeConfiguration<ReposicionBloqueo>
    {
        public ReposicionBloqueoConfiguration()
        {
            ToTable("Reposicion_Bloqueo");
        }
    }
}
