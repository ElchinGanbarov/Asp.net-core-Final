using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class testmonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_AboutUs_AboutUsId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_AboutUsId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "AboutUsId",
                table: "Testimonials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutUsId",
                table: "Testimonials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_AboutUsId",
                table: "Testimonials",
                column: "AboutUsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_AboutUs_AboutUsId",
                table: "Testimonials",
                column: "AboutUsId",
                principalTable: "AboutUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
