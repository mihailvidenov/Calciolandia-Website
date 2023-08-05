using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class ChangeRelationBetweenOwnerAndFootballClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs");

            migrationBuilder.DropIndex(
                name: "IX_FootballClubs_OwnerId",
                table: "FootballClubs");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_FootballClubId",
                table: "Owners",
                column: "FootballClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_FootballClubs_FootballClubId",
                table: "Owners",
                column: "FootballClubId",
                principalTable: "FootballClubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_FootballClubs_FootballClubId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_FootballClubId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Owners");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Owners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                unique: true,
                filter: "[OwnerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }
    }
}
