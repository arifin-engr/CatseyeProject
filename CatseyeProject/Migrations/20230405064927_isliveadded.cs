using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class isliveadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Islive",
                table: "tblProduct",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Islive",
                table: "tblProduct");
        }
    }
}
