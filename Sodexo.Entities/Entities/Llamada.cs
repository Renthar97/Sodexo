using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Llamada
    {
        public int LlamadaId { get; set; }
        public int NroEntrante { get; set; }
        public decimal Duracion { get; set; }
        public string TipoAtencion { get; set; }
    }
}
