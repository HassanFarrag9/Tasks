using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseScheduleClassRoom_Link : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "courseSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedules_ClassRoomId",
                table: "courseSchedules",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseSchedules_classrooms_ClassRoomId",
                table: "courseSchedules",
                column: "ClassRoomId",
                principalTable: "classrooms",
                principalColumn: "ClassroomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseSchedules_classrooms_ClassRoomId",
                table: "courseSchedules");

            migrationBuilder.DropIndex(
                name: "IX_courseSchedules_ClassRoomId",
                table: "courseSchedules");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "courseSchedules");
        }
    }
}
