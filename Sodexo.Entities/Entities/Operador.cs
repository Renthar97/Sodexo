using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Operador
    {

        public int OperadorId { get; set; }
        public  Persona Persona { get; set; }

        public string Tipo_Operador { get; set; }
    }
}
