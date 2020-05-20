using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class agents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Agents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agents_CategoryId",
                table: "Agents",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Categories_CategoryId",
                table: "Agents",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Categories_CategoryId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_CategoryId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Agents");
        }
    }
}
