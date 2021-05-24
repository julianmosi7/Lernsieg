using Microsoft.EntityFrameworkCore.Migrations;

namespace LernsiegDbLib.Migrations
{
    public partial class SeedCriteria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Criterias",
                columns: new[] { "Id", "Description", "EvaluationType", "SequenceNr" },
                values: new object[,]
                {
                    { 1, "Klassenzimmer", 1, 1 },
                    { 18, "Vorbereitung", 2, 6 },
                    { 17, "Geduld", 2, 5 },
                    { 16, "Motivationsfähigkeit", 2, 4 },
                    { 15, "Respekt", 2, 3 },
                    { 14, "Fairness", 2, 2 },
                    { 13, "Unterricht", 2, 1 },
                    { 12, "Fridays for Future", 1, 12 },
                    { 11, "Veranstaltungen", 1, 12 },
                    { 10, "Neue Medien", 1, 10 },
                    { 9, "Sauberkeit", 1, 9 },
                    { 8, "Bibliothek", 1, 8 },
                    { 7, "Supplierungen", 1, 7 },
                    { 6, "Mensa oder Kantine", 1, 6 },
                    { 5, "Sportanlage", 1, 5 },
                    { 4, "Motivationsfähigkeit", 1, 4 },
                    { 3, "Stimmung", 1, 3 },
                    { 2, "Lehrangebot", 1, 2 },
                    { 19, "Durchsetzungsfähigkeit", 2, 7 },
                    { 20, "Pünktlichkeit", 2, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Criterias",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
