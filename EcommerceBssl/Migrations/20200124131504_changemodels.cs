using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBssl.Migrations
{
    public partial class changemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColour_Colours_ColourId1",
                table: "ProductColour");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColour_Products_ProductId1",
                table: "ProductColour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColour",
                table: "ProductColour");

            migrationBuilder.RenameTable(
                name: "ProductColour",
                newName: "ProductColours");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColour_ProductId1",
                table: "ProductColours",
                newName: "IX_ProductColours_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColour_ColourId1",
                table: "ProductColours",
                newName: "IX_ProductColours_ColourId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColours",
                table: "ProductColours",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Colours_ColourId1",
                table: "ProductColours",
                column: "ColourId1",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColours_Products_ProductId1",
                table: "ProductColours",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Colours_ColourId1",
                table: "ProductColours");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColours_Products_ProductId1",
                table: "ProductColours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColours",
                table: "ProductColours");

            migrationBuilder.RenameTable(
                name: "ProductColours",
                newName: "ProductColour");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColours_ProductId1",
                table: "ProductColour",
                newName: "IX_ProductColour_ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColours_ColourId1",
                table: "ProductColour",
                newName: "IX_ProductColour_ColourId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColour",
                table: "ProductColour",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColour_Colours_ColourId1",
                table: "ProductColour",
                column: "ColourId1",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColour_Products_ProductId1",
                table: "ProductColour",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
