using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolCodigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolEstado = table.Column<bool>(type: "bit", nullable: true),
                    RolFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RolFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuaPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuaIntentos = table.Column<int>(type: "int", nullable: true),
                    UsuaEstado = table.Column<bool>(type: "bit", nullable: true),
                    UsuaFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuaFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuaId);
                });

            migrationBuilder.CreateTable(
                name: "RolesUsuario",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleUsuarioUsuaId = table.Column<int>(type: "int", nullable: true),
                    RoleRolRolId = table.Column<int>(type: "int", nullable: true),
                    RoleEstado = table.Column<bool>(type: "bit", nullable: true),
                    RoleFechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleFechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesUsuario", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_RolesUsuario_Rol_RoleRolRolId",
                        column: x => x.RoleRolRolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolesUsuario_Usuario_RoleUsuarioUsuaId",
                        column: x => x.RoleUsuarioUsuaId,
                        principalTable: "Usuario",
                        principalColumn: "UsuaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsuario_RoleRolRolId",
                table: "RolesUsuario",
                column: "RoleRolRolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesUsuario_RoleUsuarioUsuaId",
                table: "RolesUsuario",
                column: "RoleUsuarioUsuaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesUsuario");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
