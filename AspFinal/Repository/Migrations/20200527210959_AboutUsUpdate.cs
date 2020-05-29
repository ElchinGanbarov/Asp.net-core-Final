using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AboutUsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClaimLogo",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaimSubtext",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaimSubtitle",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PolicyActionText",
                table: "AboutUs",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicyCount",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicySubText",
                table: "AboutUs",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicySubTitle",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimLogo",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "ClaimSubtext",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "ClaimSubtitle",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "PolicyActionText",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "PolicyCount",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "PolicySubText",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "PolicySubTitle",
                table: "AboutUs");
        }
    }
}
