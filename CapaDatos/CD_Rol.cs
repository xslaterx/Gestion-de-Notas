using BDGestion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using(SqlConnection oconexio = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select RolId,Nombre,Descripcion from Rols");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexio);
                    cmd.CommandType = CommandType.Text;

                    oconexio.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) 
                        {
                            lista.Add(new Rol()
                            {
                                RolId = Convert.ToInt32(dr["RolId"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    } 
                
                }
                catch (Exception ex) { lista = new List<Rol>(); }
            }
            return lista;
        }


    }
}
