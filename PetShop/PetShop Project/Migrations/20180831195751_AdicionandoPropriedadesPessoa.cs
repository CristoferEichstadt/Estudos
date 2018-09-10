using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop_Project.Migrations
{
    public partial class AdicionandoPropriedadesPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InscricaoEstadual",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeFantasia",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Pessoas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InscricaoEstadual",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "NomeFantasia",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Pessoas");
        }
    }
}
