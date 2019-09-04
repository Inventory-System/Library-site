using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Delete_SubCategoriesTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_SubCategories_SCategoryID",
                table: "BookInfo");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.RenameColumn(
                name: "SCategoryID",
                table: "BookInfo",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_BookInfo_SCategoryID",
                table: "BookInfo",
                newName: "IX_BookInfo_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID1",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryID",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryID1",
                table: "Categories",
                column: "CategoryID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Categories_CategoryID",
                table: "BookInfo",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryID1",
                table: "Categories",
                column: "CategoryID1",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Categories_CategoryID",
                table: "BookInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryID1",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryID1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentCategoryID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "BookInfo",
                newName: "SCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_BookInfo_CategoryID",
                table: "BookInfo",
                newName: "IX_BookInfo_SCategoryID");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: true),
                    SubCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_SubCategories_SCategoryID",
                table: "BookInfo",
                column: "SCategoryID",
                principalTable: "SubCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
