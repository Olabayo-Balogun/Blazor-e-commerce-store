using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacOnlineStore.Server.Migrations
{
    public partial class PurchaseOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOptions", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductPurchaseOption_PurchaseOptionsId",
                table: "ProductPurchaseOption",
                column: "PurchaseOptionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPurchaseOption");

            migrationBuilder.DropTable(
                name: "PurchaseOptions");
        }
    }
}
