using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class AddFootballClubIdForUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FootballClubId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FootballClubId",
                table: "AspNetUsers",
                column: "FootballClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_FootballClubs_FootballClubId",
                table: "AspNetUsers",
                column: "FootballClubId",
                principalTable: "FootballClubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_FootballClubs_FootballClubId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FootballClubId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FootballClubId",
                table: "AspNetUsers");
        }
    }
}
