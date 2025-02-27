﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAPI.Migrations
{
    /// <inheritdoc />
    public partial class CategoriaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Produtos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Produtos",
                type: "TEXT",
                nullable: true);
        }
    }
}
