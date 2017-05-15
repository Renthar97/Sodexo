using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int NroTarjeta { get; set; }
        public string TipoCliente { get; set; }
        public Persona Persona { get; set; }
    }
}
