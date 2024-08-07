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
        public int PrimerP {  get; set; }   
        public int SegundoP{ get; set; }
        public int TercerP { get; set; }
        public int CuartoP { get; set; }
        public int ExamenF {  get; set; }
        public int AcumuladoC { get; set; }
        public int ExamenC { get; set; }
        public int AcumuladoEX { get; set; }
        public int ExamenEx { get; set; }
        public double PuntuacionF { get; set; }
        public double Promedio { get; set; }
        public int CompletivoF { get; set; }
        public int FinalEx {  get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }

        public Calificacion()
        {
            
        }

        public Calificacion(int calificacionId , int estudianteId, int cursoId, int primerP, double puntuacionF, double promedio, int segundoP =0, int tercerP=0, int cuartoP=0, int examenF=0, int acumuladoC=0, int examenC=0, int acumuladoEX=0, int examenEx=0, int completivoF=0, int finalEx=0)
        {
            CalificacionId = calificacionId;
            EstudianteId = estudianteId;
            CursoId = cursoId;
            PrimerP = primerP;
            SegundoP = segundoP;
            TercerP = tercerP;
            CuartoP = cuartoP;
            ExamenF = examenF;
            AcumuladoC = acumuladoC;
            ExamenC = examenC;
            AcumuladoEX = acumuladoEX;
            ExamenEx = examenEx;
            PuntuacionF = puntuacionF;
            Promedio = promedio;
            CompletivoF = completivoF;
            FinalEx = finalEx;
        }

        // Calcular el promedio de los primeros 4 periodos
        public double CalcularPromedioPeriodos()
        {
            return (PrimerP + SegundoP + TercerP + CuartoP) / 4;
        }



        // Calcular la puntuación final (70% promedio + 30% examen final)
        public double CalcularPuntuacionFinal()
        {
            double promedioPeriodos = CalcularPromedioPeriodos();
            return (promedioPeriodos * 0.7) + (ExamenF * 0.3);
        }

        // Calcular la puntuación final del completivo
        public double CalcularPuntuacionFinalCompletivo(double acumuladoCompletivo)
        {
            return (ExamenC * 0.5) + acumuladoCompletivo;
        }
        // Calcular el acumulado extraordinario
        public double CalcularAcumuladoExtraordinario(double puntuacionFinalCompletivo)
        {
            return puntuacionFinalCompletivo * 0.3;
        }

        // Calcular la puntuación final del extraordinario
        public double CalcularPuntuacionFinalExtraordinario(double acumuladoExtraordinario)
        {
            return (ExamenEx * 0.7) + acumuladoExtraordinario;
        }
    }


}
