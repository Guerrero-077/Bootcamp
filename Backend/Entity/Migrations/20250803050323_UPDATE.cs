using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class UPDATE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Resistance",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resistance",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resistance",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resistance",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resistance",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Resistance",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resistance",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resistance",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Resistance",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resistance",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resistance",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Resistance",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Resistance",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Resistance",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Resistance",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Resistance",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Resistance",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Resistance",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Resistance",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Resistance",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Resistance",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "Resistance",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "Resistance",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "Resistance",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "Resistance",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "Resistance",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 66, 60 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 70, 63 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 74, 66 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 78, 69 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 82, 72 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 86, 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 90, 62 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 61, 65 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 65, 68 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 69, 71 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 73, 74 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 77, 77 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 81, 80 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 85, 83 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 89, 66 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 93, 69 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 66, 72 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 70, 75 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 74, 78 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 78, 81 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 82, 84 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 86, 87 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 90, 70 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 62, 73 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 66, 76 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 70, 79 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 74, 82 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 78, 85 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 82, 88 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IQ", "Resistance" },
                values: new object[] { 86, 91 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56,
                column: "Resistance",
                value: 58);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resistance",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "IQ",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                column: "IQ",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                column: "IQ",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                column: "IQ",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                column: "IQ",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                column: "IQ",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                column: "IQ",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                column: "IQ",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34,
                column: "IQ",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35,
                column: "IQ",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36,
                column: "IQ",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37,
                column: "IQ",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38,
                column: "IQ",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39,
                column: "IQ",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40,
                column: "IQ",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41,
                column: "IQ",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42,
                column: "IQ",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43,
                column: "IQ",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44,
                column: "IQ",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                column: "IQ",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46,
                column: "IQ",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47,
                column: "IQ",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48,
                column: "IQ",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49,
                column: "IQ",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50,
                column: "IQ",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51,
                column: "IQ",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52,
                column: "IQ",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53,
                column: "IQ",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54,
                column: "IQ",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55,
                column: "IQ",
                value: 65);
        }
    }
}
