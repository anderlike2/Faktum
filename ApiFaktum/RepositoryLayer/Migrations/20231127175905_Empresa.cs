using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class Empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuaCodigo",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "RolCodigo",
                table: "Rol",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmprFactContador = table.Column<int>(type: "int", nullable: false),
                    EmprCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprCiudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprCiuu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmprClasJuridicaId = table.Column<int>(type: "int", nullable: false),
                    EmprContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDepto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDiasPago = table.Column<int>(type: "int", nullable: false),
                    EmprDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprRespFiscalId = table.Column<int>(type: "int", nullable: false),
                    EmprFormatoImpr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprIdRepLegal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprLeyEnFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprLeyEnNotaCredito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprLeyEnNotaDebito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmprMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprRecepcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprNit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprObservaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprPagWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprPorcReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmprRegimenId = table.Column<int>(type: "int", nullable: false),
                    EmprRepLegal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprRespTributId = table.Column<int>(type: "int", nullable: false),
                    EmprTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprTipoClienteId = table.Column<int>(type: "int", nullable: false),
                    EmprTipoIdId = table.Column<int>(type: "int", nullable: false),
                    EmprHabilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_ClasJuridica_EmprClasJuridicaId",
                        column: x => x.EmprClasJuridicaId,
                        principalTable: "ClasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_Regimen_EmprRegimenId",
                        column: x => x.EmprRegimenId,
                        principalTable: "Regimen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_RespFiscal_EmprRespFiscalId",
                        column: x => x.EmprRespFiscalId,
                        principalTable: "RespFiscal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_RespTributaria_EmprRespTributId",
                        column: x => x.EmprRespTributId,
                        principalTable: "RespTributaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_TipoCliente_EmprTipoClienteId",
                        column: x => x.EmprTipoClienteId,
                        principalTable: "TipoCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_TipoId_EmprTipoIdId",
                        column: x => x.EmprTipoIdId,
                        principalTable: "TipoId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprClasJuridicaId",
                table: "Empresa",
                column: "EmprClasJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprRegimenId",
                table: "Empresa",
                column: "EmprRegimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprRespFiscalId",
                table: "Empresa",
                column: "EmprRespFiscalId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprRespTributId",
                table: "Empresa",
                column: "EmprRespTributId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprTipoClienteId",
                table: "Empresa",
                column: "EmprTipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprTipoIdId",
                table: "Empresa",
                column: "EmprTipoIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.AddColumn<int>(
                name: "UsuaCodigo",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RolCodigo",
                table: "Rol",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
