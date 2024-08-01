using BDGestion;
using DBGestion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Asignatura
    {
        public List<Asignatura> Listar()
        {
            List<Asignatura> lista = new List<Asignatura>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select AsignaturaId,Nombre_asignatura, Descripcion,Departamento from Asignaturas ");
                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Asignatura()
                            {
                                AsignaturaId = Convert.ToInt32(dr["AsignaturaId"]),
                                Nombre_asignatura = dr["Nombre_asignatura"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Departamento = dr["Departamento"].ToString(),
                               

                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Asignatura>();

                }

            }
            return lista;


        }

       
    }
}
