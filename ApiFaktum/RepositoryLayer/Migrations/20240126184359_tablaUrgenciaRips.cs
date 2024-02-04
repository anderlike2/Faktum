using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaUrgenciaRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrgenciaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrRiId = table.Column<int>(type: "int", nullable: true),
                    UrRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiUsuarioRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiFechaCons = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UrRiCausaMotivoAtencio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URiCodigoDiagPrincipalE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCodigoDiagRel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCodigoDiagRel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCodigoDiagRel3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiConDestUsuarioE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiCondDiagMuerte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrRiFechaEgreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgenciaRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrgenciaRips");
        }
    }
}
