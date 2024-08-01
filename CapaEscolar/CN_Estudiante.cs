using BDGestion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEscolar
{
    public class CN_Estudiante
    {
        private CD_Estudiante odjcd_estudiante = new CD_Estudiante();


        public List<Estudiante> Listar()
        {
            return odjcd_estudiante.Listar();
        }

        public int Registrar(Estudiante obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Codigo == "") { Mensaje += "Es necesario ingresar el Codigo del estudiante\n"; }
            if (obj.Nombre == "") { Mensaje += "Es necesario ingresar el nombre del estudiante\n"; }
            if (obj.Apellido == "") { Mensaje += "Es necesario ingresar el apellido del estudiante\n"; }
            if(obj.FechaRegistro == "") { Mensaje += "Es necesario ingresar el apellido del estudiante\n"; }
            if (obj.TutorNombre == "") { Mensaje += "Es necesario ingresar el nombre del Tutor\n"; }
            if (obj.Tutor == "") { Mensaje += "Es necesario ingresar el parentesco del tutor\n"; }
            if (obj.Sexo == "") { Mensaje += "Es necesario ingresar el Sexo del estudiante\n"; }
            if (Mensaje != string.Empty) { return 0; }
            else { return odjcd_estudiante.Registrar(obj, out Mensaje); }


        }

        public bool Editar(Estudiante obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Codigo == "") { Mensaje += "Es necesario ingresar el Codigo del estudiante\n"; }
            if (obj.Nombre == "") { Mensaje += "Es necesario ingresar el nombre del estudiante\n"; }
            if (obj.Apellido == "") { Mensaje += "Es necesario ingresar el apellido del estudiante\n"; }
            if (obj.FechaRegistro == "") { Mensaje += "Es necesario ingresar el apellido del estudiante\n"; }
            if (obj.TutorNombre == "") { Mensaje += "Es necesario ingresar el nombre del Tutor\n"; }
            if (obj.Tutor == "") { Mensaje += "Es necesario ingresar el parentesco del tutor\n"; }
            if (obj.Sexo == "") { Mensaje += "Es necesario ingresar el Sexo del estudiante\n"; }
            if (Mensaje != string.Empty) { return false; }
            else { return odjcd_estudiante.Editar(obj, out Mensaje); }

        }

        public bool Eliminar(Estudiante obj, out string Mensaje)
        {

            return odjcd_estudiante.Eliminar(obj, out Mensaje);
        }

    }
}
