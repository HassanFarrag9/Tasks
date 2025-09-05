using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class SubmissionStudent_Submit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "submissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_submissions_StudId",
                table: "submissions",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_submissions_students_StudId",
                table: "submissions",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_submissions_students_StudId",
                table: "submissions");

            migrationBuilder.DropIndex(
                name: "IX_submissions_StudId",
                table: "submissions");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "submissions");
        }
    }
}
