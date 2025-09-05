using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class StudentEnrollments_enroll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_StudId",
                table: "enrollments",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_enrollments_students_StudId",
                table: "enrollments",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enrollments_students_StudId",
                table: "enrollments");

            migrationBuilder.DropIndex(
                name: "IX_enrollments_StudId",
                table: "enrollments");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "enrollments");
        }
    }
}
