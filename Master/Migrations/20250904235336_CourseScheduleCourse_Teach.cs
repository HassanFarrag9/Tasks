using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseScheduleCourse_Teach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "courseSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedules_CourseId",
                table: "courseSchedules",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseSchedules_courses_CourseId",
                table: "courseSchedules",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseSchedules_courses_CourseId",
                table: "courseSchedules");

            migrationBuilder.DropIndex(
                name: "IX_courseSchedules_CourseId",
                table: "courseSchedules");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "courseSchedules");
        }
    }
}
