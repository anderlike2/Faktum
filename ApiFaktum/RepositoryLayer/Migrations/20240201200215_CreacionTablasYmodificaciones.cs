using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreacionTablasYmodificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsUaEmpresa",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaTipoDocRips",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaTipoUsuario",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UrRiId",
                table: "UrgenciaRips");

            migrationBuilder.DropColumn(
                name: "RnRiId",
                table: "RecienNacidoRips");

            migrationBuilder.DropColumn(
                name: "PrRiId",
                table: "ProcedimientoRips");

            migrationBuilder.DropColumn(
                name: "OtRiId",
                table: "OtroServicioRips");

            migrationBuilder.DropColumn(
                name: "MeRiId",
                table: "MedicamentosRips");

            migrationBuilder.DropColumn(
                name: "HoRiId",
                table: "HospitalizacionRips");

            migrationBuilder.DropColumn(
                name: "CoRiId",
                table: "ConsultaRips");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoDocRipsId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoUsuariosRipsId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsUaEmpresaId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsUaTipoDocRipsId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsUaTipoUsuarioRips",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsRiNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncapacidadRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InRiCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InRiNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncapacidadRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadAtencionRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoAtCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoAtNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadAtencionRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrigenRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrRiNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrigenRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeRiCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeRiNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiDrCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiDrNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoNotaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiNrCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiNrNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotaRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOtroServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiOtCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiOtNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOtroServicioRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuariosRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiRiCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiRiNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuariosRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsRiObjetoRaiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsRiUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjetoRaiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObRaBorrador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaNumBorrador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaNumNc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaNumNd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaJsOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaTerminado = table.Column<bool>(type: "bit", nullable: false),
                    ObRaGenerado = table.Column<bool>(type: "bit", nullable: false),
                    ObRaOperador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObRaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ObRaFacturaId = table.Column<int>(type: "int", nullable: false),
                    ObRaTipoNotaRipsId = table.Column<int>(type: "int", nullable: false),
                    ObRaOrigenRipsId = table.Column<int>(type: "int", nullable: false),
                    ObRaEstadoRipsId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false),
                    TipoNotaRipsId = table.Column<int>(type: "int", nullable: false),
                    OrigenRipsId = table.Column<int>(type: "int", nullable: false),
                    EstadoRipsId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetoRaiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_EstadoRips_EstadoRipsId",
                        column: x => x.EstadoRipsId,
                        principalTable: "EstadoRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_OrigenRips_OrigenRipsId",
                        column: x => x.OrigenRipsId,
                        principalTable: "OrigenRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_TipoNotaRips_TipoNotaRipsId",
                        column: x => x.TipoNotaRipsId,
                        principalTable: "TipoNotaRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_EmpresaId",
                table: "UsuarioSaludRips",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_TipoDocRipsId",
                table: "UsuarioSaludRips",
                column: "TipoDocRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_TipoUsuariosRipsId",
                table: "UsuarioSaludRips",
                column: "TipoUsuariosRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_EmpresaId",
                table: "ObjetoRaiz",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_EstadoRipsId",
                table: "ObjetoRaiz",
                column: "EstadoRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_FacturaId",
                table: "ObjetoRaiz",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_OrigenRipsId",
                table: "ObjetoRaiz",
                column: "OrigenRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_TipoNotaRipsId",
                table: "ObjetoRaiz",
                column: "TipoNotaRipsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSaludRips_Empresa_EmpresaId",
                table: "UsuarioSaludRips",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSaludRips_TipoDocRips_TipoDocRipsId",
                table: "UsuarioSaludRips",
                column: "TipoDocRipsId",
                principalTable: "TipoDocRips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSaludRips_TipoUsuariosRips_TipoUsuariosRipsId",
                table: "UsuarioSaludRips",
                column: "TipoUsuariosRipsId",
                principalTable: "TipoUsuariosRips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSaludRips_Empresa_EmpresaId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSaludRips_TipoDocRips_TipoDocRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSaludRips_TipoUsuariosRips_TipoUsuariosRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropTable(
                name: "IncapacidadRips");

            migrationBuilder.DropTable(
                name: "ModalidadAtencionRips");

            migrationBuilder.DropTable(
                name: "ObjetoRaiz");

            migrationBuilder.DropTable(
                name: "ServicioRips");

            migrationBuilder.DropTable(
                name: "TipoDocRips");

            migrationBuilder.DropTable(
                name: "TipoOtroServicioRips");

            migrationBuilder.DropTable(
                name: "TipoUsuariosRips");

            migrationBuilder.DropTable(
                name: "UsuarioRips");

            migrationBuilder.DropTable(
                name: "EstadoRips");

            migrationBuilder.DropTable(
                name: "OrigenRips");

            migrationBuilder.DropTable(
                name: "TipoNotaRips");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioSaludRips_EmpresaId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioSaludRips_TipoDocRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioSaludRips_TipoUsuariosRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "TipoDocRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "TipoUsuariosRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaEmpresaId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaTipoDocRipsId",
                table: "UsuarioSaludRips");

            migrationBuilder.DropColumn(
                name: "UsUaTipoUsuarioRips",
                table: "UsuarioSaludRips");

            migrationBuilder.AddColumn<string>(
                name: "UsUaEmpresa",
                table: "UsuarioSaludRips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsUaId",
                table: "UsuarioSaludRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsUaTipoDocRips",
                table: "UsuarioSaludRips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsUaTipoUsuario",
                table: "UsuarioSaludRips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrRiId",
                table: "UrgenciaRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RnRiId",
                table: "RecienNacidoRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrRiId",
                table: "ProcedimientoRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OtRiId",
                table: "OtroServicioRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeRiId",
                table: "MedicamentosRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HoRiId",
                table: "HospitalizacionRips",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoRiId",
                table: "ConsultaRips",
                type: "int",
                nullable: true);
        }
    }
}
