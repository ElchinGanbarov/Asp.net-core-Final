using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutUs_Images_ImagesId",
                table: "AboutUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Companies_CompanyId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Images_ImagesId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Images_ImagesId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_Images_ImagesId",
                table: "ContactUs");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Images_ImagesId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ImagesId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_HomeSliders_ImagesId",
                table: "HomeSliders");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_ImagesId",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ImagesId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CompanyId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ImagesId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AboutUs_ImagesId",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "AboutUs");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Posts",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "HomeSliders",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "HomeSliders",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "HomeSliders",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "HomeSliders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slogan",
                table: "HomeSliders",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ContactUs",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AboutUs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Logo = table.Column<string>(maxLength: 100, nullable: false),
                    CoverImage = table.Column<string>(maxLength: 100, nullable: false),
                    QueryNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    WorkTime = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "Slogan",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AboutUs");

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "HomeSliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "HomeSliders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "ContactUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "AboutUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagesId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agent_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_Agent_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ImagesId",
                table: "Posts",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSliders_ImagesId",
                table: "HomeSliders",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_ImagesId",
                table: "ContactUs",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ImagesId",
                table: "Contacts",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CompanyId",
                table: "Categories",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ImagesId",
                table: "Categories",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_ImagesId",
                table: "AboutUs",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Agent_ImagesId",
                table: "Agent",
                column: "ImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_AgentId",
                table: "Insurance",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CategoryId",
                table: "Insurance",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutUs_Images_ImagesId",
                table: "AboutUs",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Companies_CompanyId",
                table: "Categories",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Images_ImagesId",
                table: "Categories",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Images_ImagesId",
                table: "Contacts",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_Images_ImagesId",
                table: "ContactUs",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Images_ImagesId",
                table: "Posts",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
