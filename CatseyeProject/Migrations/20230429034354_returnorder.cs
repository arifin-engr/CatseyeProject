using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class returnorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblToken_CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "tblProductdetails");

            migrationBuilder.DropColumn(
                name: "CatsTokenId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "TokenId",
                table: "tblOrder");

            migrationBuilder.AddColumn<int>(
                name: "CatsReturnReasonId",
                table: "tblOrder",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DamageFee",
                table: "tblOrder",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "tblOrder",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentToken",
                table: "tblOrder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReasonId",
                table: "tblOrder",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnSubmitDate",
                table: "tblOrder",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "tblReturnReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    FlatDamageFee = table.Column<float>(nullable: false),
                    PerDamageFee = table.Column<float>(nullable: false),
                    RefundShippingFeee = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblReturnReasons", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblReturnReasons_CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.DropTable(
                name: "tblReturnReasons");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "CatsReturnReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "DamageFee",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "PaymentToken",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "ReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "ReturnSubmitDate",
                table: "tblOrder");

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "tblProductdetails",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CatsTokenId",
                table: "tblOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TokenId",
                table: "tblOrder",
                type: "int",
                nullable: true);

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
        }
    }
}
