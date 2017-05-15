using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Reclamo
    {
        public int ReclamoId { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Nivel { get; set; }
        public string Comentario { get; set; }
        public string Evidencia { get; set; }
    }
}
