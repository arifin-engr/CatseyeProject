using Microsoft.EntityFrameworkCore.Migrations;

namespace CatseyeProject.Migrations
{
    public partial class uptodate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblSubCategory_tblproductTypes_CatsproductTypeId",
                table: "tblSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_tblSubCategory_CatsproductTypeId",
                table: "tblSubCategory");

            migrationBuilder.DropColumn(
                name: "CatsproductTypeId",
                table: "tblSubCategory");

            migrationBuilder.AddColumn<int>(
                name: "catsProductSubCategoriesId",
                table: "tblproductTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblSubCategory_CategoryId",
                table: "tblSubCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblproductTypes_catsProductSubCategoriesId",
                table: "tblproductTypes",
                column: "catsProductSubCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblproductTypes_tblSubCategory_catsProductSubCategoriesId",
                table: "tblproductTypes",
                column: "catsProductSubCategoriesId",
                principalTable: "tblSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSubCategory_tblProductCategory_CategoryId",
                table: "tblSubCategory",
                column: "CategoryId",
                principalTable: "tblProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblproductTypes_tblSubCategory_catsProductSubCategoriesId",
                table: "tblproductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSubCategory_tblProductCategory_CategoryId",
                table: "tblSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_tblSubCategory_CategoryId",
                table: "tblSubCategory");

            migrationBuilder.DropIndex(
                name: "IX_tblproductTypes_catsProductSubCategoriesId",
                table: "tblproductTypes");

            migrationBuilder.DropColumn(
                name: "catsProductSubCategoriesId",
                table: "tblproductTypes");

            migrationBuilder.AddColumn<int>(
                name: "CatsproductTypeId",
                table: "tblSubCategory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblSubCategory_CatsproductTypeId",
                table: "tblSubCategory",
                column: "CatsproductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblSubCategory_tblproductTypes_CatsproductTypeId",
                table: "tblSubCategory",
                column: "CatsproductTypeId",
                principalTable: "tblproductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
