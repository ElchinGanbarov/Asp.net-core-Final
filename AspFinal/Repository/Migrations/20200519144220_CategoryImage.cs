using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class CategoryImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
