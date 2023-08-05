using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class AddFoundedYearForFootballClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoundedYear",
                table: "FootballClubs",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoundedYear",
                table: "FootballClubs");
        }
    }
}
