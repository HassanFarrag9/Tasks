using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseEnrollments_enroll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_CourseId",
                table: "enrollments",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_enrollments_courses_CourseId",
                table: "enrollments",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enrollments_courses_CourseId",
                table: "enrollments");

            migrationBuilder.DropIndex(
                name: "IX_enrollments_CourseId",
                table: "enrollments");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "enrollments");
        }
    }
}
