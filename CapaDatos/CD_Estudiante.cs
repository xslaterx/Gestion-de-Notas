using System.Data;
using BDGestion;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;
using Exception = System.Exception;

namespace CapaDatos
{
    public class CD_Estudiante
    {
        private readonly IDbConnection _db;

        public CD_Estudiante()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Estudiante> Listar()
        {
            string query =
                "SELECT * FROM Estudiantes";
            var estudiantes = _db.Query<Estudiante>(query);
            _db.Close();
            return estudiantes.ToList();
        }

        public int Registrar(Estudiante obj, out string mensaje)
        {
            int idEstudianteGenerado = 0;
            mensaje = string.Empty;
            try
            {
                string query =
                    "INSERT INTO Estudiantes (Codigo, Nombre, Apellido, Telefono, Estado, FechaRegistro, Enfermedad, Medicamento, NumeroEmergencia, TutorNombre, Tutor, Sexo) VALUES (@Codigo, @Nombre, @Apellido, @Telefono, @Estado, @FechaRegistro, @Enfermedad, @Medicamento, @NumeroEmergencia, @TutorNombre, @Tutor, @Sexo)";
                idEstudianteGenerado = _db.ExecuteScalar<int>(query, obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }

            _db.Close();
            return idEstudianteGenerado;
        }


        public bool Editar(Estudiante obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query =
                    "UPDATE Estudiantes SET Codigo = @Codigo, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Estado = @Estado, FechaRegistro = @FechaRegistro, Enfermedad = @Enfermedad, Medicamento = @Medicamento, NumeroEmergencia = @NumeroEmergencia, TutorNombre = @TutorNombre, Tutor = @Tutor, Sexo = @Sexo WHERE EstudianteId = @EstudianteId";
                respuesta = _db.Execute(query, obj) > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }


            _db.Close();
            return respuesta;
        }


        public bool Eliminar(Estudiante obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                string query = "DELETE FROM Estudiantes WHERE EstudianteId = @EstudianteId";
                respuesta = _db.Execute(query, obj) > 0;
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