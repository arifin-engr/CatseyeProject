using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class returnquantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReturnQuantity",
                table: "tblOrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblCartDetails_CartId",
                table: "tblCartDetails",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCartDetails_productdetailsId",
                table: "tblCartDetails",
                column: "productdetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCartDetails_tblcarts_CartId",
                table: "tblCartDetails",
                column: "CartId",
                principalTable: "tblcarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblCartDetails_tblProductdetails_productdetailsId",
                table: "tblCartDetails",
                column: "productdetailsId",
                principalTable: "tblProductdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCartDetails_tblcarts_CartId",
                table: "tblCartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tblCartDetails_tblProductdetails_productdetailsId",
                table: "tblCartDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblCartDetails_CartId",
                table: "tblCartDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblCartDetails_productdetailsId",
                table: "tblCartDetails");

            migrationBuilder.DropColumn(
                name: "ReturnQuantity",
                table: "tblOrderDetails");
        }
    }
}
