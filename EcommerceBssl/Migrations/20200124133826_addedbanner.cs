using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBssl.Migrations
{
    public partial class addedbanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "SubCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "SubCategories");
        }
    }
}
