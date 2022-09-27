using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPc.Migrations
{
    public partial class Marcas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "marcas",
                newName: "Fabricante");

            migrationBuilder.AlterColumn<string>(
                name: "Almacenamiento",
                table: "marcas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "ModeloID",
                table: "marcas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModeloID",
                table: "marcas");

            migrationBuilder.RenameColumn(
                name: "Fabricante",
                table: "marcas",
                newName: "Modelo");

            migrationBuilder.AlterColumn<string>(
                name: "Almacenamiento",
                table: "marcas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
