using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Tarjeta
    {
        public int TarjetaId { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
    }
}
