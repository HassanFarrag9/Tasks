using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class InstructorDepartment_Manage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_ManagerId",
                table: "departments",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_instructors_ManagerId",
                table: "departments",
                column: "ManagerId",
                principalTable: "instructors",
                principalColumn: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_instructors_ManagerId",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_ManagerId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "departments");
        }
    }
}
