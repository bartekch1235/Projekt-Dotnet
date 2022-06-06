using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Dotnet.Migrations
{
    public partial class _11111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogloszenie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gatunek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wiek = table.Column<int>(type: "int", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogloszenie", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogloszenie");
        }
    }
}
