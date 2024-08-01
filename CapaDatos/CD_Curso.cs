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
            List<Curso> lista = new List<Curso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.CursoId,c.Nombre,  m.MaestroId from Cursoes c");
                    query.AppendLine("inner join Maestroes m on m.MaestroId = c.Maestro_MaestroId");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Curso()
                            {
                                CursoId = Convert.ToInt32(dr["CursoId"]),
                                Nombre = dr["Nombre"].ToString(),
                                Calificaciones = new List<Calificacion>{new Calificacion{ } }

                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Curso>();

                }

            }
            return lista;


        }
        //DECLARACION DE LOS PARAMETROS DE ENTRADA
        public int Registrar(Curso obj, out string Mensaje)
        {
            int idcursogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_REGISTRARCURSO", oconexion);
                    
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre); 
                    cmd.Parameters.Add("CursoIdResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idcursogenerado = Convert.ToInt32(cmd.Parameters["CursoIdResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) { idcursogenerado = 0; Mensaje = ex.Message; }



            return idcursogenerado;
        }




        public bool Editar(Curso obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_EDITARCURSO", oconexion);
                    cmd.Parameters.AddWithValue("CursoId", obj.CursoId);                 
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) { Respuesta = false; Mensaje = ex.Message; }



            return Respuesta;
        }


        public bool Eliminar(Curso obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_ELIMINARCURSO", oconexion);

                    cmd.Parameters.AddWithValue("CursoId", obj.CursoId);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) { Respuesta = false; Mensaje = ex.Message; }



            return Respuesta;
        }
    }
}
