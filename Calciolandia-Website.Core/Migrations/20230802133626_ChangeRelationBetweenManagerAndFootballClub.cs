using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class ChangeRelationBetweenManagerAndFootballClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs");

            migrationBuilder.DropIndex(
                name: "IX_FootballClubs_ManagerId",
                table: "FootballClubs");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Managers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_FootballClubId",
                table: "Managers",
                column: "FootballClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_FootballClubs_FootballClubId",
                table: "Managers",
                column: "FootballClubId",
                principalTable: "FootballClubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_FootballClubs_FootballClubId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_FootballClubId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Managers");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Managers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id");
        }
    }
}
