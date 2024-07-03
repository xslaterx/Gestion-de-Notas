using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
    public class Maestro
    {
        [Key]
        public int MaestroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
