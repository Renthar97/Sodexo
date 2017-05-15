using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Envio
    {
        public int EnvioId { get; set; }
        public string Direccion { get; set; }
        public string Region { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Persona_contacto { get; set; }
        public string Telefono_contacto { get; set; }

    }
}
