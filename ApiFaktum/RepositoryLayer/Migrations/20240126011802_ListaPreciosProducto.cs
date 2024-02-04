using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ListaPreciosProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaPrecioProducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LproValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LproDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LproListaPrecioId = table.Column<int>(type: "int", nullable: false),
                    LproProductoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecioProducto_LproListaPrecioId",
                table: "ListaPrecioProducto",
                column: "LproListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecioProducto_LproProductoId",
                table: "ListaPrecioProducto",
                column: "LproProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaPrecioProducto");
        }
    }
}
