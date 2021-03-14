using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class FixedProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 9, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "PurchaseOptionId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 100m, 19.99m },
                    { 2, 1, 50m, 29.99m },
                    { 5, 1, 50m, 19.99m },
                    { 6, 1, 100m, 19.99m },
                    { 8, 1, 200m, 49.99m },
                    { 9, 1, 100m, 49.99m }
                });
        }
    }
}
