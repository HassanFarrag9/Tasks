using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class InstructorDepartment_Belong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DeptId",
                table: "instructors",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_DeptId",
                table: "instructors",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_DeptId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DeptId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "instructors");
        }
    }
}
