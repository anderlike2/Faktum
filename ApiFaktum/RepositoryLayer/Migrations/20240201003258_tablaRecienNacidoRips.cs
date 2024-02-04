using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaRecienNacidoRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecienNacidoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RnRiId = table.Column<int>(type: "int", nullable: true),
                    RnRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnUsuarioRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiTipoRNid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiFechaNac = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RnRiEdadGestacional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiRoConsPreNatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiSexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiPeso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiConDestUsuarioE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiCodDiagMuerte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RnRiFechaEgreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecienNacidoRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecienNacidoRips");
        }
    }
}
