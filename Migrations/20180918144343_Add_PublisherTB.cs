using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Add_PublisherTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublisherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_PublisherID",
                table: "BookInfo",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Publisher_PublisherID",
                table: "BookInfo",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Publisher_PublisherID",
                table: "BookInfo");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_PublisherID",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "BookInfo");
        }
    }
}
