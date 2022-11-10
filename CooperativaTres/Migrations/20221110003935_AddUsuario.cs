using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Peliculas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Funciones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Entradas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Asientos",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeNacimiento",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsientoId",
                table: "Entradas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuncionId",
                table: "Entradas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Entradas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_AsientoId",
                table: "Entradas",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_FuncionId",
                table: "Entradas",
                column: "FuncionId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_UsuarioId",
                table: "Entradas",
                column: "UsuarioId");

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

            migrationBuilder.DropIndex(
                name: "IX_Entradas_AsientoId",
                table: "Entradas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_FuncionId",
                table: "Entradas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_UsuarioId",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaDeNacimiento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "AsientoId",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "FuncionId",
                table: "Entradas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Entradas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Peliculas",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funciones",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Entradas",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Asientos",
                newName: "ID");
        }
    }
}
