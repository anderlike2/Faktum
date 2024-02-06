using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaMedicamentosRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicamentosRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeRiId = table.Column<int>(type: "int", nullable: true),
                    MeRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiUsuariosRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiNumAutoriza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiMiPresid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiDisp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MeRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiCodigoDiagRel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiTipoMed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiDetaBorrador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiNombreMedicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiConcentracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiUnidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiFormaFarmaceutica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiUnidadMinimaDisp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiCantidadDisp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiNumDias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    MeRiNumDocMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiValUnitario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiValorServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiTipoPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiValorPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeRiNumFactPagoMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentosRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentosRips");
        }
    }
}
