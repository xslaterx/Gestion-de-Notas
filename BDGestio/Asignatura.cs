using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestion
{
    public class Asignatura
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Nombre_asignatura { get; set; }
        public string Descripcion { get; set; }
        public string Departamento { get; set; }
    }
}
