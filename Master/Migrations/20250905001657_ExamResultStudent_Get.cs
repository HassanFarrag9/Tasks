using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class ExamResultStudent_Get : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "examResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_examResults_StudId",
                table: "examResults",
                column: "StudId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_examResults_students_StudId",
                table: "examResults",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_examResults_students_StudId",
                table: "examResults");

            migrationBuilder.DropIndex(
                name: "IX_examResults_StudId",
                table: "examResults");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "examResults");
        }
    }
}
