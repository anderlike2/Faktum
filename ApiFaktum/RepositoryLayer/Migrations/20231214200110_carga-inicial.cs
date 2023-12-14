using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class cargainicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaseFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClfaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClfaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaseFactura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClasJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuriCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuriNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JuriEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasJuridica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cobertura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CobeCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CobeNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoNota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConoTipoNota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoNota", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicionVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoveCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoveNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionVenta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CumsCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CumsNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CumsConsecutivo = table.Column<int>(type: "int", nullable: false),
                    CumsExpediente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupsCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CupsNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoDianFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsfaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsfaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDianFactura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FactSaludTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FasaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FasaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactSaludTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FopaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FopaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Impuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpuCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpuNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpuEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ImpuOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpuPorcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuesto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IumCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IumNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IumUnidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ium", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MopaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MopaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoneCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumeracionResolucion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NureCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NureNumeracionActual = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumeracionResolucion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regimen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegiCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegiNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegiEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regimen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespFiscal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefiCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefiNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespFiscal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RespTributaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetrCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetrNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespTributaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReteFuente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReteCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReteNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetePorcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReteFuente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoArchivoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArriCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArriNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArchivoRips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiclCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiclNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicuCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicuNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDescuento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TideCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TideNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDescuento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocElectr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TidoCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TidoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocElectr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiidCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiidNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuaPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuaIntentos = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiudCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudDeptoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudad_Depto_CiudDeptoId",
                        column: x => x.CiudDeptoId,
                        principalTable: "Depto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    EmprContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDepto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDiasPago = table.Column<int>(type: "int", nullable: false),
                    EmprDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprDv = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    EmprRepLegal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprHabilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmprTipoClienteId = table.Column<int>(type: "int", nullable: false),
                    EmprTipoIdId = table.Column<int>(type: "int", nullable: false),
                    EmprRespTributId = table.Column<int>(type: "int", nullable: false),
                    EmprRegimenId = table.Column<int>(type: "int", nullable: false),
                    EmprRespFiscalId = table.Column<int>(type: "int", nullable: false),
                    EmprClasJuridicaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "RolUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RousUsuarioId = table.Column<int>(type: "int", nullable: false),
                    RousRolId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Rol_RousRolId",
                        column: x => x.RousRolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolUsuario_Usuario_RousUsuarioId",
                        column: x => x.RousUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocaCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocaDeptoId = table.Column<int>(type: "int", nullable: false),
                    LocaCiudadId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidad_Ciudad_LocaCiudadId",
                        column: x => x.LocaCiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Localidad_Depto_LocaDeptoId",
                        column: x => x.LocaDeptoId,
                        principalTable: "Depto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CentroCosto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CcosCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CcosNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CcosEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroCosto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CentroCosto_Empresa_CcosEmpresaId",
                        column: x => x.CcosEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClieApellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieCiuu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieCobertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieCorreoFact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieDescGlobal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClieDiasPago = table.Column<int>(type: "int", nullable: false),
                    ClieDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieDv = table.Column<long>(type: "bigint", nullable: false),
                    ClieEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ClieIdReprLegal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieJuridica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieNit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CliePaginaWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CliePrimerNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieRazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieReprLegal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClieSegundoNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieTelFijo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClieCiudadId = table.Column<int>(type: "int", nullable: false),
                    ClieDeptoId = table.Column<int>(type: "int", nullable: false),
                    CliePaisId = table.Column<int>(type: "int", nullable: false),
                    ClieEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ClieRegimenId = table.Column<int>(type: "int", nullable: false),
                    ClieRespFiscalId = table.Column<int>(type: "int", nullable: false),
                    ClieRespTributariaId = table.Column<int>(type: "int", nullable: false),
                    ClieTipoClienteId = table.Column<int>(type: "int", nullable: false),
                    ClieTipoIdId = table.Column<int>(type: "int", nullable: false),
                    ClieClasJuridicaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Ciudad_ClieCiudadId",
                        column: x => x.ClieCiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_ClasJuridica_ClieClasJuridicaId",
                        column: x => x.ClieClasJuridicaId,
                        principalTable: "ClasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Depto_ClieDeptoId",
                        column: x => x.ClieDeptoId,
                        principalTable: "Depto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Empresa_ClieEmpresaId",
                        column: x => x.ClieEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Pais_CliePaisId",
                        column: x => x.CliePaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Regimen_ClieRegimenId",
                        column: x => x.ClieRegimenId,
                        principalTable: "Regimen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_RespFiscal_ClieRespFiscalId",
                        column: x => x.ClieRespFiscalId,
                        principalTable: "RespFiscal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_RespTributaria_ClieRespTributariaId",
                        column: x => x.ClieRespTributariaId,
                        principalTable: "RespTributaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoCliente_ClieTipoClienteId",
                        column: x => x.ClieTipoClienteId,
                        principalTable: "TipoCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoId_ClieTipoIdId",
                        column: x => x.ClieTipoIdId,
                        principalTable: "TipoId",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresasUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmusUsuarioId = table.Column<int>(type: "int", nullable: false),
                    EmusEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresasUsuario_Empresa_EmusEmpresaId",
                        column: x => x.EmusEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresasUsuario_Usuario_EmusUsuarioId",
                        column: x => x.EmusUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormatoImpresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormatoImpresion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormatoImpresion_Empresa_FormEmpresaId",
                        column: x => x.FormEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotaCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NocrFactura = table.Column<long>(type: "bigint", nullable: false),
                    NocrMotivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NocrNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NocrValor = table.Column<long>(type: "bigint", nullable: false),
                    NocrValorIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NocrConceptoNotaId = table.Column<int>(type: "int", nullable: false),
                    NocrEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaCredito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaCredito_ConceptoNota_NocrConceptoNotaId",
                        column: x => x.NocrConceptoNotaId,
                        principalTable: "ConceptoNota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotaCredito_Empresa_NocrEmpresaId",
                        column: x => x.NocrEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotaDebito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NodbFactura = table.Column<long>(type: "bigint", nullable: false),
                    NodbMotivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NodbNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NodbValor = table.Column<long>(type: "bigint", nullable: false),
                    NodbValorIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NodbConceptoNotaId = table.Column<int>(type: "int", nullable: false),
                    NodbEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaDebito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaDebito_ConceptoNota_NodbConceptoNotaId",
                        column: x => x.NodbConceptoNotaId,
                        principalTable: "ConceptoNota",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotaDebito_Empresa_NodbEmpresaId",
                        column: x => x.NodbEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtrosProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtprCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtprNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtprEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtrosProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtrosProductos_Empresa_OtprEmpresaId",
                        column: x => x.OtprEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidCodigoDian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unidad_Empresa_UnidEmpresaId",
                        column: x => x.UnidEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendTipoDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedor_Empresa_VendEmpresaId",
                        column: x => x.VendEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoSalud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CosaContrato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CosaNitCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CosaPoliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CosaClieIdId = table.Column<int>(type: "int", nullable: false),
                    CosaCobeId = table.Column<int>(type: "int", nullable: false),
                    CosaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    CosaMopaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoSalud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoSalud_Cliente_CosaClieIdId",
                        column: x => x.CosaClieIdId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoSalud_Cobertura_CosaCobeId",
                        column: x => x.CosaCobeId,
                        principalTable: "Cobertura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoSalud_Empresa_CosaEmpresaId",
                        column: x => x.CosaEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoSalud_ModalidadPago_CosaMopaId",
                        column: x => x.CosaMopaId,
                        principalTable: "ModalidadPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SucursalCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuclDepto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclCiudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclDiasPago = table.Column<int>(type: "int", nullable: false),
                    SuclListaPrecio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuclClienteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucursalCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SucursalCliente_Cliente_SuclClienteId",
                        column: x => x.SuclClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SucuDepto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuCelular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuCiudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    SucuHabilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuLeyendaFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuLeyendaNotaCredito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuLeyendaNotaDebito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuListPrecio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuObservaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuPrincipal = table.Column<int>(type: "int", nullable: false),
                    SucuReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SucuTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SucuCentroCosto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SucuEmpresaId = table.Column<int>(type: "int", nullable: false),
                    SucuFormatoImpresionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sucursal_Empresa_SucuEmpresaId",
                        column: x => x.SucuEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sucursal_FormatoImpresion_SucuFormatoImpresionId",
                        column: x => x.SucuFormatoImpresionId,
                        principalTable: "FormatoImpresion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdListaPrecio = table.Column<int>(type: "int", nullable: false),
                    ProdMarca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdNombreFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdNombreTecnico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdUnidadHomologa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdCentroCostoId = table.Column<int>(type: "int", nullable: false),
                    ProdCodReteFuenteId = table.Column<int>(type: "int", nullable: false),
                    ProdCumId = table.Column<int>(type: "int", nullable: false),
                    ProdCupId = table.Column<int>(type: "int", nullable: false),
                    ProdEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ProdIumId = table.Column<int>(type: "int", nullable: false),
                    ProdTipoCupId = table.Column<int>(type: "int", nullable: false),
                    ProdTipoImpuestoId = table.Column<int>(type: "int", nullable: false),
                    ProdTipoRipsId = table.Column<int>(type: "int", nullable: false),
                    ProdUnidadId = table.Column<int>(type: "int", nullable: false),
                    ProdOtroProductoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_CentroCosto_ProdCentroCostoId",
                        column: x => x.ProdCentroCostoId,
                        principalTable: "CentroCosto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Cum_ProdCumId",
                        column: x => x.ProdCumId,
                        principalTable: "Cum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Cup_ProdCupId",
                        column: x => x.ProdCupId,
                        principalTable: "Cup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Empresa_ProdEmpresaId",
                        column: x => x.ProdEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Impuesto_ProdTipoImpuestoId",
                        column: x => x.ProdTipoImpuestoId,
                        principalTable: "Impuesto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Ium_ProdIumId",
                        column: x => x.ProdIumId,
                        principalTable: "Ium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_OtrosProductos_ProdOtroProductoId",
                        column: x => x.ProdOtroProductoId,
                        principalTable: "OtrosProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_ReteFuente_ProdCodReteFuenteId",
                        column: x => x.ProdCodReteFuenteId,
                        principalTable: "ReteFuente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_TipoArchivoRips_ProdTipoRipsId",
                        column: x => x.ProdTipoRipsId,
                        principalTable: "TipoArchivoRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_TipoCup_ProdTipoCupId",
                        column: x => x.ProdTipoCupId,
                        principalTable: "TipoCup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Unidad_ProdUnidadId",
                        column: x => x.ProdUnidadId,
                        principalTable: "Unidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resolucion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResoAnio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResoConsActual = table.Column<long>(type: "bigint", nullable: false),
                    ResoConsFinal = table.Column<long>(type: "bigint", nullable: false),
                    ResoConsInicial = table.Column<long>(type: "bigint", nullable: false),
                    ResoEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ResoFecheExpide = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResoPrefijo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResoVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResoNumeracionResolucionId = table.Column<int>(type: "int", nullable: false),
                    ResoEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ResoSucursalId = table.Column<int>(type: "int", nullable: false),
                    ResoTipoDocId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolucion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resolucion_Empresa_ResoEmpresaId",
                        column: x => x.ResoEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resolucion_NumeracionResolucion_ResoNumeracionResolucionId",
                        column: x => x.ResoNumeracionResolucionId,
                        principalTable: "NumeracionResolucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resolucion_Sucursal_ResoSucursalId",
                        column: x => x.ResoSucursalId,
                        principalTable: "Sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resolucion_TipoDocElectr_ResoTipoDocId",
                        column: x => x.ResoTipoDocId,
                        principalTable: "TipoDocElectr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListaPrecio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiprDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiprDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LiprEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    LiprNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiprValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LiprProductoId = table.Column<int>(type: "int", nullable: false),
                    LiprSucursalClienteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrecio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaPrecio_Producto_LiprProductoId",
                        column: x => x.LiprProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListaPrecio_SucursalCliente_LiprSucursalClienteId",
                        column: x => x.LiprSucursalClienteId,
                        principalTable: "SucursalCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactFechaTrm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactCompartidos = table.Column<long>(type: "bigint", nullable: false),
                    FactContador = table.Column<long>(type: "bigint", nullable: false),
                    FactContrato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactCopago = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactCufe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactCuotaRecupera = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactDescGlobal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactDespacho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    FactFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactFechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactFechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactFechaVence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactModalidadPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactModeradora = table.Column<long>(type: "bigint", nullable: false),
                    FactNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactObservaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactOperador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactOrden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactPoliza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactPorcIva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactRecepcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactRemision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactSubtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactSucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactTotalIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactTotalReteIca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactTrm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactValAnticipo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValorDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValTotRetefuente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactVendedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactClaseFacturaId = table.Column<int>(type: "int", nullable: false),
                    FactCoberturaId = table.Column<int>(type: "int", nullable: false),
                    FactCondicionVentaId = table.Column<int>(type: "int", nullable: false),
                    FactEmpresaId = table.Column<int>(type: "int", nullable: false),
                    FactEstadoDianId = table.Column<int>(type: "int", nullable: false),
                    FactFormaPagoId = table.Column<int>(type: "int", nullable: false),
                    FactFormatoImpresionId = table.Column<int>(type: "int", nullable: false),
                    FactMonedaId = table.Column<int>(type: "int", nullable: false),
                    FactSaludTipoId = table.Column<int>(type: "int", nullable: false),
                    FactTipoDescuentoId = table.Column<int>(type: "int", nullable: false),
                    FactTipoDocElectrId = table.Column<int>(type: "int", nullable: false),
                    FactListaPreciosId = table.Column<int>(type: "int", nullable: false),
                    FactNotaDebitoId = table.Column<int>(type: "int", nullable: false),
                    FactNotaCreditoId = table.Column<int>(type: "int", nullable: false),
                    FactClienteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_ClaseFactura_FactClaseFacturaId",
                        column: x => x.FactClaseFacturaId,
                        principalTable: "ClaseFactura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_FactClienteId",
                        column: x => x.FactClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Cobertura_FactCoberturaId",
                        column: x => x.FactCoberturaId,
                        principalTable: "Cobertura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_CondicionVenta_FactCondicionVentaId",
                        column: x => x.FactCondicionVentaId,
                        principalTable: "CondicionVenta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Empresa_FactEmpresaId",
                        column: x => x.FactEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_EstadoDianFactura_FactEstadoDianId",
                        column: x => x.FactEstadoDianId,
                        principalTable: "EstadoDianFactura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_FactSaludTipo_FactSaludTipoId",
                        column: x => x.FactSaludTipoId,
                        principalTable: "FactSaludTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_FormaPago_FactFormaPagoId",
                        column: x => x.FactFormaPagoId,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_FormatoImpresion_FactFormatoImpresionId",
                        column: x => x.FactFormatoImpresionId,
                        principalTable: "FormatoImpresion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_ListaPrecio_FactListaPreciosId",
                        column: x => x.FactListaPreciosId,
                        principalTable: "ListaPrecio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Moneda_FactMonedaId",
                        column: x => x.FactMonedaId,
                        principalTable: "Moneda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_NotaCredito_FactNotaCreditoId",
                        column: x => x.FactNotaCreditoId,
                        principalTable: "NotaCredito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_NotaDebito_FactNotaDebitoId",
                        column: x => x.FactNotaDebitoId,
                        principalTable: "NotaDebito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_TipoDescuento_FactTipoDescuentoId",
                        column: x => x.FactTipoDescuentoId,
                        principalTable: "TipoDescuento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_TipoDocElectr_FactTipoDocElectrId",
                        column: x => x.FactTipoDocElectrId,
                        principalTable: "TipoDocElectr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetaCantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaCentroCostos = table.Column<long>(type: "bigint", nullable: false),
                    DetaDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetaFactCodigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetaFechaDespacho = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DetaIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaLinea = table.Column<int>(type: "int", nullable: false),
                    DetaListaPrecio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetaOrdenCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetaPorDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaPorcIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaPorcCrf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaProducto = table.Column<long>(type: "bigint", nullable: false),
                    DetaRemision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetaValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaValReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaValRf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    DetaFacturaId = table.Column<int>(type: "int", nullable: false),
                    DetaRetefuenteId = table.Column<int>(type: "int", nullable: false),
                    DetaTipoImpuestoId = table.Column<int>(type: "int", nullable: false),
                    DetaUnidadId = table.Column<int>(type: "int", nullable: false),
                    DetaListaPreciosId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleFact_Empresa_DetaEmpresaId",
                        column: x => x.DetaEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFact_Factura_DetaFacturaId",
                        column: x => x.DetaFacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFact_Impuesto_DetaTipoImpuestoId",
                        column: x => x.DetaTipoImpuestoId,
                        principalTable: "Impuesto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFact_ListaPrecio_DetaListaPreciosId",
                        column: x => x.DetaListaPreciosId,
                        principalTable: "ListaPrecio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFact_ReteFuente_DetaRetefuenteId",
                        column: x => x.DetaRetefuenteId,
                        principalTable: "ReteFuente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleFact_Unidad_DetaUnidadId",
                        column: x => x.DetaUnidadId,
                        principalTable: "Unidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CentroCosto_CcosEmpresaId",
                table: "CentroCosto",
                column: "CcosEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_CiudDeptoId",
                table: "Ciudad",
                column: "CiudDeptoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieCiudadId",
                table: "Cliente",
                column: "ClieCiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieClasJuridicaId",
                table: "Cliente",
                column: "ClieClasJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieDeptoId",
                table: "Cliente",
                column: "ClieDeptoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieEmpresaId",
                table: "Cliente",
                column: "ClieEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CliePaisId",
                table: "Cliente",
                column: "CliePaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieRegimenId",
                table: "Cliente",
                column: "ClieRegimenId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieRespFiscalId",
                table: "Cliente",
                column: "ClieRespFiscalId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieRespTributariaId",
                table: "Cliente",
                column: "ClieRespTributariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieTipoClienteId",
                table: "Cliente",
                column: "ClieTipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClieTipoIdId",
                table: "Cliente",
                column: "ClieTipoIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoSalud_CosaClieIdId",
                table: "ContratoSalud",
                column: "CosaClieIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoSalud_CosaCobeId",
                table: "ContratoSalud",
                column: "CosaCobeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoSalud_CosaEmpresaId",
                table: "ContratoSalud",
                column: "CosaEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoSalud_CosaMopaId",
                table: "ContratoSalud",
                column: "CosaMopaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaEmpresaId",
                table: "DetalleFact",
                column: "DetaEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaFacturaId",
                table: "DetalleFact",
                column: "DetaFacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaListaPreciosId",
                table: "DetalleFact",
                column: "DetaListaPreciosId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaRetefuenteId",
                table: "DetalleFact",
                column: "DetaRetefuenteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaTipoImpuestoId",
                table: "DetalleFact",
                column: "DetaTipoImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaUnidadId",
                table: "DetalleFact",
                column: "DetaUnidadId");

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

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasUsuario_EmusEmpresaId",
                table: "EmpresasUsuario",
                column: "EmusEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasUsuario_EmusUsuarioId",
                table: "EmpresasUsuario",
                column: "EmusUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactClaseFacturaId",
                table: "Factura",
                column: "FactClaseFacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactClienteId",
                table: "Factura",
                column: "FactClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactCoberturaId",
                table: "Factura",
                column: "FactCoberturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactCondicionVentaId",
                table: "Factura",
                column: "FactCondicionVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactEmpresaId",
                table: "Factura",
                column: "FactEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactEstadoDianId",
                table: "Factura",
                column: "FactEstadoDianId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactFormaPagoId",
                table: "Factura",
                column: "FactFormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactFormatoImpresionId",
                table: "Factura",
                column: "FactFormatoImpresionId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactListaPreciosId",
                table: "Factura",
                column: "FactListaPreciosId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactMonedaId",
                table: "Factura",
                column: "FactMonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactNotaCreditoId",
                table: "Factura",
                column: "FactNotaCreditoId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactNotaDebitoId",
                table: "Factura",
                column: "FactNotaDebitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactSaludTipoId",
                table: "Factura",
                column: "FactSaludTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactTipoDescuentoId",
                table: "Factura",
                column: "FactTipoDescuentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactTipoDocElectrId",
                table: "Factura",
                column: "FactTipoDocElectrId");

            migrationBuilder.CreateIndex(
                name: "IX_FormatoImpresion_FormEmpresaId",
                table: "FormatoImpresion",
                column: "FormEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecio_LiprProductoId",
                table: "ListaPrecio",
                column: "LiprProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecio_LiprSucursalClienteId",
                table: "ListaPrecio",
                column: "LiprSucursalClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_LocaCiudadId",
                table: "Localidad",
                column: "LocaCiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_LocaDeptoId",
                table: "Localidad",
                column: "LocaDeptoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaCredito_NocrConceptoNotaId",
                table: "NotaCredito",
                column: "NocrConceptoNotaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaCredito_NocrEmpresaId",
                table: "NotaCredito",
                column: "NocrEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDebito_NodbConceptoNotaId",
                table: "NotaDebito",
                column: "NodbConceptoNotaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDebito_NodbEmpresaId",
                table: "NotaDebito",
                column: "NodbEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_OtrosProductos_OtprEmpresaId",
                table: "OtrosProductos",
                column: "OtprEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdCentroCostoId",
                table: "Producto",
                column: "ProdCentroCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdCodReteFuenteId",
                table: "Producto",
                column: "ProdCodReteFuenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdCumId",
                table: "Producto",
                column: "ProdCumId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdCupId",
                table: "Producto",
                column: "ProdCupId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdEmpresaId",
                table: "Producto",
                column: "ProdEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdIumId",
                table: "Producto",
                column: "ProdIumId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdOtroProductoId",
                table: "Producto",
                column: "ProdOtroProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdTipoCupId",
                table: "Producto",
                column: "ProdTipoCupId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdTipoImpuestoId",
                table: "Producto",
                column: "ProdTipoImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdTipoRipsId",
                table: "Producto",
                column: "ProdTipoRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdUnidadId",
                table: "Producto",
                column: "ProdUnidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolucion_ResoEmpresaId",
                table: "Resolucion",
                column: "ResoEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolucion_ResoNumeracionResolucionId",
                table: "Resolucion",
                column: "ResoNumeracionResolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolucion_ResoSucursalId",
                table: "Resolucion",
                column: "ResoSucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolucion_ResoTipoDocId",
                table: "Resolucion",
                column: "ResoTipoDocId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_RousRolId",
                table: "RolUsuario",
                column: "RousRolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuario_RousUsuarioId",
                table: "RolUsuario",
                column: "RousUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_SucuEmpresaId",
                table: "Sucursal",
                column: "SucuEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_SucuFormatoImpresionId",
                table: "Sucursal",
                column: "SucuFormatoImpresionId");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalCliente_SuclClienteId",
                table: "SucursalCliente",
                column: "SuclClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidad_UnidEmpresaId",
                table: "Unidad",
                column: "UnidEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_VendEmpresaId",
                table: "Vendedor",
                column: "VendEmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContratoSalud");

            migrationBuilder.DropTable(
                name: "DetalleFact");

            migrationBuilder.DropTable(
                name: "EmpresasUsuario");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Resolucion");

            migrationBuilder.DropTable(
                name: "RolUsuario");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "ModalidadPago");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "NumeracionResolucion");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "ClaseFactura");

            migrationBuilder.DropTable(
                name: "Cobertura");

            migrationBuilder.DropTable(
                name: "CondicionVenta");

            migrationBuilder.DropTable(
                name: "EstadoDianFactura");

            migrationBuilder.DropTable(
                name: "FactSaludTipo");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "ListaPrecio");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "NotaCredito");

            migrationBuilder.DropTable(
                name: "NotaDebito");

            migrationBuilder.DropTable(
                name: "TipoDescuento");

            migrationBuilder.DropTable(
                name: "TipoDocElectr");

            migrationBuilder.DropTable(
                name: "FormatoImpresion");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "SucursalCliente");

            migrationBuilder.DropTable(
                name: "ConceptoNota");

            migrationBuilder.DropTable(
                name: "CentroCosto");

            migrationBuilder.DropTable(
                name: "Cum");

            migrationBuilder.DropTable(
                name: "Cup");

            migrationBuilder.DropTable(
                name: "Impuesto");

            migrationBuilder.DropTable(
                name: "Ium");

            migrationBuilder.DropTable(
                name: "OtrosProductos");

            migrationBuilder.DropTable(
                name: "ReteFuente");

            migrationBuilder.DropTable(
                name: "TipoArchivoRips");

            migrationBuilder.DropTable(
                name: "TipoCup");

            migrationBuilder.DropTable(
                name: "Unidad");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Depto");

            migrationBuilder.DropTable(
                name: "ClasJuridica");

            migrationBuilder.DropTable(
                name: "Regimen");

            migrationBuilder.DropTable(
                name: "RespFiscal");

            migrationBuilder.DropTable(
                name: "RespTributaria");

            migrationBuilder.DropTable(
                name: "TipoCliente");

            migrationBuilder.DropTable(
                name: "TipoId");
        }
    }
}
