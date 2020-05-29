using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class @case : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseStudiesSingles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Subtitle = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "ntext", nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudiesSingles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseStudiesSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Key = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    CaseStudiesSingleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudiesSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseStudiesSpecs_CaseStudiesSingles_CaseStudiesSingleId",
                        column: x => x.CaseStudiesSingleId,
                        principalTable: "CaseStudiesSingles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseStudiesSpecs_CaseStudiesSingleId",
                table: "CaseStudiesSpecs",
                column: "CaseStudiesSingleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseStudiesSpecs");

            migrationBuilder.DropTable(
                name: "CaseStudiesSingles");
        }
    }
}
