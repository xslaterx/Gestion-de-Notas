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

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("EstudianteId, Codigo,Nombre, Apellido, Telefono,FechaRegistro,Enfermedad, Medicamento,TutorNombre,Tutor,NumeroEmergencia, Estado,Sexo from Estudiantes");               
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Estudiante()
                            {
                                EstudianteId = Convert.ToInt32(dr["EstudianteId"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                Enfermedad = dr["Enfermedad"].ToString(),
                                Medicamento = dr["Medicamento"].ToString(),
                                TutorNombre = dr["TutorNombre"].ToString(),
                                Tutor = dr["Tutor"].ToString(),
                                NumeroEmergencia = dr["NumeroEmergencia"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                Sexo = dr["Sexo"].ToString(),
                                Calificaciones = new List<Calificacion> { new Calificacion { } }

                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Estudiante>();

                }

            }
            return lista;


        }

        public int Registrar(Estudiante obj, out string Mensaje)
        {
            int idestudiantegenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_REGISTRARESTUDIANTE", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
                    cmd.Parameters.AddWithValue("Enfermedad", obj.Enfermedad);
                    cmd.Parameters.AddWithValue("Medicamento", obj.Medicamento);
                    cmd.Parameters.AddWithValue("TutorNombre", obj.TutorNombre);
                    cmd.Parameters.AddWithValue("Tutor", obj.Tutor);
                    cmd.Parameters.AddWithValue("NumeroEmergencia", obj.NumeroEmergencia);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("Sexo", obj.Sexo);
                    cmd.Parameters.Add("@EstudianteIdResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idestudiantegenerado = Convert.ToInt32(cmd.Parameters["@EstudianteIdResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) { idestudiantegenerado = 0; Mensaje = ex.Message; }



            return idestudiantegenerado;
        }


        public bool Editar(Estudiante obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_EDITARESTUDIANTE", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
                    cmd.Parameters.AddWithValue("Enfermedad", obj.Enfermedad);
                    cmd.Parameters.AddWithValue("Medicamento", obj.Medicamento);
                    cmd.Parameters.AddWithValue("TutorNombre", obj.TutorNombre);
                    cmd.Parameters.AddWithValue("Tutor", obj.Tutor);
                    cmd.Parameters.AddWithValue("NumeroEmergencia", obj.NumeroEmergencia);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("Sexo", obj.Sexo);
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


        public bool Eliminar(Estudiante obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_ELIMINARESTUDIANTE", oconexion);

                    cmd.Parameters.AddWithValue("EstudianteId", obj.EstudianteId);
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
