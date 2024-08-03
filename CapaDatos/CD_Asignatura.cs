using System.Data;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;


namespace CapaDatos
{
    public class CD_Asignatura
    {
        private readonly IDbConnection _db;

        public CD_Asignatura()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Asignatura> Listar()
        {
            string query =
                "SELECT * FROM Asignaturas";
            var asignaturas = _db.Query<Asignatura>(query);

            return asignaturas.ToList();
        }
    }
}