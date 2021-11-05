using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "Text" },
                values: new object[] { new DateTime(2021, 11, 6, 2, 10, 40, 541, DateTimeKind.Local).AddTicks(40), "Если ты устал, то присядь" });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertDate",
                value: new DateTime(2021, 11, 6, 2, 10, 40, 543, DateTimeKind.Local).AddTicks(41));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Если ты устал, то присять");
        }
    }
}
