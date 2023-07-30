using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class ChangeForeignKeysNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs");

            migrationBuilder.DropIndex(
                name: "IX_FootballClubs_ManagerId",
                table: "FootballClubs");

            migrationBuilder.DropIndex(
                name: "IX_FootballClubs_OwnerId",
                table: "FootballClubs");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Owners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Managers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs");

            migrationBuilder.DropIndex(
                name: "IX_FootballClubs_ManagerId",
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

            migrationBuilder.AlterColumn<int>(
                name: "FootballClubId",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OwnerId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "FootballClubs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballClubs_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Managers_ManagerId",
                table: "FootballClubs",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FootballClubs_Owners_OwnerId",
                table: "FootballClubs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
