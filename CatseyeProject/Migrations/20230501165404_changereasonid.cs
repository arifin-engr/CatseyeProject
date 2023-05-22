using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class changereasonid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblReturnReasons_ReasonId",
                table: "tblOrder");

            migrationBuilder.DropIndex(
                name: "IX_tblOrder_ReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "DamageFee",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "ReasonId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "ReturnSubmitDate",
                table: "tblOrder");

            migrationBuilder.AddColumn<float>(
                name: "DamageFee",
                table: "tblOrderDetails",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "tblOrderDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ReasonId",
                table: "tblOrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnSubmitDate",
                table: "tblOrderDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderDetails_ReasonId",
                table: "tblOrderDetails",
                column: "ReasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderDetails_tblReturnReasons_ReasonId",
                table: "tblOrderDetails",
                column: "ReasonId",
                principalTable: "tblReturnReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderDetails_tblReturnReasons_ReasonId",
                table: "tblOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_tblOrderDetails_ReasonId",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "DamageFee",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "ReasonId",
                table: "tblOrderDetails");

            migrationBuilder.DropColumn(
                name: "ReturnSubmitDate",
                table: "tblOrderDetails");

            migrationBuilder.AddColumn<float>(
                name: "DamageFee",
                table: "tblOrder",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "tblOrder",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ReasonId",
                table: "tblOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnSubmitDate",
                table: "tblOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
