using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class actualizacionCamposFk2ListaPrecios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaPrecio_Producto_ProductoModelId",
                table: "ListaPrecio");

            migrationBuilder.DropIndex(
                name: "IX_ListaPrecio_ProductoModelId",
                table: "ListaPrecio");

            migrationBuilder.DropColumn(
                name: "ProductoModelId",
                table: "ListaPrecio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoModelId",
                table: "ListaPrecio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecio_ProductoModelId",
                table: "ListaPrecio",
                column: "ProductoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaPrecio_Producto_ProductoModelId",
                table: "ListaPrecio",
                column: "ProductoModelId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
