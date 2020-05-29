using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class aboutupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AboutClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ClaimSubtitle = table.Column<string>(maxLength: 50, nullable: false),
                    ClaimSubtext = table.Column<string>(maxLength: 100, nullable: false),
                    ClaimLogo = table.Column<string>(maxLength: 50, nullable: false),
                    AboutUsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutClaims_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    PolicyCount = table.Column<decimal>(maxLength: 50, nullable: false),
                    PolicySubTitle = table.Column<decimal>(maxLength: 50, nullable: false),
                    PolicySubText = table.Column<decimal>(maxLength: 100, nullable: false),
                    PolicyActionText = table.Column<decimal>(maxLength: 100, nullable: false),
                    AboutUsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutPolicies_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutClaims_AboutUsId",
                table: "AboutClaims",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutPolicies_AboutUsId",
                table: "AboutPolicies",
                column: "AboutUsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutClaims");

            migrationBuilder.DropTable(
                name: "AboutPolicies");

            migrationBuilder.AddColumn<string>(
                name: "ClaimLogo",
                table: "AboutUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaimSubtext",
                table: "AboutUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaimSubtitle",
                table: "AboutUs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PolicyActionText",
                table: "AboutUs",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicyCount",
                table: "AboutUs",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicySubText",
                table: "AboutUs",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PolicySubTitle",
                table: "AboutUs",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
