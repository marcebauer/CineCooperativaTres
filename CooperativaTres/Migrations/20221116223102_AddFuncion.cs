using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddFuncion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DiaHorario",
                table: "Funciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Funciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funciones_Peliculas_PeliculaId",
                table: "Funciones",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funciones_Peliculas_PeliculaId",
                table: "Funciones");

            migrationBuilder.DropIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "DiaHorario",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Funciones");
        }
    }
}
