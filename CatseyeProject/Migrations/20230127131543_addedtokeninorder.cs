using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class addedtokeninorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderDetails_tblOrder_CatsOrderId",
                table: "tblOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderDetails_tblOrderDetails_catsorderDetailsId",
                table: "tblOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderDetails_CatsOrderId",
                table: "tblOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderDetails_catsorderDetailsId",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "CatsOrderId",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "catsorderDetailsId",
                table: "tblOrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "CatsTokenId",
                table: "tblOrder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TokenId",
                table: "tblOrder",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_OrderId",
                table: "tblOrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CatsTokenId",
                table: "tblOrder",
                column: "CatsTokenId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblToken_CatsTokenId",
                table: "tblOrder",
                column: "CatsTokenId",
                principalTable: "tblToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderDetails_tblOrder_OrderId",
                table: "tblOrderDetails",
                column: "OrderId",
                principalTable: "tblOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblToken_CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderDetails_tblOrder_OrderId",
                table: "tblOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderDetails_OrderId",
                table: "tblOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "TokenId",
                table: "tblOrder");

            migrationBuilder.AddColumn<int>(
                name: "CatsOrderId",
                table: "tblOrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catsorderDetailsId",
                table: "tblOrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_CatsOrderId",
                table: "tblOrderDetails",
                column: "CatsOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_catsorderDetailsId",
                table: "tblOrderDetails",
                column: "catsorderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderDetails_tblOrder_CatsOrderId",
                table: "tblOrderDetails",
                column: "CatsOrderId",
                principalTable: "tblOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderDetails_tblOrderDetails_catsorderDetailsId",
                table: "tblOrderDetails",
                column: "catsorderDetailsId",
                principalTable: "tblOrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
