using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Add_TranslatorTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Translator",
                columns: table => new
                {
                    TranslatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translator", x => x.TranslatorID);
                });

            migrationBuilder.CreateTable(
                name: "Book_Translator",
                columns: table => new
                {
                    TranslatorID = table.Column<int>(nullable: false),
                    BookID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Translator", x => new { x.BookID, x.TranslatorID });
                    table.ForeignKey(
                        name: "FK_Book_Translator_BookInfo_BookID",
                        column: x => x.BookID,
                        principalTable: "BookInfo",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Translator_Translator_TranslatorID",
                        column: x => x.TranslatorID,
                        principalTable: "Translator",
                        principalColumn: "TranslatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Translator_TranslatorID",
                table: "Book_Translator",
                column: "TranslatorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Translator");

            migrationBuilder.DropTable(
                name: "Translator");
        }
    }
}
