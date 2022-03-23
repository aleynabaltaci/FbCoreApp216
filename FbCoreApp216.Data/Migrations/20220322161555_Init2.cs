using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FbCoreApp216.Data.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "tblProducts",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tblProducts",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "tblCategories",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tblCategories",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(1009), null });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(1011), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(882), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(896), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(898), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(900), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(901), null });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 15, 55, 761, DateTimeKind.Local).AddTicks(903), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "tblProducts",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tblProducts",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "tblCategories",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "tblCategories",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8171), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedTime" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 13, 13, 787, DateTimeKind.Local).AddTicks(8173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
