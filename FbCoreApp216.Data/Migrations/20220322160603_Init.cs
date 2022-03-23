using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FbCoreApp216.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InnerBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblProducts_tblCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tblCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblCategories",
                columns: new[] { "ID", "CategoryName", "CreatedBy", "CreatedDate", "IsDeleted", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, "Kalemler", 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8669), false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "tblCategories",
                columns: new[] { "ID", "CategoryName", "CreatedBy", "CreatedDate", "IsDeleted", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 2, "Defterler", 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8671), false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "ID", "CategoryID", "CreatedBy", "CreatedDate", "InnerBarcode", "IsDeleted", "Price", "ProductName", "Stock", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8509), "", false, 125.75m, "Dolma Kalem", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8547), "", false, 55.25m, "Tükenmez Kalem", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8548), "", false, 5.5m, "Kurşun Kalem", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8550), "", false, 15.5m, "Kareli Defter", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8551), "", false, 12.5m, "Çizgili Defter", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 1, new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8552), "", false, 10.95m, "Çizgisiz Defter", 100, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblProducts_CategoryID",
                table: "tblProducts",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProducts");

            migrationBuilder.DropTable(
                name: "tblCategories");
        }
    }
}
