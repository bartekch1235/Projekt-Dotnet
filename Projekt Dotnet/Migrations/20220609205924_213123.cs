using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Dotnet.Migrations
{
    public partial class _213123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Harmonogram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HowManyDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HowManyHours = table.Column<int>(type: "int", nullable: false),
                    Duties = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harmonogram", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Harmonogram");
        }
    }
}
