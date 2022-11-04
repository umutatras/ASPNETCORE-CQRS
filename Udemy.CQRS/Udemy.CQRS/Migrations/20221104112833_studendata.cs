using Microsoft.EntityFrameworkCore.Migrations;

namespace Udemy.CQRS.Migrations
{
    public partial class studendata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[] { 1, 25, "Umut", "Atraş" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[] { 2, 23, "Bedia", "Atraş" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[] { 3, 33, "MEhmet", "İstanbullu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
