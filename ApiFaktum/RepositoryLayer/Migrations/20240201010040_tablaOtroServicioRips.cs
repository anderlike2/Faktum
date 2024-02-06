using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class tablaOtroServicioRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OtroServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtRiId = table.Column<int>(type: "int", nullable: true),
                    OtRiPrestador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiUsuarioRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiNumAutoriza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiIdMiPres = table.Column<int>(type: "int", nullable: true),
                    OtRiFechaServicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OtRiTipoOtro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiDetaBorrador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    OtRiNumDocMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiCodCups = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiVUnitario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiValorServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiTipoPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiValorPagoModerador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtRiNumFactPagoMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtroServicioRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtroServicioRips");
        }
    }
}
