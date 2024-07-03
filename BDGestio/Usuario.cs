using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDGestion
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
