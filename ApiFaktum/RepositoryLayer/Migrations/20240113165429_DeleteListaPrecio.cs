using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class DeleteListaPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdListaPrecio",
                table: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdListaPrecio",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
