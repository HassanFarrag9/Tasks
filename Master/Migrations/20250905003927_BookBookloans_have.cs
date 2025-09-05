using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class BookBookloans_have : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Bookloans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookloans_BookId",
                table: "Bookloans",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookloans_books_BookId",
                table: "Bookloans",
                column: "BookId",
                principalTable: "books",
                principalColumn: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookloans_books_BookId",
                table: "Bookloans");

            migrationBuilder.DropIndex(
                name: "IX_Bookloans_BookId",
                table: "Bookloans");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Bookloans");
        }
    }
}
