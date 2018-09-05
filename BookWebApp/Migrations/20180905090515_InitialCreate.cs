using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Slug = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Isbn10 = table.Column<string>(nullable: true),
                    Isbn13 = table.Column<string>(nullable: true),
                    PageCount = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true),
                    InfoLink = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
