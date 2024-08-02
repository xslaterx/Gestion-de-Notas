using BDGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestion
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public bool Estado { get; set; }
        public int CursoId { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime date { get; set; }
      
       

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Asignatura Asignatura { get; set; }


    }
}
