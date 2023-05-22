using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class billingidinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillingId",
                table: "tblOrder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_BillingId",
                table: "tblOrder",
                column: "BillingId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblBilling_BillingId",
                table: "tblOrder",
                column: "BillingId",
                principalTable: "tblBilling",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblBilling_BillingId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_BillingId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "BillingId",
                table: "tblOrder");
        }
    }
}
