using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class cartdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblcarts_tblProductdetails_ProductdetailsId",
                table: "tblcarts");

            migrationBuilder.DropIndex(
                name: "IX_tblcarts_ProductdetailsId",
                table: "tblcarts");

            migrationBuilder.DropColumn(
                name: "ProductdetailsId",
                table: "tblcarts");

            migrationBuilder.AddColumn<int>(
                name: "CatsProductdetailsId",
                table: "tblcarts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblcarts_CatsProductdetailsId",
                table: "tblcarts",
                column: "CatsProductdetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblcarts_tblProductdetails_CatsProductdetailsId",
                table: "tblcarts",
                column: "CatsProductdetailsId",
                principalTable: "tblProductdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblcarts_tblProductdetails_CatsProductdetailsId",
                table: "tblcarts");

            migrationBuilder.DropIndex(
                name: "IX_tblcarts_CatsProductdetailsId",
                table: "tblcarts");

            migrationBuilder.DropColumn(
                name: "CatsProductdetailsId",
                table: "tblcarts");

            migrationBuilder.AddColumn<int>(
                name: "ProductdetailsId",
                table: "tblcarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblcarts_ProductdetailsId",
                table: "tblcarts",
                column: "ProductdetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblcarts_tblProductdetails_ProductdetailsId",
                table: "tblcarts",
                column: "ProductdetailsId",
                principalTable: "tblProductdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
