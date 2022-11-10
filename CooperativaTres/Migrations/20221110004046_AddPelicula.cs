using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddPelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duracion",
                table: "Peliculas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeEstreno",
                table: "Peliculas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDesplazamiento",
                table: "Peliculas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Peliculas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracion",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "FechaDeEstreno",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "FechaDesplazamiento",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Peliculas");
        }
    }
}
