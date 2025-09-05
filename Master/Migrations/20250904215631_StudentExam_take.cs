using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class StudentExam_take : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_exams_StudId",
                table: "exams",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_students_StudId",
                table: "exams",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exams_students_StudId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_StudId",
                table: "exams");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "exams");
        }
    }
}
