using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BDGestion;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DBGestion;
using System.Data.Entity;
namespace CapaDatos
{
    public class CD_Asistencia
    {
        public List<Asistencia> Listar()
         {
            List<Asistencia> lista = new List<Asistencia>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select a.AsistenciaId,a.date, a.Estudiante_EstudianteId, a.Estado, e.Codigo, e.Nombre, a.Curso ,a.Asignatura  from Asistencias a");
                    query.AppendLine("inner join Estudiantes e on e.EstudianteId = a.Estudiante_EstudianteId");
                    query.AppendLine("inner join Cursoes c on c.Nombre = a.Curso");
                    query.AppendLine("inner join Asignaturas m on m.Nombre_asignatura = a.Asignatura");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
 
                        while (dr.Read()) 
                        {

                                 lista.Add(new Asistencia()
                                 {
                                  AsistenciaId = Convert.ToInt32(dr["AsistenciaId"]),
                                  date = Convert.ToDateTime(dr["date"]),
                                  Estado = Convert.ToBoolean(dr["Estado"]), 
                                  Codigo = dr["Codigo"].ToString(),
                                  Nombre = dr["Nombre"].ToString(),   
                                  CursoId = (int)Convert.ToUInt32(dr["CursoId"]),
                                  AsignaturaId = (int)Convert.ToUInt32(dr["AsignaturaId"]),
                                  Curso = new Curso() { CursoId = Convert.ToInt32(dr["CursoId"]) },
                                  Asignatura = new Asignatura() { AsignaturaId = Convert.ToInt32(dr["AsignaturaId"]) }


                                 });
                        }
                    }

                }

                catch (Exception ex)
                {
                    lista = new List<Asistencia>();
                }

            }
            return lista;


        }
        public int Registrar(Asistencia obj, out string Mensaje)
        {
            int idasistenciagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Username);
                    cmd.Parameters.AddWithValue("Contrasena", obj.Password);
                    cmd.Parameters.AddWithValue("RolId", obj.Rol.RolId);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("UsuarioIdResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["UsuarioIdResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex) { idusuariogenerado = 0; Mensaje = ex.Message; }



            return idusuariogenerado;
        }

    }
}
