using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.EFCoreApi.Data.migrations
{
    public partial class resolvendo_conflito_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_Discount_id",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Discount_id",
                table: "Products",
                newName: "DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Discount_id",
                table: "Products",
                newName: "IX_Products_DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_DiscountId",
                table: "Products",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Discounts_DiscountId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "DiscountId",
                table: "Products",
                newName: "Discount_id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DiscountId",
                table: "Products",
                newName: "IX_Products_Discount_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Discounts_Discount_id",
                table: "Products",
                column: "Discount_id",
                principalTable: "Discounts",
                principalColumn: "Id");
        }
    }
}
