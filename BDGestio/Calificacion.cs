using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
      public class Calificacion
    {
        [Key]
        public int CalificacionId { get; set; }
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }
        public decimal Nota { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
