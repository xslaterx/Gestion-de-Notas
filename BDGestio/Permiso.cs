using BDGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestion
{
    public class Permiso
    {
        public int PermisoId { get; set; }
        public string Nombre { get; set; }
      
        public string Detalles { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
