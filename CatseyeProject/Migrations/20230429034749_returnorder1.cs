using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class returnorder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblReturnReasons_CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_ReasonId",
                table: "tblOrder",
                column: "ReasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblReturnReasons_ReasonId",
                table: "tblOrder",
                column: "ReasonId",
                principalTable: "tblReturnReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblReturnReasons_ReasonId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_ReasonId",
                table: "tblOrder");

            migrationBuilder.AddColumn<int>(
                name: "CatsReturnReasonId",
                table: "tblOrder",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrder_CatsReturnReasonId",
                table: "tblOrder",
                column: "CatsReturnReasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblReturnReasons_CatsReturnReasonId",
                table: "tblOrder",
                column: "CatsReturnReasonId",
                principalTable: "tblReturnReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
