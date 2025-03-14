using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotekarz.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterBookRemoveBorrowerConstrain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Borrowers_BorrowerId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BorrowerId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Borrowers_BorrowerId",
                table: "Books",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Borrowers_BorrowerId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "BorrowerId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Borrowers_BorrowerId",
                table: "Books",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
