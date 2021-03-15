using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class FixedProductVariantsIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "PurchaseOptionId", "OriginalPrice", "Price" },
                values: new object[] { 1, 10, 100m, 19.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "ProductId", "PurchaseOptionId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "PurchaseOptionId", "OriginalPrice", "Price" },
                values: new object[] { 1, 8, 100m, 19.99m });
        }
    }
}
