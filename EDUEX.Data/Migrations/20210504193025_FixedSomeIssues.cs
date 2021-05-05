using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUEX.Data.Migrations
{
    public partial class FixedSomeIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWebinars_Courses_WebinarId",
                table: "UserWebinars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Webinars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Webinars",
                table: "Webinars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWebinars_Webinars_WebinarId",
                table: "UserWebinars",
                column: "WebinarId",
                principalTable: "Webinars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserWebinars_Webinars_WebinarId",
                table: "UserWebinars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Webinars",
                table: "Webinars");

            migrationBuilder.RenameTable(
                name: "Webinars",
                newName: "Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserWebinars_Courses_WebinarId",
                table: "UserWebinars",
                column: "WebinarId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
