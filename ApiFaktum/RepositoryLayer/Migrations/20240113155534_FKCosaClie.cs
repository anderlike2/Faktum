using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class FKCosaClie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContratoSalud_Cliente_CosaClieIdId",
                table: "ContratoSalud");

            migrationBuilder.RenameColumn(
                name: "CosaClieIdId",
                table: "ContratoSalud",
                newName: "CosaClieId");

            migrationBuilder.RenameIndex(
                name: "IX_ContratoSalud_CosaClieIdId",
                table: "ContratoSalud",
                newName: "IX_ContratoSalud_CosaClieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoSalud_Cliente_CosaClieId",
                table: "ContratoSalud",
                column: "CosaClieId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContratoSalud_Cliente_CosaClieId",
                table: "ContratoSalud");

            migrationBuilder.RenameColumn(
                name: "CosaClieId",
                table: "ContratoSalud",
                newName: "CosaClieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ContratoSalud_CosaClieId",
                table: "ContratoSalud",
                newName: "IX_ContratoSalud_CosaClieIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoSalud_Cliente_CosaClieIdId",
                table: "ContratoSalud",
                column: "CosaClieIdId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
