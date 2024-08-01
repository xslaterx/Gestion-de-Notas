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
                    query.AppendLine("select u.UsuarioId,u.Codigo, u.Username, u.Password,u.Estado,u.RolId,  r.Descripcion from Usuarios u");
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
                                Codigo = dr["Codigo"].ToString(),
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

        //DECLARACION DE LOS PARAMETROS DE ENTRADA
        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;

            try 
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);  
                    cmd.Parameters.AddWithValue("Nombre",obj.Username);
                    cmd.Parameters.AddWithValue("Contrasena", obj.Password);
                    cmd.Parameters.AddWithValue("RolId", obj.Rol.RolId);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("UsuarioIdResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32( cmd.Parameters["UsuarioIdResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch(Exception ex) { idusuariogenerado = 0; Mensaje = ex.Message; }



            return idusuariogenerado; 
        }




        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("UsuarioId", obj.UsuarioId);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Username);
                    cmd.Parameters.AddWithValue("Contrasena", obj.Password);
                    cmd.Parameters.AddWithValue("RolId", obj.Rol.RolId);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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


        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("ST_ELIMINARUSUARIO", oconexion);

                    cmd.Parameters.AddWithValue("UsuarioId", obj.UsuarioId);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
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

