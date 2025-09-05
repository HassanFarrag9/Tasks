using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseExam_have : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_exams_CourseId",
                table: "exams",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_courses_CourseId",
                table: "exams",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exams_courses_CourseId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_CourseId",
                table: "exams");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "exams");
        }
    }
}
