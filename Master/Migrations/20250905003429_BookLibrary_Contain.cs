using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Master.Migrations
{
    /// <inheritdoc />
    public partial class BookLibrary_Contain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_books_LibraryId",
                table: "books",
                column: "LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_libraries_LibraryId",
                table: "books",
                column: "LibraryId",
                principalTable: "libraries",
                principalColumn: "LibraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_libraries_LibraryId",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_LibraryId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "books");
        }
    }
}
