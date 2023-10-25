using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MZ_PROGRESO1.Migrations
{
    public partial class ZUMARRAGA_BD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZUMARRAGA",
                columns: table => new
                {
                    mzCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mzCalificacionFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mzNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mzApellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mzCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mzCodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mzEstudianteNuevo = table.Column<bool>(type: "bit", nullable: false),
                    mzFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mzPromedioConducta = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZUMARRAGA", x => x.mzCodigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZUMARRAGA");
        }
    }
}
