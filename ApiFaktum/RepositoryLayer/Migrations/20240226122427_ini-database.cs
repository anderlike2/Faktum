using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class inidatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClaseFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClfaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClfaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaseFactura", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClasJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JuriCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JuriNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JuriEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasJuridica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cobertura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CobeCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CobeNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConceptoNota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConoCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConoNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConoTipoNota = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoNota", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CondicionVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoveCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoveNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionVenta", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CumsCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CumsNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CumsConsecutivo = table.Column<int>(type: "int", nullable: false),
                    CumsExpediente = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cum", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CupsCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CupsNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Depto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeptoCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeptoNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoDianFactura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EsfaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EsfaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDianFactura", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EsRiNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FactSaludTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FasaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FasaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactSaludTipo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FopaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FopaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HospitalizacionRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HoRiUsuariosRips = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiViaIngreso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiFechaInicioAtencion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    HoRiNumAutoriza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCausaMotivoAtencion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCodigoDiagPrincipal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCodigoDiagRel1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCodigoDiagRel2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCodigoDiagRel3 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiCodComplicacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HoRiConDestUsuarioOe = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCodDiagMuerte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiFechaEgreso = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalizacionRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Impuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImpuCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImpuNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImpuEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ImpuOperacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImpuPorcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuesto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IncapacidadRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InRiCodigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InRiNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncapacidadRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IumCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IumNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IumUnidad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ium", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicamentosRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MeRiPrestador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiUsuariosRips = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiNumAutoriza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiMiPresid = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiDisp = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MeRiCodigoDiagPrincipal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiCodigoDiagRel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiTipoMed = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiDetaBorrador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiNombreMedicamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiConcentracion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiUnidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiFormaFarmaceutica = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiUnidadMinimaDisp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiCantidadDisp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiNumDias = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    MeRiNumDocMedico = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiValUnitario = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiValorServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiTipoPagoModerador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiValorPagoModerador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MeRiNumFactPagoMod = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentosRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModalidadAtencionRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MoAtCodigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoAtNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadAtencionRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModalidadPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MopaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MopaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MoneCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MoneNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrigenRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrRiNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrigenRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OtroServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OtRiPrestador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiUsuarioRips = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiNumAutoriza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiIdMiPres = table.Column<int>(type: "int", nullable: true),
                    OtRiFechaServicio = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    OtRiTipoOtro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiDetaBorrador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiTipoIdMedico = table.Column<int>(type: "int", nullable: true),
                    OtRiNumDocMedico = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiCodCups = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiVUnitario = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiValorServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiTipoPagoModerador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiValorPagoModerador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtRiNumFactPagoMod = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtroServicioRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaisCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecienNacidoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RnRiPrestador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnUsuarioRips = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiTipoRNid = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiFechaNac = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    RnRiEdadGestacional = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiRoConsPreNatal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiSexo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiPeso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiCodigoDiagPrincipal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiConDestUsuarioE = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiCodDiagMuerte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RnRiFechaEgreso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecienNacidoRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regimen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegiCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegiNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegiEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regimen", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespFiscal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefiCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefiNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespFiscal", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespTributaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RetrCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RetrNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespTributaria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReteFuente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReteCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReteNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RetePorcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReteFuente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RolCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RolDescripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeRiCodigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeRiNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoArchivoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArriCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArriNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArchivoRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiclCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiclNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoCup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TicuCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TicuNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCup", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDescuento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TideCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TideNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDescuento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocElectr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TidoCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TidoNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocElectr", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiDrCodigo = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiDrNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiidCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiidNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoId", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoNotaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiNrCodigo = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiNrNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotaRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoOtroServicioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiOtCodigo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiOtNombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOtroServicioRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoUsuariosRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TiRiCodigo = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TiRiNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuariosRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UrgenciaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UrRiPrestador = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiFechaConsulta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UrRiCausaMotivoAtencio = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCodigoDiagPrincipal = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URiCodigoDiagPrincipalE = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCodigoDiagRel1 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCodigoDiagRel2 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCodigoDiagRel3 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiConDestUsuarioE = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiCondDiagMuerte = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrRiFechaEgreso = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UrRiConsutivo = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgenciaRips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuaUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuaPassword = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuaIntentos = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CiudCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CiudNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CiudDeptoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RousUsuarioId = table.Column<int>(type: "int", nullable: false),
                    RousRolId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmprFactContador = table.Column<int>(type: "int", nullable: false),
                    EmprCelular = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprCiuu = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprContacto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprDiasPago = table.Column<int>(type: "int", nullable: false),
                    EmprDireccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprDv = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprFormatoImpr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprIdRepLegal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprLeyEnFactura = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprLeyEnNotaCredito = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprLeyEnNotaDebito = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprLocalidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprMail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprRecepcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprNit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprObservaciones = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprPagWeb = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprPorcReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmprRepLegal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprTelefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprHabilitacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprLogo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmprTipoClienteId = table.Column<int>(type: "int", nullable: false),
                    EmprTipoIdId = table.Column<int>(type: "int", nullable: false),
                    EmprRespTributId = table.Column<int>(type: "int", nullable: false),
                    EmprRegimenId = table.Column<int>(type: "int", nullable: false),
                    EmprRespFiscalId = table.Column<int>(type: "int", nullable: false),
                    EmprClasJuridicaId = table.Column<int>(type: "int", nullable: false),
                    EmprCiudadId = table.Column<int>(type: "int", nullable: false),
                    EmprDeptoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Ciudad_EmprCiudadId",
                        column: x => x.EmprCiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_ClasJuridica_EmprClasJuridicaId",
                        column: x => x.EmprClasJuridicaId,
                        principalTable: "ClasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresa_Depto_EmprDeptoId",
                        column: x => x.EmprDeptoId,
                        principalTable: "Depto",
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocaCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocaNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocaDeptoId = table.Column<int>(type: "int", nullable: false),
                    LocaCiudadId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioSaludRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsUaNumeroDoc = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaFechaNac = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UsUaSexo = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaPrimerNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaSegundoNombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaPrimerApellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaSegundoApellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaZonaTerritorial = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaIncapacidad = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaTelefono = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaDireccion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsUaTipoDocRipsId = table.Column<int>(type: "int", nullable: false),
                    UsUaTipoUsuarioRips = table.Column<int>(type: "int", nullable: false),
                    UsUaCiudadResidenciaId = table.Column<int>(type: "int", nullable: false),
                    UsUaPaisNacimientoId = table.Column<int>(type: "int", nullable: false),
                    UsUaTipoUsuariosRipsId = table.Column<int>(type: "int", nullable: false),
                    UsUaCiudadResicenciaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSaludRips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioSaludRips_Ciudad_UsUaCiudadResicenciaId",
                        column: x => x.UsUaCiudadResicenciaId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioSaludRips_Ciudad_UsUaPaisNacimientoId",
                        column: x => x.UsUaPaisNacimientoId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioSaludRips_TipoDocRips_UsUaTipoDocRipsId",
                        column: x => x.UsUaTipoDocRipsId,
                        principalTable: "TipoDocRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioSaludRips_TipoUsuariosRips_UsUaTipoUsuariosRipsId",
                        column: x => x.UsUaTipoUsuariosRipsId,
                        principalTable: "TipoUsuariosRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CentroCosto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CcosCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CcosNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CcosEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClieApellidos = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieCelular = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieCiuu = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieCobertura = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieContacto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieCorreo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieCorreoFact = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieDescGlobal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClieDiasPago = table.Column<int>(type: "int", nullable: false),
                    ClieDireccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieDv = table.Column<long>(type: "bigint", nullable: false),
                    ClieEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ClieIdReprLegal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieJuridica = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieLocalidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieNit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CliePaginaWeb = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CliePrimerNom = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieRazonSocial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieReprLegal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieSegundoNom = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClieTelFijo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmpresasUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmusUsuarioId = table.Column<int>(type: "int", nullable: false),
                    EmusEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormatoImpresion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListaPrecio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LiprDescripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LiprEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    LiprNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LiprEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrecio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaPrecio_Empresa_LiprEmpresaId",
                        column: x => x.LiprEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotaCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NocrFactura = table.Column<long>(type: "bigint", nullable: false),
                    NocrMotivo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NocrNumero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NocrValor = table.Column<long>(type: "bigint", nullable: false),
                    NocrValorIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NocrConceptoNotaId = table.Column<int>(type: "int", nullable: false),
                    NocrEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotaDebito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NodbFactura = table.Column<long>(type: "bigint", nullable: false),
                    NodbMotivo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NodbNumero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NodbValor = table.Column<long>(type: "bigint", nullable: false),
                    NodbValorIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NodbConceptoNotaId = table.Column<int>(type: "int", nullable: false),
                    NodbEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OtrosProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OtprCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtprNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtprEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Resolucion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResoAnio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResoConsActual = table.Column<long>(type: "bigint", nullable: false),
                    ResoConsFinal = table.Column<long>(type: "bigint", nullable: false),
                    ResoConsInicial = table.Column<long>(type: "bigint", nullable: false),
                    ResoEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    ResoFechaExpide = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ResoPrefijo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResoVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ResoCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResoNumeracionActual = table.Column<int>(type: "int", nullable: false),
                    ResoEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ResoTipoDocId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                        name: "FK_Resolucion_TipoDocElectr_ResoTipoDocId",
                        column: x => x.ResoTipoDocId,
                        principalTable: "TipoDocElectr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Unidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnidCodigoDian = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnidCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnidNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnidEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VendCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VendNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VendTipoDoc = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VendEmpresaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConsultaRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoRiPrestador = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiFechaConsulta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CoRiNumAutorizacion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodCups = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiModGrSerAtencion = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiGrupoServicios = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodigoServicios = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    CoRiFinalidadConsulta = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCausaMotivoAtencion = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodigoDiagPrincipal = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodigoDiagRel1 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodigoDiagRel2 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiCodigoDiagRel3 = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiTipoDiagPrincipal = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiValorConsulta = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    CoRiTipoPagoModerador = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiValorPagoModerador = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CoriNumFactPagoMod = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoRiConsecutivo = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    CoRiUsuarioSaludRipsId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaRips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultaRips_UsuarioSaludRips_CoRiUsuarioSaludRipsId",
                        column: x => x.CoRiUsuarioSaludRipsId,
                        principalTable: "UsuarioSaludRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProcedimientoRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrRiPrestador = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiFechaConsulta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PrRiIdMPres = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    PrRiNumAutorizacion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiCodCups = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiViaIngresoUsuario = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiModGrServAtencion = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiGrupoServicios = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiCodigoServicios = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    PrRiFinalidadConsulta = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiCodigoDiagPrincipal = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiCodigoDiagRel = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiComplicacion = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiValorProcedimiento = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    PrRiTipoPagoModerador = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiValorPagoModerador = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    PrRiNumFactPagoMod = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrRiConsecutivo = table.Column<int>(type: "int", nullable: false),
                    PrRiUsuarioSaludRipsId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimientoRips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedimientoRips_UsuarioSaludRips_PrRiUsuarioSaludRipsId",
                        column: x => x.PrRiUsuarioSaludRipsId,
                        principalTable: "UsuarioSaludRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContratoSalud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CosaContrato = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CosaPoliza = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CosaClieId = table.Column<int>(type: "int", nullable: false),
                    CosaCobeId = table.Column<int>(type: "int", nullable: false),
                    CosaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    CosaMopaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoSalud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoSalud_Cliente_CosaClieId",
                        column: x => x.CosaClieId,
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SucuDepto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuCelular = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuCiudad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuContacto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuDireccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    SucuHabilitacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuLeyendaFactura = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuLeyendaNotaCredito = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuLeyendaNotaDebito = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuListPrecio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuMail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuNombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuObservaciones = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuPrincipal = table.Column<int>(type: "int", nullable: false),
                    SucuReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SucuTelefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuCentroCosto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucuEmpresaId = table.Column<int>(type: "int", nullable: false),
                    SucuFormatoImpresionId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FactFechaTrm = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FactCompartidos = table.Column<long>(type: "bigint", nullable: true),
                    FactContador = table.Column<long>(type: "bigint", nullable: false),
                    FactContrato = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactCopago = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactCufe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactCuotaRecupera = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactDescGlobal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactDespacho = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactEstadoOperacion = table.Column<int>(type: "int", nullable: false),
                    FactFecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FactFechaFinal = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FactFechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FactFechaVence = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FactModalidadPago = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactModeradora = table.Column<long>(type: "bigint", nullable: true),
                    FactNumero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactObservaciones = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactOperador = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactOrden = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactPoliza = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactPorcIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactRecepcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactRemision = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactSubtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactSucursal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactTotalIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactTotalReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactTrm = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactValAnticipo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValorDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactValTotRetefuente = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactVendedor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    FactNotaDebitoId = table.Column<int>(type: "int", nullable: true),
                    FactNotaCreditoId = table.Column<int>(type: "int", nullable: true),
                    FactClienteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdMarca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdModelo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdNombreFactura = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdNombreTecnico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdUnidadHomologa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProdValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdPorcReteFuente = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdPorcIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdCentroCostoId = table.Column<int>(type: "int", nullable: false),
                    ProdCumId = table.Column<int>(type: "int", nullable: true),
                    ProdCupId = table.Column<int>(type: "int", nullable: true),
                    ProdEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ProdIumId = table.Column<int>(type: "int", nullable: true),
                    ProdTipoCupId = table.Column<int>(type: "int", nullable: false),
                    ProdTipoImpuestoId = table.Column<int>(type: "int", nullable: false),
                    ProdTipoRipsId = table.Column<int>(type: "int", nullable: false),
                    ProdUnidadId = table.Column<int>(type: "int", nullable: false),
                    ProdOtroProductoId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ResolucionSucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ResuResolucionId = table.Column<int>(type: "int", nullable: false),
                    ResuSucursalId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResolucionSucursal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResolucionSucursal_Resolucion_ResuResolucionId",
                        column: x => x.ResuResolucionId,
                        principalTable: "Resolucion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResolucionSucursal_Sucursal_ResuSucursalId",
                        column: x => x.ResuSucursalId,
                        principalTable: "Sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleFact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DetaCantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaCentroCostos = table.Column<long>(type: "bigint", nullable: false),
                    DetaDescripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetaFactCodigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetaFechaDespacho = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DetaIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaLinea = table.Column<int>(type: "int", nullable: false),
                    DetaListaPrecio = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetaOrdenCompra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetaPorDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaPorcIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaPorcCrf = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DetaProducto = table.Column<long>(type: "bigint", nullable: false),
                    DetaRemision = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetaValor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DetaValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DetaValReteIca = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DetaValRf = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DetaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    DetaFacturaId = table.Column<int>(type: "int", nullable: false),
                    DetaRetefuenteId = table.Column<int>(type: "int", nullable: false),
                    DetaTipoImpuestoId = table.Column<int>(type: "int", nullable: false),
                    DetaUnidadId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ObjetoRaiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObRaNit = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObRaNumNota = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObRaJsOn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObRaTerminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ObRaGenerado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ObRaOperador = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ObRaEmpresaId = table.Column<int>(type: "int", nullable: false),
                    ObRaFacturaId = table.Column<int>(type: "int", nullable: false),
                    ObRaTipoNotaRipsId = table.Column<int>(type: "int", nullable: false),
                    ObRaOrigenRipsId = table.Column<int>(type: "int", nullable: false),
                    ObRaEstadoRipsId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetoRaiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_Empresa_ObRaEmpresaId",
                        column: x => x.ObRaEmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_EstadoRips_ObRaEstadoRipsId",
                        column: x => x.ObRaEstadoRipsId,
                        principalTable: "EstadoRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_Factura_ObRaFacturaId",
                        column: x => x.ObRaFacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_OrigenRips_ObRaOrigenRipsId",
                        column: x => x.ObRaOrigenRipsId,
                        principalTable: "OrigenRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ObjetoRaiz_TipoNotaRips_ObRaTipoNotaRipsId",
                        column: x => x.ObRaTipoNotaRipsId,
                        principalTable: "TipoNotaRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListaPrecioProducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LproValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LproDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LproListaPrecioId = table.Column<int>(type: "int", nullable: false),
                    LproProductoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrecioProducto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaPrecioProducto_ListaPrecio_LproListaPrecioId",
                        column: x => x.LproListaPrecioId,
                        principalTable: "ListaPrecio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListaPrecioProducto_Producto_LproProductoId",
                        column: x => x.LproProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObRaUsUaUsuarioId = table.Column<int>(type: "int", nullable: false),
                    ObRaUsUaObjetoRaizId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioRips_ObjetoRaiz_ObRaUsUaObjetoRaizId",
                        column: x => x.ObRaUsUaObjetoRaizId,
                        principalTable: "ObjetoRaiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioRips_UsuarioSaludRips_ObRaUsUaUsuarioId",
                        column: x => x.ObRaUsUaUsuarioId,
                        principalTable: "UsuarioSaludRips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "IX_ConsultaRips_CoRiUsuarioSaludRipsId",
                table: "ConsultaRips",
                column: "CoRiUsuarioSaludRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoSalud_CosaClieId",
                table: "ContratoSalud",
                column: "CosaClieId");

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
                name: "IX_Empresa_EmprCiudadId",
                table: "Empresa",
                column: "EmprCiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprClasJuridicaId",
                table: "Empresa",
                column: "EmprClasJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EmprDeptoId",
                table: "Empresa",
                column: "EmprDeptoId");

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
                name: "IX_ListaPrecio_LiprEmpresaId",
                table: "ListaPrecio",
                column: "LiprEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecioProducto_LproListaPrecioId",
                table: "ListaPrecioProducto",
                column: "LproListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecioProducto_LproProductoId",
                table: "ListaPrecioProducto",
                column: "LproProductoId");

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
                name: "IX_ObjetoRaiz_ObRaEmpresaId",
                table: "ObjetoRaiz",
                column: "ObRaEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_ObRaEstadoRipsId",
                table: "ObjetoRaiz",
                column: "ObRaEstadoRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_ObRaFacturaId",
                table: "ObjetoRaiz",
                column: "ObRaFacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_ObRaOrigenRipsId",
                table: "ObjetoRaiz",
                column: "ObRaOrigenRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetoRaiz_ObRaTipoNotaRipsId",
                table: "ObjetoRaiz",
                column: "ObRaTipoNotaRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_OtrosProductos_OtprEmpresaId",
                table: "OtrosProductos",
                column: "OtprEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimientoRips_PrRiUsuarioSaludRipsId",
                table: "ProcedimientoRips",
                column: "PrRiUsuarioSaludRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProdCentroCostoId",
                table: "Producto",
                column: "ProdCentroCostoId");

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
                name: "IX_Resolucion_ResoTipoDocId",
                table: "Resolucion",
                column: "ResoTipoDocId");

            migrationBuilder.CreateIndex(
                name: "IX_ResolucionSucursal_ResuResolucionId",
                table: "ResolucionSucursal",
                column: "ResuResolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResolucionSucursal_ResuSucursalId",
                table: "ResolucionSucursal",
                column: "ResuSucursalId");

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
                name: "IX_Unidad_UnidEmpresaId",
                table: "Unidad",
                column: "UnidEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRips_ObRaUsUaObjetoRaizId",
                table: "UsuarioRips",
                column: "ObRaUsUaObjetoRaizId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRips_ObRaUsUaUsuarioId",
                table: "UsuarioRips",
                column: "ObRaUsUaUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_UsUaCiudadResicenciaId",
                table: "UsuarioSaludRips",
                column: "UsUaCiudadResicenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_UsUaPaisNacimientoId",
                table: "UsuarioSaludRips",
                column: "UsUaPaisNacimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_UsUaTipoDocRipsId",
                table: "UsuarioSaludRips",
                column: "UsUaTipoDocRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioSaludRips_UsUaTipoUsuariosRipsId",
                table: "UsuarioSaludRips",
                column: "UsUaTipoUsuariosRipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_VendEmpresaId",
                table: "Vendedor",
                column: "VendEmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultaRips");

            migrationBuilder.DropTable(
                name: "ContratoSalud");

            migrationBuilder.DropTable(
                name: "DetalleFact");

            migrationBuilder.DropTable(
                name: "EmpresasUsuario");

            migrationBuilder.DropTable(
                name: "HospitalizacionRips");

            migrationBuilder.DropTable(
                name: "IncapacidadRips");

            migrationBuilder.DropTable(
                name: "ListaPrecioProducto");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "MedicamentosRips");

            migrationBuilder.DropTable(
                name: "ModalidadAtencionRips");

            migrationBuilder.DropTable(
                name: "OtroServicioRips");

            migrationBuilder.DropTable(
                name: "ProcedimientoRips");

            migrationBuilder.DropTable(
                name: "RecienNacidoRips");

            migrationBuilder.DropTable(
                name: "ResolucionSucursal");

            migrationBuilder.DropTable(
                name: "RolUsuario");

            migrationBuilder.DropTable(
                name: "ServicioRips");

            migrationBuilder.DropTable(
                name: "TipoOtroServicioRips");

            migrationBuilder.DropTable(
                name: "UrgenciaRips");

            migrationBuilder.DropTable(
                name: "UsuarioRips");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "ModalidadPago");

            migrationBuilder.DropTable(
                name: "ReteFuente");

            migrationBuilder.DropTable(
                name: "ListaPrecio");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Resolucion");

            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "ObjetoRaiz");

            migrationBuilder.DropTable(
                name: "UsuarioSaludRips");

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
                name: "TipoArchivoRips");

            migrationBuilder.DropTable(
                name: "TipoCup");

            migrationBuilder.DropTable(
                name: "Unidad");

            migrationBuilder.DropTable(
                name: "EstadoRips");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "OrigenRips");

            migrationBuilder.DropTable(
                name: "TipoNotaRips");

            migrationBuilder.DropTable(
                name: "TipoDocRips");

            migrationBuilder.DropTable(
                name: "TipoUsuariosRips");

            migrationBuilder.DropTable(
                name: "ClaseFactura");

            migrationBuilder.DropTable(
                name: "Cliente");

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
                name: "FormatoImpresion");

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
                name: "Pais");

            migrationBuilder.DropTable(
                name: "ConceptoNota");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Ciudad");

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

            migrationBuilder.DropTable(
                name: "Depto");
        }
    }
}
