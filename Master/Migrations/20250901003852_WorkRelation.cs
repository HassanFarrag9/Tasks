using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class WorkRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employees_DeptId",
                table: "employees",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DeptId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "employees");
        }
    }
}
