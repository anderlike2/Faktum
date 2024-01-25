using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ModeloConsultaRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsultaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoRiId = table.Column<int>(type: "int", nullable: true),
                    CoRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiUsuarioRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiFechaCons = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoRiNumAutoriza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiDetaBorrador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodCups = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiModGrSerAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiGrupoServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodigoServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiFinalidadConsulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCausaMotivoAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodigoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodigoDiagRel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodigoDiagRel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiCodigoDiagRel3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiTipoDiagPrincipal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    CoRiNummDocMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiValorConsulta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiTipoPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoRiValorPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoriNumFactPagoMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultaRips");
        }
    }
}
