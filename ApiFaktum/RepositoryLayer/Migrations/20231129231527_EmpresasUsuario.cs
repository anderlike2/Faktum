using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class EmpresasUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresasUsuario_Empresa_EmusRolId",
                table: "EmpresasUsuario");

            migrationBuilder.RenameColumn(
                name: "EmusRolId",
                table: "EmpresasUsuario",
                newName: "EmusEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresasUsuario_EmusRolId",
                table: "EmpresasUsuario",
                newName: "IX_EmpresasUsuario_EmusEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresasUsuario_Empresa_EmusEmpresaId",
                table: "EmpresasUsuario",
                column: "EmusEmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresasUsuario_Empresa_EmusEmpresaId",
                table: "EmpresasUsuario");

            migrationBuilder.RenameColumn(
                name: "EmusEmpresaId",
                table: "EmpresasUsuario",
                newName: "EmusRolId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresasUsuario_EmusEmpresaId",
                table: "EmpresasUsuario",
                newName: "IX_EmpresasUsuario_EmusRolId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresasUsuario_Empresa_EmusRolId",
                table: "EmpresasUsuario",
                column: "EmusRolId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
