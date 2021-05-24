using Microsoft.EntityFrameworkCore.Migrations;

namespace LernsiegDbLib.Migrations
{
    public partial class Evaluation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "EvaluationType", "PhoneNr", "SchoolOrTeacherId" },
                values: new object[] { 1, 1, "8907872346", 6 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "EvaluationType", "PhoneNr", "SchoolOrTeacherId" },
                values: new object[] { 2, 1, "069911343415", 401417 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
