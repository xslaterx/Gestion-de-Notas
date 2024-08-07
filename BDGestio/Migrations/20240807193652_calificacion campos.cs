using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBGestion.Migrations
{
    /// <inheritdoc />
    public partial class calificacioncampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<double>(
                name: "PuntuacionF",
                table: "Calificaciones",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "CompletivoF",
                table: "Calificaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FinalEx",
                table: "Calificaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Promedio",
                table: "Calificaciones",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletivoF",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "FinalEx",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "Promedio",
                table: "Calificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "PuntuacionF",
                table: "Calificaciones",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<decimal>(
                name: "Nota",
                table: "Calificaciones",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
