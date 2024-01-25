using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ModeloDatosRips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioSaludRips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsUaId = table.Column<int>(type: "int", nullable: true),
                    UsUaEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaTipoDocRips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaNumeroDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaTipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaFechaNac = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsUaSexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaPrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaSegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaPrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaSegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaPaisNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaPaisResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaAdepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaZonaTerritorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsUaATelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSaludRips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioSaludRips");
        }
    }
}
