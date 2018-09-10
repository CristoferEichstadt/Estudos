using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop_Project.Migrations
{
    public partial class ModificandoTipoDePessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoPessoa",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoPessoa",
                table: "Pessoas",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
