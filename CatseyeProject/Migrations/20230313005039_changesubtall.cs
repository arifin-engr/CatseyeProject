using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class changesubtall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Subtotal",
                table: "tblOrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Subtotal",
                table: "tblOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
