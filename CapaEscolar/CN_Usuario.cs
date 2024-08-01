using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using BDGestion;

namespace CapaEscolar
{
    public class CN_Usuario
    {
        private CD_Usuario odjcd_usuario = new CD_Usuario();


        public List <Usuario> Listar()
        {
            return odjcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty; 
            if(obj.Username == "") { Mensaje += "Es necesario ingresar el nombre del usuario\n"; }
            if (obj.Password == "") { Mensaje += "Es necesario ingresar la contraseña del usuario\n"; }

            if (Mensaje  != string.Empty) { return 0; }
            else { return odjcd_usuario.Registrar(obj, out Mensaje); }

            
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Username == "") { Mensaje += "Es necesario ingresar el nombre del usuario\n"; }
            if (obj.Password == "") { Mensaje += "Es necesario ingresar la contraseña del usuario\n"; }

            if (Mensaje != string.Empty) { return false; }
            else { return odjcd_usuario.Editar(obj, out Mensaje); }
            
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {

            return odjcd_usuario.Eliminar(obj, out Mensaje);
        }

    }
}
