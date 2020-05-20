using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 500, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    Experience = table.Column<string>(maxLength: 100, nullable: false),
                    ActionText = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikeableAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Experince = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false),
                    ActionText = table.Column<string>(maxLength: 50, nullable: false),
                    Photo = table.Column<string>(maxLength: 100, nullable: false),
                    AboutUsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeableAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikeableAreas_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    AboutUsId = table.Column<int>(nullable: false),
                    Review = table.Column<string>(maxLength: 500, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    WorkExperience = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Testimonials_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Text = table.Column<string>(type: "ntext", nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTexts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogTexts_BlogId",
                table: "BlogTexts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeableAreas_AboutUsId",
                table: "LikeableAreas",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_AboutUsId",
                table: "Testimonials",
                column: "AboutUsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTexts");

            migrationBuilder.DropTable(
                name: "LikeableAreas");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
