using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApplication.Migrations
{
    public partial class BasketProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "BasketProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "BasketProducts",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "BasketProducts");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "BasketProducts");
        }
    }
}
