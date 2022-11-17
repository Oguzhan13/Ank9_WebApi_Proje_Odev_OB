using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank9_WebApi.Models.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    KisiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCKimlik = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.KisiId);
                });

            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "KisiId", "Ad", "Cinsiyet", "DogumTarihi", "Soyad", "TCKimlik" },
                values: new object[,]
                {
                    { 1, "Ali", 0, new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılmaz", 0 },
                    { 2, "Burak", 0, new DateTime(1994, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılmaz", 0 },
                    { 3, "Canan", 1, new DateTime(1991, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şaşmaz", 0 },
                    { 4, "Derya", 1, new DateTime(2001, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demet", 0 },
                    { 5, "Erdi", 0, new DateTime(1997, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yaman", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
