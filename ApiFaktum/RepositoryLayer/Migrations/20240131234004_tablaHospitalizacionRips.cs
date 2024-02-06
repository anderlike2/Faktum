using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaHospitalizacionRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalizacionRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoRiId = table.Column<int>(type: "int", nullable: true),
                    HoRiUsuariosRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiViaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiFechaInicioAtencion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoRiNumAutoriza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCausaMotivoAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCodigoDiagRel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCodigoDiagRel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCodigoDiagRel3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiCodComplicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoRiConDestUsuarioOe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCodDiagMuerte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiFechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalizacionRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalizacionRips");
        }
    }
}
