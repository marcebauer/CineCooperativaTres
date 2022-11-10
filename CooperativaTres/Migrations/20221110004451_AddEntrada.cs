using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddEntrada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Asientos_AsientoId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Funciones_FuncionId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Usuarios_UsuarioId",
                table: "Entradas");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entradas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuncionId",
                table: "Entradas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AsientoId",
                table: "Entradas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Asientos_AsientoId",
                table: "Entradas",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Funciones_FuncionId",
                table: "Entradas",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Usuarios_UsuarioId",
                table: "Entradas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Asientos_AsientoId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Funciones_FuncionId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Usuarios_UsuarioId",
                table: "Entradas");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Entradas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FuncionId",
                table: "Entradas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AsientoId",
                table: "Entradas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Asientos_AsientoId",
                table: "Entradas",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Funciones_FuncionId",
                table: "Entradas",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Usuarios_UsuarioId",
                table: "Entradas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
