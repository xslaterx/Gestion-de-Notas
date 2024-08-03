using System.Data;
using BDGestion;
using Dapper;
using DBGestion;
using Microsoft.Data.Sqlite;


namespace CapaDatos
{
    public class CD_Rol
    {
        private readonly IDbConnection _db;

        public CD_Rol()
        {
            _db = new SqliteConnection(Conexion.cadena);
            _db.Open();
        }

        public List<Rol> Listar()
        {
            string query =
                "SELECT * FROM Roles";
            var roles = _db.Query<Rol>(query);
            _db.Close();
            return roles.ToList();
        }
    }
}