using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class DropFoundedYearForFootballClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoundedYear",
                table: "FootballClubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FoundedYear",
                table: "FootballClubs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
