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
    public class CD_Curso
    {
        public List<Curso> Listar()
        {

            return null;


        }
        //DECLARACION DE LOS PARAMETROS DE ENTRADA
        public int Registrar(Curso obj, out string Mensaje)
        {
            int idcursogenerado = 0;
            Mensaje = string.Empty;

            return idcursogenerado;
        }




        public bool Editar(Curso obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;



            return Respuesta;
        }


        public bool Eliminar(Curso obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            return Respuesta;
        }
    }
}
