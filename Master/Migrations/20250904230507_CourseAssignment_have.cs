using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseAssignment_have : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursetId",
                table: "assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_assignments_CoursetId",
                table: "assignments",
                column: "CoursetId");

            migrationBuilder.AddForeignKey(
                name: "FK_assignments_courses_CoursetId",
                table: "assignments",
                column: "CoursetId",
                principalTable: "courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assignments_courses_CoursetId",
                table: "assignments");

            migrationBuilder.DropIndex(
                name: "IX_assignments_CoursetId",
                table: "assignments");

            migrationBuilder.DropColumn(
                name: "CoursetId",
                table: "assignments");
        }
    }
}
