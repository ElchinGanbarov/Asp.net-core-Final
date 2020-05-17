using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ImagesId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "HomeSliders");

            migrationBuilder.AlterColumn<int>(
                name: "ImagesId",
                table: "HomeSliders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders");

            migrationBuilder.AlterColumn<int>(
                name: "ImagesId",
                table: "HomeSliders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "HomeSliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSliders_Images_ImagesId",
                table: "HomeSliders",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
