using BDGestion;
using CapaDatos;
using DBGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEscolar
{
    public class CN_Asistencia
    {
        private CD_Asistencia odjcd_asistencia = new CD_Asistencia();


        public List<Asistencia> Listar()
        {
            return odjcd_asistencia.Listar();
        }
        public int Registrar(Asistencia obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Estudiante.Codigo == "") { Mensaje += "Es necesario ingresar el Codigo del Estudiante\n"; }
            if (obj.Estudiante.Nombre == "") { Mensaje += "Es necesario ingresar el Nombre del Estudiante\n"; }

            if (Mensaje != string.Empty) { return 0; }
            else { return odjcd_asistencia.Registrar(obj, out Mensaje); }


        }
    }
}
