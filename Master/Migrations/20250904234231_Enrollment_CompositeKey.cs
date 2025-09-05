using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class Enrollment_CompositeKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_enrollments",
                table: "enrollments");

            migrationBuilder.DropIndex(
                name: "IX_enrollments_StudId",
                table: "enrollments");

            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "enrollments",
                newName: "EnrollmentNum");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enrollments",
                table: "enrollments",
                columns: new[] { "StudId", "CourseId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_enrollments",
                table: "enrollments");

            migrationBuilder.RenameColumn(
                name: "EnrollmentNum",
                table: "enrollments",
                newName: "EnrollmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enrollments",
                table: "enrollments",
                columns: new[] { "EnrollmentID", "StudId", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_StudId",
                table: "enrollments",
                column: "StudId");
        }
    }
}
