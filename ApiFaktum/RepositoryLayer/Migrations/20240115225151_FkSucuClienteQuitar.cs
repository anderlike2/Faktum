using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class FkSucuClienteQuitar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LiprSucursalClienteId",
                table: "ListaPrecio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LiprSucursalClienteId",
                table: "ListaPrecio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
