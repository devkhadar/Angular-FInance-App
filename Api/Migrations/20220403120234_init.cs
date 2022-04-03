using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finance_Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginAdmin",
                columns: table => new
                {
                    userName = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    accPassword = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false),
                    productName = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    productDetails = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__2D10D16AABEB7ADC", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "UserRegistration",
                columns: table => new
                {
                    email = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    fullName = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    dob = table.Column<DateTime>(type: "date", nullable: true),
                    phoneNumber = table.Column<decimal>(type: "numeric(10, 0)", nullable: false),
                    userName = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    accPassword = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    confirmPassword = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    homeAddress = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    cardType = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    bankName = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    accountNumber = table.Column<decimal>(type: "numeric(20, 0)", nullable: false),
                    ifscCode = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRegi__AB6E6165FA71D0E6", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "EmiCard",
                columns: table => new
                {
                    emiCardNumber = table.Column<long>(nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    cardType = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    totalCredit = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    creditUsed = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 30, nullable: true, defaultValueSql: "('UNAPPROVED')"),
                    validTill = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EmiCard__FE8A004DAF8CD574", x => x.emiCardNumber);
                    table.ForeignKey(
                        name: "FK__EmiCard__email__571DF1D5",
                        column: x => x.email,
                        principalTable: "UserRegistration",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    quantity = table.Column<int>(nullable: true),
                    productid = table.Column<int>(nullable: true),
                    totalCost = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    emiTenure = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__0809335D26AE0679", x => x.orderId);
                    table.ForeignKey(
                        name: "FK__Orders__email__4E88ABD4",
                        column: x => x.email,
                        principalTable: "UserRegistration",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Orders__producti__4F7CD00D",
                        column: x => x.productid,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmiCard_email",
                table: "EmiCard",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_email",
                table: "Orders",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_productid",
                table: "Orders",
                column: "productid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmiCard");

            migrationBuilder.DropTable(
                name: "LoginAdmin");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UserRegistration");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
