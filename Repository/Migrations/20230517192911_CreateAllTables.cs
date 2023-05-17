using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 23, 29, 10, 765, DateTimeKind.Local).AddTicks(5146));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 16, 56, 52, 900, DateTimeKind.Local).AddTicks(5807));
        }
    }
}
