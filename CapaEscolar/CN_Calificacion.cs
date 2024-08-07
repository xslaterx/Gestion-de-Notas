using BDGestion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEscolar
{
    public class CN_Calificacion
    {
        public class CD_Calificacion
        {
            private CD_Calificacion odjcd_calificacion = new CD_Calificacion();


            public List<Calificacion> Listar()
            {
                return odjcd_calificacion.Listar();
            }

            public int Registrar(Calificacion obj, out string Mensaje)
            {
                Mensaje = string.Empty;
                if (obj.PrimerP <= 0) { Mensaje += "Es necesario ingresar la nota del primer periodo\n"; }
                if (obj.SegundoP <= 0) { Mensaje += "Es necesario ingresar la nota del segundo periodo\n"; }
                if (obj.TercerP <= 0) { Mensaje += "Es necesario ingresar la nota del tercer periodo\n"; }
                if (obj.CuartoP <= 0) { Mensaje += "Es necesario ingresar la nota del cuarto periodo\n"; }
                if (obj.ExamenF <= 0) { Mensaje += "Es necesario ingresar la nota del examen final\n"; }

                if (Mensaje != string.Empty) { return 0; }
                else { return odjcd_calificacion.Registrar(obj, out Mensaje); }


            }

            public bool Editar(Calificacion obj, out string Mensaje)
            {
                Mensaje = string.Empty;
                if (obj.PrimerP <= 0) { Mensaje += "Es necesario ingresar la nota del primer periodo\n"; }
                if (obj.SegundoP <= 0) { Mensaje += "Es necesario ingresar la nota del segundo periodo\n"; }
                if (obj.TercerP <= 0) { Mensaje += "Es necesario ingresar la nota del tercer periodo\n"; }
                if (obj.CuartoP <= 0) { Mensaje += "Es necesario ingresar la nota del cuarto periodo\n"; }
                if (obj.ExamenF <= 0) { Mensaje += "Es necesario ingresar la nota del examen final\n"; }

                if (Mensaje != string.Empty) { return false; }
                else { return odjcd_calificacion.Editar(obj, out Mensaje); }

            }

            public bool Eliminar(Calificacion obj, out string Mensaje)
            {

                return odjcd_calificacion.Eliminar(obj, out Mensaje);
            }

        }
    }
}
