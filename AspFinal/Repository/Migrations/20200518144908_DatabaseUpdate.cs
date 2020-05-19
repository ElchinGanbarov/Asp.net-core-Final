using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email1",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Email2",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "PhoneNum1",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "PhoneNum2",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "GracePeriod",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MaxPayment",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MinPayment",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NumberPeople",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PolicyModification",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Support",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkTime",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CategorySpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategorySpecs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecs_CategoryId",
                table: "CategorySpecs",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorySpecs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "WorkTime",
                table: "ContactUs");

            migrationBuilder.AddColumn<string>(
                name: "Email1",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EndDate",
                table: "ContactUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndTime",
                table: "ContactUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNum1",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNum2",
                table: "ContactUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StartDate",
                table: "ContactUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartTime",
                table: "ContactUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GracePeriod",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MaxPayment",
                table: "Categories",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MinPayment",
                table: "Categories",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "NumberPeople",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PolicyModification",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Support",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
