using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class StudentbookLoans_Borrow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudId",
                table: "Bookloans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookloans_StudId",
                table: "Bookloans",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookloans_students_StudId",
                table: "Bookloans",
                column: "StudId",
                principalTable: "students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookloans_students_StudId",
                table: "Bookloans");

            migrationBuilder.DropIndex(
                name: "IX_Bookloans_StudId",
                table: "Bookloans");

            migrationBuilder.DropColumn(
                name: "StudId",
                table: "Bookloans");
        }
    }
}
