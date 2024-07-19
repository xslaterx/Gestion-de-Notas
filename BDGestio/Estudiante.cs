using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
        public virtual required ICollection<Calificacion> Calificaciones { get; set; }
    }
}
