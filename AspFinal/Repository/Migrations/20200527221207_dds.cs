using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class dds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PolicyCount",
                table: "AboutPolicies",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PolicyCount",
                table: "AboutPolicies",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 50);
        }
    }
}
