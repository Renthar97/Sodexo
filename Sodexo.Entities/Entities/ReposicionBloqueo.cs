using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class ReposicionBloqueo
    {
        public int ReposicionBloqueoId { get; set; }
        public string Bloqueo { get; set; }
        public decimal CostoReposicion { get; set; }
        public decimal CostoEnvio { get; set; }
        public Tarjeta Tarjeta_id { get; set; }
        public Persona Persona_id { get; set; }

    }
}
