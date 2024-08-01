namespace BDGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradores",
                c => new
                    {
                        AdministradorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Departamento = c.String(),
                    })
                .PrimaryKey(t => t.AdministradorId);
            
            CreateTable(
                "dbo.Administrativos",
                c => new
                    {
                        AdministrativoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Departamento = c.String(),
                    })
                .PrimaryKey(t => t.AdministrativoId);
            
            CreateTable(
                "dbo.Calificaciones",
                c => new
                    {
                        CalificacionId = c.Int(nullable: false, identity: true),
                        EstudianteId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Nota = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CalificacionId)
                .ForeignKey("dbo.Cursoes", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.EstudianteId, cascadeDelete: true)
                .Index(t => t.EstudianteId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Maestro_MaestroId = c.Int(),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Maestroes", t => t.Maestro_MaestroId)
                .Index(t => t.Maestro_MaestroId);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.EstudianteId);
            
            CreateTable(
                "dbo.Maestros",
                c => new
                    {
                        MaestroId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.MaestroId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Rols", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "RolId", "dbo.Rols");
            DropForeignKey("dbo.Cursoes", "Maestro_MaestroId", "dbo.Maestroes");
            DropForeignKey("dbo.Calificacions", "EstudianteId", "dbo.Estudiantes");
            DropForeignKey("dbo.Calificacions", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Usuarios", new[] { "RolId" });
            DropIndex("dbo.Cursoes", new[] { "Maestro_MaestroId" });
            DropIndex("dbo.Calificacions", new[] { "CursoId" });
            DropIndex("dbo.Calificacions", new[] { "EstudianteId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Rols");
            DropTable("dbo.Maestroes");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Calificacions");
            DropTable("dbo.Administrativoes");
            DropTable("dbo.Administradors");
        }
    }
}
