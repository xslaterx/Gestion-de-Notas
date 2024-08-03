using System.Data;
using BDGestion;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;

namespace CapaDatos
{
    public class CD_Curso
    {
        private readonly IDbConnection _db;

        public CD_Curso()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Curso> Listar()
        {
            string query =
                "SELECT * FROM Cursos";
            var cursos = _db.Query<Curso>(query);
            _db.Close();
            return cursos.ToList();
        }

        //DECLARACION DE LOS PARAMETROS DE ENTRADA
        public int Registrar(Curso obj, out string mensaje)
        {
            int idCursoGenerado = 0;
            mensaje = string.Empty;
            try
            {
                idCursoGenerado = _db.ExecuteScalar<int>("INSERT INTO Cursos (Nombre) VALUES (@Nombre)", obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }

            _db.Close();
            return idCursoGenerado;
        }


        public bool Editar(Curso obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query = "UPDATE Cursos SET Nombre = @Nombre WHERE CursoId = @CursoId";
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


        public bool Eliminar(Curso obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query = "DELETE FROM Cursos WHERE CursoId = @CursoId";
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