using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class SubmissionAssignment_Submit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "submissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_submissions_AssignmentId",
                table: "submissions",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_submissions_assignments_AssignmentId",
                table: "submissions",
                column: "AssignmentId",
                principalTable: "assignments",
                principalColumn: "AssignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_submissions_assignments_AssignmentId",
                table: "submissions");

            migrationBuilder.DropIndex(
                name: "IX_submissions_AssignmentId",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "submissions");
        }
    }
}
