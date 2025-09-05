using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class StudentAssignment_Submit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_assignments_StudId",
                table: "assignments",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_assignments_students_StudId",
                table: "assignments",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assignments_students_StudId",
                table: "assignments");

            migrationBuilder.DropIndex(
                name: "IX_assignments_StudId",
                table: "assignments");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "assignments");
        }
    }
}
