using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class ManageRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerID",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_ManagerID",
                table: "departments",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_ManagerID",
                table: "departments",
                column: "ManagerID",
                principalTable: "employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_ManagerID",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_ManagerID",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "ManagerID",
                table: "departments");
        }
    }
}
