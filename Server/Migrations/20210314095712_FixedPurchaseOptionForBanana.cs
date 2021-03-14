﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class FixedPurchaseOptionForBanana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPurchaseOption",
                keyColumns: new[] { "ProductsId", "PurchaseOptionsId" },
                keyValues: new object[] { 1, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductPurchaseOption",
                columns: new[] { "ProductsId", "PurchaseOptionsId" },
                values: new object[] { 1, 7 });
        }
    }
}
