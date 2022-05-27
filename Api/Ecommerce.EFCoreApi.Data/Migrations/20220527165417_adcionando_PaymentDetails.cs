using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.EFCoreApi.Data.migrations
{
    public partial class adcionando_PaymentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_Product_id",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Session_Session_Id",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Session_Id",
                table: "Cart",
                newName: "IX_Cart_Session_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_Product_id",
                table: "Cart",
                newName: "IX_Cart_Product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Payment Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_id = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Modified_At = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment Details", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Product_id",
                table: "Cart",
                column: "Product_id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Session_Session_Id",
                table: "Cart",
                column: "Session_Id",
                principalTable: "Session",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Product_id",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Session_Session_Id",
                table: "Cart");

            migrationBuilder.DropTable(
                name: "Payment Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Session_Id",
                table: "Carts",
                newName: "IX_Carts_Session_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_Product_id",
                table: "Carts",
                newName: "IX_Carts_Product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_Product_id",
                table: "Carts",
                column: "Product_id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Session_Session_Id",
                table: "Carts",
                column: "Session_Id",
                principalTable: "Session",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
