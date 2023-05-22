using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class shippingidaddedinorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShippingId",
                table: "tblOrder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_ShippingId",
                table: "tblOrder",
                column: "ShippingId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblShipping_ShippingId",
                table: "tblOrder",
                column: "ShippingId",
                principalTable: "tblShipping",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblShipping_ShippingId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_ShippingId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "ShippingId",
                table: "tblOrder");
        }
    }
}
