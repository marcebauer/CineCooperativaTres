using Microsoft.EntityFrameworkCore.Migrations;

namespace CooperativaTres.Migrations
{
    public partial class AddAsientosXFuncion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsientosXFuncion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionId = table.Column<int>(nullable: false),
                    AsientoId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_AsientosXFuncion_AsientoId",
                table: "AsientosXFuncion",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsientosXFuncion_FuncionId",
                table: "AsientosXFuncion",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientosXFuncion");
        }
    }
}
