using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUEX.Data.Migrations
{
    public partial class ChangeUserInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Users_UserId",
                table: "StudentInfos");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfos_UserId",
                table: "StudentInfos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "StudentInfos");

            migrationBuilder.AddColumn<int>(
                name: "StudentInfoId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentInfoId",
                table: "Users",
                column: "StudentInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StudentInfos_StudentInfoId",
                table: "Users",
                column: "StudentInfoId",
                principalTable: "StudentInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_StudentInfos_StudentInfoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StudentInfoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudentInfoId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "StudentInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_UserId",
                table: "StudentInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Users_UserId",
                table: "StudentInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
