using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
    public class Administrativo
    {
        [Key]
        public int AdministrativoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }
    }
}
