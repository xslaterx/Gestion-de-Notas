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
        public string Codigo { get; set; }  
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }    
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
        public string Enfermedad {  get; set; } 
        public string Medicamento   { get; set; }
        public string NumeroEmergencia { get; set; }    
        public string TutorNombre { get; set; }
        public string Tutor {  get; set; }  
        public string Sexo      { get; set; }
        public virtual  ICollection<Calificacion> Calificaciones { get; set; }
    }
}
