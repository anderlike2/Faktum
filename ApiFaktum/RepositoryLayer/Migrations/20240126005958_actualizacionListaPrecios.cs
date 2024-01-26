using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class actualizacionListaPrecios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFact_ListaPrecio_DetaListaPreciosId",
                table: "DetalleFact");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_ListaPrecio_FactListaPreciosId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaPrecio_Producto_LiprProductoId",
                table: "ListaPrecio");

            migrationBuilder.DropIndex(
                name: "IX_Factura_FactListaPreciosId",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFact_DetaListaPreciosId",
                table: "DetalleFact");

            migrationBuilder.DropColumn(
                name: "LiprDescuento",
                table: "ListaPrecio");

            migrationBuilder.DropColumn(
                name: "LiprValor",
                table: "ListaPrecio");

            migrationBuilder.DropColumn(
                name: "FactListaPreciosId",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "DetaListaPreciosId",
                table: "DetalleFact");

            migrationBuilder.RenameColumn(
                name: "LiprProductoId",
                table: "ListaPrecio",
                newName: "LiprEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_ListaPrecio_LiprProductoId",
                table: "ListaPrecio",
                newName: "IX_ListaPrecio_LiprEmpresaId");

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
                name: "FK_ListaPrecio_Empresa_LiprEmpresaId",
                table: "ListaPrecio",
                column: "LiprEmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaPrecio_Producto_ProductoModelId",
                table: "ListaPrecio",
                column: "ProductoModelId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaPrecio_Empresa_LiprEmpresaId",
                table: "ListaPrecio");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaPrecio_Producto_ProductoModelId",
                table: "ListaPrecio");

            migrationBuilder.DropIndex(
                name: "IX_ListaPrecio_ProductoModelId",
                table: "ListaPrecio");

            migrationBuilder.DropColumn(
                name: "ProductoModelId",
                table: "ListaPrecio");

            migrationBuilder.RenameColumn(
                name: "LiprEmpresaId",
                table: "ListaPrecio",
                newName: "LiprProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_ListaPrecio_LiprEmpresaId",
                table: "ListaPrecio",
                newName: "IX_ListaPrecio_LiprProductoId");

            migrationBuilder.AddColumn<decimal>(
                name: "LiprDescuento",
                table: "ListaPrecio",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LiprValor",
                table: "ListaPrecio",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "FactListaPreciosId",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetaListaPreciosId",
                table: "DetalleFact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Factura_FactListaPreciosId",
                table: "Factura",
                column: "FactListaPreciosId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFact_DetaListaPreciosId",
                table: "DetalleFact",
                column: "DetaListaPreciosId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFact_ListaPrecio_DetaListaPreciosId",
                table: "DetalleFact",
                column: "DetaListaPreciosId",
                principalTable: "ListaPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_ListaPrecio_FactListaPreciosId",
                table: "Factura",
                column: "FactListaPreciosId",
                principalTable: "ListaPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaPrecio_Producto_LiprProductoId",
                table: "ListaPrecio",
                column: "LiprProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
