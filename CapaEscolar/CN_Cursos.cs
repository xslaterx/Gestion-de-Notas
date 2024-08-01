using BDGestion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEscolar
{
    public class CN_Cursos
    {
        private CD_Curso odjcd_curso = new CD_Curso();


        public List<Curso> Listar()
        {
            return odjcd_curso.Listar();
        }

        public int Registrar(Curso obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Nombre == "") { Mensaje += "Es necesario ingresar el nombre del Curso\n"; }
            

            if (Mensaje != string.Empty) { return 0; }
            else { return odjcd_curso.Registrar(obj, out Mensaje); }


        }

        public bool Editar(Curso obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Nombre == "") { Mensaje += "Es necesario ingresar el nombre del Curso\n"; }
            

            if (Mensaje != string.Empty) { return false; }
            else { return odjcd_curso.Editar(obj, out Mensaje); }

        }

        public bool Eliminar(Curso obj, out string Mensaje)
        {

            return odjcd_curso.Eliminar(obj, out Mensaje);
        }

    }
}
