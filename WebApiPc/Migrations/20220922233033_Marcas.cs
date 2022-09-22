using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPc.Migrations
{
    public partial class Marcas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Computadoras");

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    SO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Almacenamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    computadoraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_marcas_Computadoras_computadoraId",
                        column: x => x.computadoraId,
                        principalTable: "Computadoras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_marcas_computadoraId",
                table: "marcas",
                column: "computadoraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Computadoras",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
