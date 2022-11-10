using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddAsiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstaLibre",
                table: "Asientos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Fila",
                table: "Asientos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroDeAsiento",
                table: "Asientos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaLibre",
                table: "Asientos");

            migrationBuilder.DropColumn(
                name: "Fila",
                table: "Asientos");

            migrationBuilder.DropColumn(
                name: "NumeroDeAsiento",
                table: "Asientos");
        }
    }
}
