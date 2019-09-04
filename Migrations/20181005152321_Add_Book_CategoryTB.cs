using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Add_Book_CategoryTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Categories_CategoryID",
                table: "BookInfo");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_CategoryID",
                table: "BookInfo");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "BookInfo",
                newName: "PublishYear");

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Book_Category",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Category", x => new { x.BookID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_Book_Category_BookInfo_BookID",
                        column: x => x.BookID,
                        principalTable: "BookInfo",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Category_CategoryID",
                table: "Book_Category",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Category");

            migrationBuilder.DropColumn(
                name: "Delete",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "BookInfo");

            migrationBuilder.RenameColumn(
                name: "PublishYear",
                table: "BookInfo",
                newName: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_CategoryID",
                table: "BookInfo",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Categories_CategoryID",
                table: "BookInfo",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
