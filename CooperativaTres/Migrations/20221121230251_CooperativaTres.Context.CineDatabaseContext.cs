using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class CooperativaTresContextCineDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fila = table.Column<int>(nullable: false),
                    NumeroDeAsiento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    DiaHorario = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsientosXFuncion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionId = table.Column<int>(nullable: false),
                    AsientoId = table.Column<int>(nullable: false),
                    EstaLibre = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosXFuncion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsientosXFuncion_Asientos_AsientoId",
                        column: x => x.AsientoId,
                        principalTable: "Asientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsientosXFuncion_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsientoId = table.Column<int>(nullable: false),
                    FuncionId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entradas_Asientos_AsientoId",
                        column: x => x.AsientoId,
                        principalTable: "Asientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entradas_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entradas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsientosXFuncion_AsientoId",
                table: "AsientosXFuncion",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsientosXFuncion_FuncionId",
                table: "AsientosXFuncion",
                column: "FuncionId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientosXFuncion");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
