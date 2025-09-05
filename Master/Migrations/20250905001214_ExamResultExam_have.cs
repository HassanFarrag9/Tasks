using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class ExamResultExam_have : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "examResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_examResults_ExamId",
                table: "examResults",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_examResults_exams_ExamId",
                table: "examResults",
                column: "ExamId",
                principalTable: "exams",
                principalColumn: "ExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_examResults_exams_ExamId",
                table: "examResults");

            migrationBuilder.DropIndex(
                name: "IX_examResults_ExamId",
                table: "examResults");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "examResults");
        }
    }
}
