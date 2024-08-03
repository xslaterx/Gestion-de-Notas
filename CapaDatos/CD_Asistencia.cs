using System.Data;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;

namespace CapaDatos
{
    public class CD_Asistencia
    {
        private readonly IDbConnection _db;

        public CD_Asistencia()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Asistencia> Listar()
        {
            string query =
                "SELECT * FROM Asistencias";
            var asistencias = _db.Query<Asistencia>(query);
            _db.Close();
            return asistencias.ToList();
        }

        public int Registrar(Asistencia obj, out string mensaje)
        {
            int idAsistenciaGenerado = 0;
            mensaje = string.Empty;
            try
            {
                string query =
                    "INSERT INTO Asistencias (Estado, CursoId, AsignaturaId, EstudianteId, date) VALUES (@Estado, @CursoId, @AsignaturaId, @EstudianteId, @date); SELECT last_insert_rowid();";
                idAsistenciaGenerado = _db.ExecuteScalar<int>(query, obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                mensaje = e.ToString();
            }

            _db.Close();
            return idAsistenciaGenerado;
        }
    }
}