using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class RemoveNonUsableFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PresidentId",
                table: "Presidents");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "FootballClubs");

            migrationBuilder.DropColumn(
                name: "PresidentId",
                table: "FootballClubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PresidentId",
                table: "Presidents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Managers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PresidentId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
