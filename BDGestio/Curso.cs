﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDGestion
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public required string Nombre { get; set; }
        public virtual required ICollection<Calificacion> Calificaciones { get; set; }
    }
}
