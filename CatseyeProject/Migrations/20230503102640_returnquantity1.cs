using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class returnquantity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ReturnAmount",
                table: "tblOrder",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnAmount",
                table: "tblOrder");
        }
    }
}
