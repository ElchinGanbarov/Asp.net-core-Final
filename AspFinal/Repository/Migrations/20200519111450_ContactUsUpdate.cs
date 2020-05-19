using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ContactUsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "HeadTitle",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "WorkTime",
                table: "ContactUs");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ContactUs");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeadTitle",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkTime",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
