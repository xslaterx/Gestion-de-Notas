using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
    public class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }    
        public string Departamento { get; set; } 
    }
}
