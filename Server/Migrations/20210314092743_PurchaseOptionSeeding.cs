using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class PurchaseOptionSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PurchaseOptions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bunch(Ripe)" },
                    { 2, "Bunch(Unripe)" },
                    { 3, "Cob" },
                    { 4, "Crate" },
                    { 5, "Kg" },
                    { 6, "Litres" },
                    { 7, "Units" },
                    { 8, "Units(Ripe)" },
                    { 9, "Units(Unripe)" }
                });

            migrationBuilder.InsertData(
                table: "ProductPurchaseOption",
                columns: new[] { "ProductsId", "PurchaseOptionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 8 },
                    { 1, 8 },
                    { 9, 7 },
                    { 8, 7 },
                    { 6, 7 },
                    { 5, 7 },
                    { 3, 7 },
                    { 2, 7 },
                    { 1, 7 },
                    { 4, 6 },
                    { 10, 6 },
                    { 9, 5 },
                    { 8, 5 },
                    { 7, 5 },
                    { 5, 5 },
                    { 2, 5 },
                    { 3, 4 },
                    { 2, 3 },
                    { 6, 2 },
                    { 1, 2 },
                    { 6, 1 },
                    { 1, 9 },
                    { 6, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PurchaseOptions",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
