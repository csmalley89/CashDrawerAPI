using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashDrawerAPI.Migrations
{
    public partial class intialmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ledger",
                columns: table => new
                {
                    LedgerId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    ClosedDrawerBalance = table.Column<decimal>(nullable: false),
                    OpenDrawerBalance = table.Column<decimal>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false, defaultValueSql: "strftime('%Y-%m-%d %H:%M:%S')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledger", x => x.LedgerId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false, defaultValueSql: "strftime('%Y-%m-%d %H:%M:%S')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Cost = table.Column<decimal>(nullable: false),
                    IsTaxable = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItemId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItemId);
                    table.ForeignKey(
                        name: "FK_LineItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_OrderId",
                table: "LineItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_ProductId",
                table: "LineItem",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ledger");

            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
