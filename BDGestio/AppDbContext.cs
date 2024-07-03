using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;

namespace BDGestion
{ 

        public class AppDbContext : DbContext
        {
            public AppDbContext() : base("name=AppDbContext")
            {
            }

            public DbSet<Estudiante> Estudiantes { get; set; }
            public DbSet<Curso> Cursos { get; set; }
            public DbSet<Calificacion> Calificaciones { get; set; }
            public DbSet<Maestro> Maestros { get; set; }
            public DbSet<Administrador> Administradores { get; set; }
            public DbSet<Administrativo> Administrativos { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Rol> Roles { get; set; }



        
        }
    }

    

