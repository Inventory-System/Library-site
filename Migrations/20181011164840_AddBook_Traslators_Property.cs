using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class AddBook_Traslators_Property : Migration
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
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Translator",
                table: "Book_Translator");

            migrationBuilder.RenameTable(
                name: "Book_Translator",
                newName: "Book_Translators");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Translators",
                table: "Book_Translators",
                columns: new[] { "BookID", "TranslatorID" });

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

            migrationBuilder.RenameTable(
                name: "Book_Translators",
                newName: "Book_Translator");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Translators_TranslatorID",
                table: "Book_Translator",
                newName: "IX_Book_Translator_TranslatorID");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherID",
                table: "BookInfo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Translator",
                table: "Book_Translator",
                columns: new[] { "BookID", "TranslatorID" });

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
                name: "FK_BookInfo_Publishers_PublisherID",
                table: "BookInfo",
                column: "PublisherID",
                principalTable: "Publishers",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
