using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class StudentDepartment_Belong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_DeptId",
                table: "students",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeptId",
                table: "students",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeptId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_DeptId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "students");
        }
    }
}
