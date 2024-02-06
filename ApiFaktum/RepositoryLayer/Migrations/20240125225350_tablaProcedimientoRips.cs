using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaProcedimientoRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcedimientoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrRiId = table.Column<int>(type: "int", nullable: true),
                    PrRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriUsuarioRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiFechaCons = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrRiIdMPres = table.Column<int>(type: "int", nullable: true),
                    PrRiNUmAutoriza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiDetaBorrador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiViaIngresoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiCodCups = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiModGrServAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiGrupoServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiCodigoServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiFinalidadConsulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    PrRiNumDocMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiCodigoDiagRel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiComplicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiValorProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiTipoPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiValorPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrRiNumFactPagoMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimientoRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimientoRips");
        }
    }
}
