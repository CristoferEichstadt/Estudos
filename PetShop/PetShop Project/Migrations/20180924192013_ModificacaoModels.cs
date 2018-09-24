using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop_Project.Migrations
{
    public partial class ModificacaoModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Subcategorias",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Subcategorias",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategorias_Categorias_CategoriaId",
                table: "Subcategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
