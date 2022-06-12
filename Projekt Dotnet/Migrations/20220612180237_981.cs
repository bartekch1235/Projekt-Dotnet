using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Dotnet.Migrations
{
    public partial class _981 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "People",
                table: "Harmonogram",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "People",
                table: "Harmonogram");
        }
    }
}
