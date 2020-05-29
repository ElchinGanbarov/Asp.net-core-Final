using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class decina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PolicyActionText",
                table: "AboutPolicies");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "AboutPolicies",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "AboutPolicies");

            migrationBuilder.AddColumn<string>(
                name: "PolicyActionText",
                table: "AboutPolicies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
