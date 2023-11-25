using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaseFactura",
                columns: table => new
                {
                    ClfaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClfaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClfaEstado = table.Column<bool>(type: "bit", nullable: false),
                    ClfaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClfaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaseFactura", x => x.ClfaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "ClasJuridica",
                columns: table => new
                {
                    JuriCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuriNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuriEstadoOperacion = table.Column<bool>(type: "bit", nullable: false),
                    JuriEstado = table.Column<bool>(type: "bit", nullable: false),
                    JuriFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JuriFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasJuridica", x => x.JuriCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Cobertura",
                columns: table => new
                {
                    CobeCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CobeNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CobeEstado = table.Column<bool>(type: "bit", nullable: false),
                    CobeFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CobeFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.CobeCodigo);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoNota",
                columns: table => new
                {
                    ConoCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConoEstado = table.Column<bool>(type: "bit", nullable: false),
                    ConoFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConoFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoNota", x => x.ConoCodigo);
                });

            migrationBuilder.CreateTable(
                name: "CondicionVenta",
                columns: table => new
                {
                    CoveCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoveNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoveEstado = table.Column<bool>(type: "bit", nullable: false),
                    CoveFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoveFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionVenta", x => x.CoveCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Cum",
                columns: table => new
                {
                    CumsCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CumsNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CumsConsecutivo = table.Column<int>(type: "int", nullable: false),
                    CumsExpediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CumsEstado = table.Column<bool>(type: "bit", nullable: false),
                    CumsFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CumsFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cum", x => x.CumsCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Cup",
                columns: table => new
                {
                    CupsCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupsNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CupsEstado = table.Column<bool>(type: "bit", nullable: false),
                    CupsFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CupsFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.CupsCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Depto",
                columns: table => new
                {
                    DeptoCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptoEstado = table.Column<bool>(type: "bit", nullable: false),
                    DeptoFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptoFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depto", x => x.DeptoCodigo);
                });

            migrationBuilder.CreateTable(
                name: "EstadoDianFactura",
                columns: table => new
                {
                    EsfaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsfaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsfaEstado = table.Column<bool>(type: "bit", nullable: false),
                    EsfaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EsfaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDianFactura", x => x.EsfaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "FactSaludTipo",
                columns: table => new
                {
                    FasaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FasaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FasaEstado = table.Column<bool>(type: "bit", nullable: false),
                    FasaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FasaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactSaludTipo", x => x.FasaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    FopaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FopaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FopaEstado = table.Column<bool>(type: "bit", nullable: false),
                    FopaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FopaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.FopaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Impuesto",
                columns: table => new
                {
                    ImpuCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpuNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpuEstadoOperacion = table.Column<bool>(type: "bit", nullable: false),
                    ImpuOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpuPorcentaje = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ImpuEstado = table.Column<bool>(type: "bit", nullable: false),
                    ImpuFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImpuFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuesto", x => x.ImpuCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Ium",
                columns: table => new
                {
                    IumCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IumNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IumUnidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IumEstado = table.Column<bool>(type: "bit", nullable: false),
                    IumFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IumFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ium", x => x.IumCodigo);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadPago",
                columns: table => new
                {
                    MopaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MopaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MopaEstado = table.Column<bool>(type: "bit", nullable: false),
                    MopaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MopaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadPago", x => x.MopaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    MoneCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoneNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneEstado = table.Column<bool>(type: "bit", nullable: false),
                    MoneFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoneFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.MoneCodigo);
                });

            migrationBuilder.CreateTable(
                name: "numeracionResolucion",
                columns: table => new
                {
                    NureCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NureNumeracionActual = table.Column<int>(type: "int", nullable: false),
                    NureEstado = table.Column<bool>(type: "bit", nullable: false),
                    NureFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NureFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_numeracionResolucion", x => x.NureCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    PaisCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisEstado = table.Column<bool>(type: "bit", nullable: false),
                    PaisFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaisFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.PaisCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Regimen",
                columns: table => new
                {
                    RegiCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegiNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegiEstadoOperacion = table.Column<bool>(type: "bit", nullable: false),
                    RegiEstado = table.Column<bool>(type: "bit", nullable: false),
                    RegiFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegiFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regimen", x => x.RegiCodigo);
                });

            migrationBuilder.CreateTable(
                name: "RespFiscal",
                columns: table => new
                {
                    RefiCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefiNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefiEstado = table.Column<bool>(type: "bit", nullable: false),
                    RefiFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefiFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespFiscal", x => x.RefiCodigo);
                });

            migrationBuilder.CreateTable(
                name: "RespTributaria",
                columns: table => new
                {
                    RetrCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetrNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetrEstado = table.Column<bool>(type: "bit", nullable: false),
                    RetrFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RetrFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespTributaria", x => x.RetrCodigo);
                });

            migrationBuilder.CreateTable(
                name: "ReteFuente",
                columns: table => new
                {
                    ReteCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReteNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetePorcentaje = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ReteEstado = table.Column<bool>(type: "bit", nullable: false),
                    ReteFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReteFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReteFuente", x => x.ReteCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolEstado = table.Column<bool>(type: "bit", nullable: false),
                    RolFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RolFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoArchivoRips",
                columns: table => new
                {
                    ArriCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArriNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArriEstado = table.Column<bool>(type: "bit", nullable: false),
                    ArriFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArriFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArchivoRips", x => x.ArriCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    TiclCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiclNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiclEstado = table.Column<bool>(type: "bit", nullable: false),
                    TiclFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TiclFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.TiclCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoCup",
                columns: table => new
                {
                    TicuCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicuNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicuEstado = table.Column<bool>(type: "bit", nullable: false),
                    TicuFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicuFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCup", x => x.TicuCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoDescuento",
                columns: table => new
                {
                    TideCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TideNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TideEstado = table.Column<bool>(type: "bit", nullable: false),
                    TideFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TideFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDescuento", x => x.TideCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocElectr",
                columns: table => new
                {
                    TidoCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TidoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TidoEstado = table.Column<bool>(type: "bit", nullable: false),
                    TidoFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TidoFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocElectr", x => x.TidoCodigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoId",
                columns: table => new
                {
                    TiidCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiidNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiidEstado = table.Column<bool>(type: "bit", nullable: false),
                    TiidFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TiidFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoId", x => x.TiidCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuaPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuaIntentos = table.Column<int>(type: "int", nullable: false),
                    UsuaEstado = table.Column<bool>(type: "bit", nullable: false),
                    UsuaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuaCodigo);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    CiudCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudDeptoDeptoCodigo = table.Column<int>(type: "int", nullable: false),
                    CiudEstado = table.Column<bool>(type: "bit", nullable: false),
                    CiudFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CiudFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.CiudCodigo);
                    table.ForeignKey(
                        name: "FK_Ciudad_Depto_CiudDeptoDeptoCodigo",
                        column: x => x.CiudDeptoDeptoCodigo,
                        principalTable: "Depto",
                        principalColumn: "DeptoCodigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolUsuario",
                columns: table => new
                {
                    RousCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RousUsuarioUsuaCodigo = table.Column<int>(type: "int", nullable: false),
                    RousRolRolCodigo = table.Column<int>(type: "int", nullable: false),
                    RousEstado = table.Column<bool>(type: "bit", nullable: false),
                    RousFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RousFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuario", x => x.RousCodigo);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Rol_RousRolRolCodigo",
                        column: x => x.RousRolRolCodigo,
                        principalTable: "Rol",
                        principalColumn: "RolCodigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Usuario_RousUsuarioUsuaCodigo",
                        column: x => x.RousUsuarioUsuaCodigo,
                        principalTable: "Usuario",
                        principalColumn: "UsuaCodigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    LocaCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocaDeptoDeptoCodigo = table.Column<int>(type: "int", nullable: false),
                    LocaCiudadCiudCodigo = table.Column<int>(type: "int", nullable: false),
                    LocaEstado = table.Column<bool>(type: "bit", nullable: false),
                    LocaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.LocaCodigo);
                    table.ForeignKey(
                        name: "FK_Localidad_Ciudad_LocaCiudadCiudCodigo",
                        column: x => x.LocaCiudadCiudCodigo,
                        principalTable: "Ciudad",
                        principalColumn: "CiudCodigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Localidad_Depto_LocaDeptoDeptoCodigo",
                        column: x => x.LocaDeptoDeptoCodigo,
                        principalTable: "Depto",
                        principalColumn: "DeptoCodigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_CiudDeptoDeptoCodigo",
                table: "Ciudad",
                column: "CiudDeptoDeptoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_LocaCiudadCiudCodigo",
                table: "Localidad",
                column: "LocaCiudadCiudCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_LocaDeptoDeptoCodigo",
                table: "Localidad",
                column: "LocaDeptoDeptoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_RousRolRolCodigo",
                table: "RolUsuario",
                column: "RousRolRolCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_RousUsuarioUsuaCodigo",
                table: "RolUsuario",
                column: "RousUsuarioUsuaCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClaseFactura");

            migrationBuilder.DropTable(
                name: "ClasJuridica");

            migrationBuilder.DropTable(
                name: "Cobertura");

            migrationBuilder.DropTable(
                name: "ConceptoNota");

            migrationBuilder.DropTable(
                name: "CondicionVenta");

            migrationBuilder.DropTable(
                name: "Cum");

            migrationBuilder.DropTable(
                name: "Cup");

            migrationBuilder.DropTable(
                name: "EstadoDianFactura");

            migrationBuilder.DropTable(
                name: "FactSaludTipo");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Impuesto");

            migrationBuilder.DropTable(
                name: "Ium");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "ModalidadPago");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "numeracionResolucion");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Regimen");

            migrationBuilder.DropTable(
                name: "RespFiscal");

            migrationBuilder.DropTable(
                name: "RespTributaria");

            migrationBuilder.DropTable(
                name: "ReteFuente");

            migrationBuilder.DropTable(
                name: "RolUsuario");

            migrationBuilder.DropTable(
                name: "TipoArchivoRips");

            migrationBuilder.DropTable(
                name: "TipoCliente");

            migrationBuilder.DropTable(
                name: "TipoCup");

            migrationBuilder.DropTable(
                name: "TipoDescuento");

            migrationBuilder.DropTable(
                name: "TipoDocElectr");

            migrationBuilder.DropTable(
                name: "TipoId");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Depto");
        }
    }
}
