using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBGestion;
using BDGestion;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.UsuarioId,u.Username, u.Password,u.Estado,u.RolId,  r.Descripcion from Usuarios u");
                    query.AppendLine("inner join Rols r on r.RolId = u.RolId");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) 
                        {

                            lista.Add(new Usuario()
                            {
                                UsuarioId = Convert.ToInt32(dr["UsuarioId"]),
                                Username = dr["Username"].ToString(),                      
                                Password = dr["Password"].ToString(),                            
                                RolId = (int)Convert.ToUInt32(dr["RolId"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),                               
                                Descripcion = dr["Descripcion"].ToString(),
                                Rol = new Rol() { RolId = Convert.ToInt32(dr["RolId"]) }

                            });
           
                        }
                    }

                }
                catch (Exception ex) 
                { 
                    lista = new List<Usuario>();
                    
                }
             
            }
            return lista;   
        }
    } 
}

