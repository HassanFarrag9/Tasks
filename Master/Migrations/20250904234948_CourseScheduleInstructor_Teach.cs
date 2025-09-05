using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseScheduleInstructor_Teach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "courseSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedules_InsId",
                table: "courseSchedules",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseSchedules_instructors_InsId",
                table: "courseSchedules",
                column: "InsId",
                principalTable: "instructors",
                principalColumn: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseSchedules_instructors_InsId",
                table: "courseSchedules");

            migrationBuilder.DropIndex(
                name: "IX_courseSchedules_InsId",
                table: "courseSchedules");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "courseSchedules");
        }
    }
}
