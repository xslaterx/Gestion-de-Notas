using System.Data;
using BDGestion;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private readonly IDbConnection _db;

        public CD_Usuario()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Usuario> Listar()
        {
            string query =
                "SELECT * FROM Usuarios";
            var usuarios = _db.Query<Usuario>(query);
            _db.Close();
            return usuarios.ToList();
        }

        //DECLARACION DE LOS PARAMETROS DE ENTRADA
        public int Registrar(Usuario obj, out string mensaje)
        {
            int usuariosGenerados = 0;
            mensaje = string.Empty;
            try
            {
                string query =
                    "INSERT INTO Usuarios (UsuarioId,Codigo,Username,Password,Descripcion,Estado,RolId) VALUES (@UsuarioId,@Codigo,@Username,@Password,@Descripcion,@Estado,@RolId)";
                _db.Execute(query, obj);
            }
            catch (Exception e)
            {
                mensaje = e.ToString();
            }


            _db.Close();
            return usuariosGenerados;
        }


        public bool Editar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query =
                    "UPDATE Usuarios SET Codigo = @Codigo, Username = @Username, Password = @Password, Descripcion = @Descripcion, Estado = @Estado, RolId = @RolId WHERE UsuarioId = @UsuarioId";
                _db.Execute(query, obj);
                respuesta = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }


            _db.Close();
            return respuesta;
        }


        public bool Eliminar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query = "DELETE FROM Usuarios WHERE UsuarioId = @UsuarioId";
                _db.Execute(query, obj);
                respuesta = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }


            _db.Close();
            return respuesta;
        }
    }
}