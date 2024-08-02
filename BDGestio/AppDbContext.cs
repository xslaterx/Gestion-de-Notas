using DBGestion;
using Microsoft.EntityFrameworkCore;

namespace BDGestion
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Conexion.cadena);
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}