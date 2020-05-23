using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class blogname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "ConpanyName",
                table: "Blogs",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConpanyName",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Blogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
