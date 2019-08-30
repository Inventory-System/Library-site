using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Add_TranslatorProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translator_BookInfo_BookID",
                table: "Book_Translator");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translator_Translator_TranslatorID",
                table: "Book_Translator");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_BookInfo_BookID",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Categories_CategoryID",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Translator",
                table: "Book_Translator");

            migrationBuilder.DropColumn(
                name: "NummOFPage",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "Wieght",
                table: "BookInfo");

            migrationBuilder.RenameTable(
                name: "BookCategory",
                newName: "Book_Categories");

            migrationBuilder.RenameTable(
                name: "Book_Translator",
                newName: "Book_Translators");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategory_CategoryID",
                table: "Book_Categories",
                newName: "IX_Book_Categories_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Translator_TranslatorID",
                table: "Book_Translators",
                newName: "IX_Book_Translators_TranslatorID");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherID",
                table: "BookInfo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPublish",
                table: "BookInfo",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories",
                columns: new[] { "BookID", "CategoryID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Translators",
                table: "Book_Translators",
                columns: new[] { "BookID", "TranslatorID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Categories_BookInfo_BookID",
                table: "Book_Categories",
                column: "BookID",
                principalTable: "BookInfo",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Categories_Categories_CategoryID",
                table: "Book_Categories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Translators_BookInfo_BookID",
                table: "Book_Translators",
                column: "BookID",
                principalTable: "BookInfo",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Translators_Translator_TranslatorID",
                table: "Book_Translators",
                column: "TranslatorID",
                principalTable: "Translator",
                principalColumn: "TranslatorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_BookInfo_BookID",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_Categories_CategoryID",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translators_BookInfo_BookID",
                table: "Book_Translators");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translators_Translator_TranslatorID",
                table: "Book_Translators");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Translators",
                table: "Book_Translators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories");

            migrationBuilder.RenameTable(
                name: "Book_Translators",
                newName: "Book_Translator");

            migrationBuilder.RenameTable(
                name: "Book_Categories",
                newName: "BookCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Translators_TranslatorID",
                table: "Book_Translator",
                newName: "IX_Book_Translator_TranslatorID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Categories_CategoryID",
                table: "BookCategory",
                newName: "IX_BookCategory_CategoryID");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherID",
                table: "BookInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsPublish",
                table: "BookInfo",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NummOFPage",
                table: "BookInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "Wieght",
                table: "BookInfo",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Translator",
                table: "Book_Translator",
                columns: new[] { "BookID", "TranslatorID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory",
                columns: new[] { "BookID", "CategoryID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Translator_BookInfo_BookID",
                table: "Book_Translator",
                column: "BookID",
                principalTable: "BookInfo",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Translator_Translator_TranslatorID",
                table: "Book_Translator",
                column: "TranslatorID",
                principalTable: "Translator",
                principalColumn: "TranslatorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_BookInfo_BookID",
                table: "BookCategory",
                column: "BookID",
                principalTable: "BookInfo",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Categories_CategoryID",
                table: "BookCategory",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
