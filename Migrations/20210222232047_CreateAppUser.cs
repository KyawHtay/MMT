using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MMT.Migrations
{
    public partial class CreateAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ORDERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUSTOMERID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ORDERDATE = table.Column<DateTime>(type: "date", nullable: true),
                    DELIVERYEXPECTED = table.Column<DateTime>(type: "date", nullable: true),
                    CONTAINSGIFT = table.Column<bool>(type: "bit", nullable: true),
                    SHIPPINGMODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ORDERSOURCE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.ORDERID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    PRODUCTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRODUCTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PACKHEIGHT = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    PACKWIDTH = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    PACKWEIGHT = table.Column<decimal>(type: "decimal(8,3)", nullable: true),
                    COLOUR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SIZE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.PRODUCTID);
                });

            migrationBuilder.CreateTable(
                name: "ORDERITEMS",
                columns: table => new
                {
                    ORDERITEMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ORDERID = table.Column<int>(type: "int", nullable: true),
                    PRODUCTID = table.Column<int>(type: "int", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: true),
                    PRICE = table.Column<decimal>(type: "decimal(9,2)", nullable: true),
                    RETURNABLE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERITEMS", x => x.ORDERITEMID);
                    table.ForeignKey(
                        name: "FK__ORDERITEM__ORDER__60A75C0F",
                        column: x => x.ORDERID,
                        principalTable: "ORDERS",
                        principalColumn: "ORDERID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ORDERITEM__PRODU__619B8048",
                        column: x => x.PRODUCTID,
                        principalTable: "PRODUCTS",
                        principalColumn: "PRODUCTID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERITEMS_ORDERID",
                table: "ORDERITEMS",
                column: "ORDERID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERITEMS_PRODUCTID",
                table: "ORDERITEMS",
                column: "PRODUCTID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERITEMS");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");
        }
    }
}
