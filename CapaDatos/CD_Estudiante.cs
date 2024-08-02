using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BDGestion;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaDatos
{
    public class CD_Estudiante
    {
        public List<Estudiante> Listar()
        {
            List<Estudiante> lista = new List<Estudiante>();
            return lista;


        }

        public int Registrar(Estudiante obj, out string Mensaje)
        {
            int idestudiantegenerado = 0;
            Mensaje = string.Empty;




            return idestudiantegenerado;
        }


        public bool Editar(Estudiante obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;



            return Respuesta;
        }


        public bool Eliminar(Estudiante obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;



            return Respuesta;
        }

    }
}
