﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop_Project.Migrations
{
    public partial class AtualizacaoDeBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");
        }
    }
}
