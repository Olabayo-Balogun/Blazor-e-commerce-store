using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPurchaseOption");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PurchaseOptionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.PurchaseOptionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_PurchaseOptions_PurchaseOptionId",
                        column: x => x.PurchaseOptionId,
                        principalTable: "PurchaseOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "PurchaseOptionId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 100m, 19.99m },
                    { 10, 7, 400m, 199.99m },
                    { 10, 1, 400m, 199.99m },
                    { 9, 8, 100m, 49.99m },
                    { 9, 6, 2000m, 1000m },
                    { 9, 1, 100m, 49.99m },
                    { 8, 8, 200m, 49.99m },
                    { 8, 6, 7000m, 1000m },
                    { 8, 1, 200m, 49.99m },
                    { 7, 6, 500m, 400m },
                    { 6, 9, 100m, 19.99m },
                    { 6, 3, 0m, 199.99m },
                    { 6, 2, 400m, 199.99m },
                    { 6, 1, 100m, 19.99m },
                    { 7, 1, 500m, 400m },
                    { 5, 6, 200m, 99.99m },
                    { 1, 2, 400m, 199.99m },
                    { 1, 3, 0m, 199.99m },
                    { 5, 8, 50m, 19.99m },
                    { 1, 9, 100m, 19.99m },
                    { 2, 1, 50m, 29.99m },
                    { 2, 4, 50m, 29.99m },
                    { 1, 8, 100m, 19.99m },
                    { 3, 5, 1200m, 719.76m },
                    { 3, 8, 50m, 29.99m },
                    { 4, 1, 200m, 99.99m },
                    { 4, 7, 200m, 99.99m },
                    { 5, 1, 50m, 19.99m },
                    { 2, 6, 200m, 99.99m }
                });

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bunch(Ripe)");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bunch(Unripe)");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Cob");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Crate");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Kg");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Litres");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Units");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Units(Ripe)");

            migrationBuilder.InsertData(
                table: "PurchaseOptions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Units(Unripe)" });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "PurchaseOptionId", "OriginalPrice", "Price" },
                values: new object[] { 6, 10, 100m, 19.99m });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_PurchaseOptionId",
                table: "ProductVariant",
                column: "PurchaseOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProductPurchaseOption",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    PurchaseOptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPurchaseOption", x => new { x.ProductsId, x.PurchaseOptionsId });
                    table.ForeignKey(
                        name: "FK_ProductPurchaseOption_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPurchaseOption_PurchaseOptions_PurchaseOptionsId",
                        column: x => x.PurchaseOptionsId,
                        principalTable: "PurchaseOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductPurchaseOption",
                columns: new[] { "ProductsId", "PurchaseOptionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 9 },
                    { 6, 8 },
                    { 1, 8 },
                    { 9, 7 },
                    { 8, 7 },
                    { 5, 7 },
                    { 3, 7 },
                    { 2, 7 },
                    { 4, 6 },
                    { 10, 6 },
                    { 1, 9 },
                    { 8, 5 },
                    { 9, 5 },
                    { 1, 2 },
                    { 6, 2 },
                    { 2, 3 },
                    { 6, 1 },
                    { 2, 5 },
                    { 5, 5 },
                    { 7, 5 },
                    { 3, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 100m, 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50m, 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50m, 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 200m, 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 50m, 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 100m, 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 500m, 399.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 200m, 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 100m, 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 400m, 199.99m });

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bunch(Ripe)");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Bunch(Unripe)");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Cob");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Crate");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Kg");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Litres");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Units");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Units(Ripe)");

            migrationBuilder.UpdateData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Units(Unripe)");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchaseOption_PurchaseOptionsId",
                table: "ProductPurchaseOption",
                column: "PurchaseOptionsId");
        }
    }
}
