using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class CourseDepartment_Belong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courses_DepartmentId",
                table: "courses",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_departments_DepartmentId",
                table: "courses",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_departments_DepartmentId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_DepartmentId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "courses");
        }
    }
}
