using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUEX.Data.Migrations
{
    public partial class ChangedCourseUsersAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCourses_Roles_RoleId",
                table: "UserCourses");

            migrationBuilder.DropIndex(
                name: "IX_UserCourses_RoleId",
                table: "UserCourses");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UserCourses");

            migrationBuilder.AddColumn<int>(
                name: "AccessType",
                table: "UserCourses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessType",
                table: "UserCourses");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "UserCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_RoleId",
                table: "UserCourses",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourses_Roles_RoleId",
                table: "UserCourses",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
