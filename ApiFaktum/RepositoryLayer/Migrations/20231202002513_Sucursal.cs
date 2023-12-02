using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class Sucursal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sucursal_CentroCosto_CentroCostoModelId",
                table: "Sucursal");

            migrationBuilder.DropIndex(
                name: "IX_Sucursal_CentroCostoModelId",
                table: "Sucursal");

            migrationBuilder.DropColumn(
                name: "CentroCostoModelId",
                table: "Sucursal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CentroCostoModelId",
                table: "Sucursal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_CentroCostoModelId",
                table: "Sucursal",
                column: "CentroCostoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursal_CentroCosto_CentroCostoModelId",
                table: "Sucursal",
                column: "CentroCostoModelId",
                principalTable: "CentroCosto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
