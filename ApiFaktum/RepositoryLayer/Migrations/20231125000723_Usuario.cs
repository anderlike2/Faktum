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
            migrationBuilder.AlterColumn<int>(
                name: "UsuaIntentos",
                table: "Usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "UsuaEstado",
                table: "Usuario",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "UsuaFechaCreacion",
                table: "Usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UsuaFechaModificacion",
                table: "Usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RoleEstado",
                table: "RolesUsuario",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "RoleFechaCreacion",
                table: "RolesUsuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RoleFechaModificacion",
                table: "RolesUsuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RolEstado",
                table: "Rol",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "RolFechaCreacion",
                table: "Rol",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RolFechaModificacion",
                table: "Rol",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuaFechaCreacion",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuaFechaModificacion",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "RoleFechaCreacion",
                table: "RolesUsuario");

            migrationBuilder.DropColumn(
                name: "RoleFechaModificacion",
                table: "RolesUsuario");

            migrationBuilder.DropColumn(
                name: "RolFechaCreacion",
                table: "Rol");

            migrationBuilder.DropColumn(
                name: "RolFechaModificacion",
                table: "Rol");

            migrationBuilder.AlterColumn<int>(
                name: "UsuaIntentos",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "UsuaEstado",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RoleEstado",
                table: "RolesUsuario",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RolEstado",
                table: "Rol",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
