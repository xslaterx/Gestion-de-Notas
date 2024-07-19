using BDGestion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEscolar
{
    public class CN_Rol
    {
        private CD_Rol odjcd_rol = new CD_Rol();


        public List<Rol> Listar()
        {
            return odjcd_rol.Listar();
        }
    }
}
