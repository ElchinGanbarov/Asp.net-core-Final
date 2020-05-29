using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class aaaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PolicyCount",
                table: "AboutPolicies",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PolicyActionText",
                table: "AboutPolicies",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PolicyCount",
                table: "AboutPolicies",
                type: "float",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyActionText",
                table: "AboutPolicies",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
