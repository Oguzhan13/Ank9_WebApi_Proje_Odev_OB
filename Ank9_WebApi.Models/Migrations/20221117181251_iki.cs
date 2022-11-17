using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank9_WebApi.Models.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 1,
                column: "TCKimlik",
                value: 12345);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 2,
                column: "TCKimlik",
                value: 12346);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 3,
                column: "TCKimlik",
                value: 12347);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 4,
                column: "TCKimlik",
                value: 12348);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 5,
                column: "TCKimlik",
                value: 12349);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 1,
                column: "TCKimlik",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 2,
                column: "TCKimlik",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 3,
                column: "TCKimlik",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 4,
                column: "TCKimlik",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiId",
                keyValue: 5,
                column: "TCKimlik",
                value: 0);
        }
    }
}
