using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUEX.Data.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teachers_TeacherInfoId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "TeacherInfos");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentInfos");

            migrationBuilder.RenameIndex(
                name: "IX_Students_UserId",
                table: "StudentInfos",
                newName: "IX_StudentInfos_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherInfos",
                table: "TeacherInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentInfos",
                table: "StudentInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Users_UserId",
                table: "StudentInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TeacherInfos_TeacherInfoId",
                table: "Users",
                column: "TeacherInfoId",
                principalTable: "TeacherInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Users_UserId",
                table: "StudentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_TeacherInfos_TeacherInfoId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherInfos",
                table: "TeacherInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentInfos",
                table: "StudentInfos");

            migrationBuilder.RenameTable(
                name: "TeacherInfos",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "StudentInfos",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfos_UserId",
                table: "Students",
                newName: "IX_Students_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teachers_TeacherInfoId",
                table: "Users",
                column: "TeacherInfoId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
