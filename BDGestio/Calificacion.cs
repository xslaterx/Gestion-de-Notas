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
        public int PrimerP {  get; set; }   
        public int SegundoP{ get; set; }
        public int TercerP { get; set; }
        public int CuartoP { get; set; }
        public int ExamenF {  get; set; }
        public int AcumuladoC { get; set; }
        public int ExamenC { get; set; }
        public int AcumuladoEX { get; set; }
        public int ExamenEx { get; set; }
        public int PuntuacionF { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
