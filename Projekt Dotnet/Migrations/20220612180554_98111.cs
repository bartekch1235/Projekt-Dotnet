using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_Dotnet.Migrations
{
    public partial class _98111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Zaginiecie",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Zaginiecie");
        }
    }
}
