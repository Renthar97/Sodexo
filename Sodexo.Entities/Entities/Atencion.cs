using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodexo.Entities.Entities
{
    public class Atencion
    {
        public int AtencionId { get; set; }
        public Operador Operarodor_id { get; set; }
        public Cliente Cliente_Id { get; set; }
        public Llamada Llamada_id { get; set; }
        public Reclamo Reclamo_id { get; set; }
        public ReposicionBloqueo ReposicionBloqueo_id { get; set; }
        public string Comentario { get; set; }
    }
}
