using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class billingshippingNamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "tblShipping");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tblBilling");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "tblShipping",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "tblShipping",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "tblBilling",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "tblBilling",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "tblShipping");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "tblShipping");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "tblBilling");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "tblBilling");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tblShipping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tblBilling",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
