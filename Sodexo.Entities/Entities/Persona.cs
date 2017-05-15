using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }

        public string Nombre { get; set; }

        public string Apellido_Paterno { get; set; }

        public string Apellido_Materno { get; set; }

        public Operador Operador { get; set; }
        public Cliente Cliente { get; set; }
    }
}
