using Microsoft.EntityFrameworkCore.Migrations;

namespace LernsiegDbLib.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Criterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EvaluationType = table.Column<int>(type: "INTEGER", nullable: false),
                    SequenceNr = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SchoolOrTeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    EvaluationType = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNr = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    SchoolNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    CriteriaId = table.Column<int>(type: "INTEGER", nullable: true),
                    EvaluationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationItems_Criterias_CriteriaId",
                        column: x => x.CriteriaId,
                        principalTable: "Criterias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EvaluationItems_Evaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "Evaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    SchoolId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 1, "4020 Linz, Donau, Honauerstraße 24", "at", "Bundes-Oberstufenrealgymnasium", 401046 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 22, "4840 Vöcklabruck, Bahnhofstraße 42", "at", "Höhere technische Bundeslehranstalt", 417427 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 20, "4770 Andorf, Hannes-Schrattenecker-Straße 1", "at", "Höhere technische Bundeslehranstalt", 414437 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 19, "4120 Neufelden, Höferweg 47", "at", "Höhere technische Bundeslehranstalt", 413447 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 18, "4170 Haslach an der Mühl, Grubberg 3", "at", "Technische Fachschule des Landes Oberösterreich", 413417 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 17, "4910 Ried im Innkreis, Molkereistraße 2", "at", "Höhere technische Bundeslehranstalt", 412477 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 16, "4910 Ried im Innkreis, Dr.Thomas-Senn-Straße 5", "at", "Bundes-Oberstufenrealgymnasium", 412026 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 15, "4320 Perg, Machlandstraße 48", "at", "Höhere technische Bundeslehranstalt", 411457 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 14, "4320 Perg, Dirnbergerstraße 43", "at", "Bundes-Oberstufenrealgymnasium", 411016 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 13, "4050 Traun, Bahnhofstraße 52", "at", "Höhere technische Bundeslehranstalt Traun", 410457 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 12, "4060 Leonding, Limesstraße 12-14", "at", "Höhere technische Bundeslehranstalt", 410427 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 21, "4190 Bad Leonfelden, Hagauerstraße 17", "at", "Bundes-Oberstufenrealgymnasium", 416016 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 10, "4710 Grieskirchen, Parzer Schulstraße 1", "at", "Höhere technische Bundeslehranstalt", 408427 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 9, "4710 Grieskirchen, Gymnasiumstraße 2", "at", "Bundes-Oberstufenrealgymnasium", 408016 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 8, "4830 Hallstatt, Lahnstraße 69", "at", "Höhere technische Bundeslehranstalt", 407417 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 7, "5280 Braunau am Inn, Osternbergerstraße 55", "at", "Höhere technische Bundeslehranstalt", 404427 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 6, "4600 Wels, Fischergasse 30", "at", "Höhere technische Bundeslehranstalt", 403457 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 5, "4600 Wels, Carl Blum-Straße 4", "at", "Höhere technische Lehranstalt für Lebensmitteltechnologie- Getreidewirtschaft des Landes OÖ", 403427 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 4, "4400 Steyr, Schlüsselhofgasse 63", "at", "Höhere technische Bundeslehranstalt", 402417 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 3, "4020 Linz, Donau, Paul-Hahn-Straße 4", "at", "Höhere technische Bundeslehranstalt \"LiTEC Linzer Technikum\"", 401467 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 2, "4020 Linz, Donau, Goethestraße 17", "at", "Höhere technische Bundeslehranstalt", 401417 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[] { 11, "4560 Kirchdorf an der Krems, Weinzierler Straße 22", "at", "Bundesrealgymnasium und Bundes-Oberstufenrealgymnasium", 409036 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 467, "Robyn Ewbach", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 466, "Tomlin Billin", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 462, "Archambault Jelks", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 464, "Anatol Gemlett", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 463, "Butch Haly", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 468, "Jon Schrader", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 465, "Iolanthe Nelles", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 469, "Catherin Revington", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 474, "Marna Pilipyak", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 471, "Stanly Librey", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 472, "Benita Brearley", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 473, "Inger Proudley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 475, "Elwira Minker", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 476, "Thorsten Samways", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 477, "Magnum Scading", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 478, "Devi Dillinger", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 461, "Arch Lemasney", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 470, "Doll Gove", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 460, "Michell Huckleby", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 449, "Hallie Keslake", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 458, "Vikki Josupeit", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 440, "Joline Shugg", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 441, "Tammie Rawsthorn", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 442, "Sayre Skae", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 443, "Ninon Hanscome", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 444, "Aldridge Mattioli", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 445, "Frazier Rasher", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 446, "Alisa Zellick", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 447, "Inigo Gyorffy", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 459, "Eba Castellaccio", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 448, "Rosalind Wardel", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 450, "Burr Callcott", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 451, "Terri O' Gara", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 452, "Minda Fullstone", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 453, "Talia Stonard", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 454, "Briney Niesing", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 455, "Libbey Frean", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 456, "Benoite Cusack", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 457, "Park Regorz", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 479, "Danit Peiser", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 480, "Hugues Phette", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 491, "Caleb Verey", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 482, "Aguistin Skewis", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 505, "Vinny Ixor", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 506, "Kimmi Astley", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 507, "Paolina Cluney", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 508, "Kassandra Shillington", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 509, "Ebonee Squelch", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 510, "Annemarie Verdie", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 511, "Lara Jennison", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 512, "Kelli Curds", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 504, "Melly Curtayne", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 513, "Tessie Raunds", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 515, "Aprilette Gain", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 516, "Neddy Summers", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 517, "Maurene Truitt", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 518, "Sherman O'Hartnedy", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 519, "Gilbertine de Savery", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 520, "Field Harburtson", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 521, "Trisha Iacapucci", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 522, "Hazel Bullent", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 514, "Lexy Watkiss", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 481, "Ab Aime", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 503, "Nicoli Volke", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 501, "Ferris Petchey", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 483, "Caria Ovill", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 484, "Ange Sayton", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 485, "Jillayne Hendren", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 486, "Wiatt Freegard", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 487, "Obadiah Dosdale", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 488, "Maryann Dewey", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 489, "Hyacinthia Durrett", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 490, "Kellie McCleod", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 502, "Damian Kirkup", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 439, "Cristiano Forde", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 493, "Hugibert Cotterill", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 494, "Elsbeth Smeeton", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 495, "Suellen Berge", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 496, "Maxwell Secombe", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 497, "Olympia Mottley", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 498, "Bord Coleyshaw", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 499, "Denny Iacofo", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 500, "Jobina Gianulli", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 492, "Vernen Sprouls", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 438, "Bennett Naile", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 427, "George Straun", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 436, "Bobette Ferraresi", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 374, "Dennie Ivons", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 375, "Dario Londsdale", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 376, "Tish Kayzer", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 377, "Hyatt Heck", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 378, "Jessy Sheerman", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 379, "Grata Lingfoot", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 380, "Gearalt Birnie", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 381, "Perren Ghilardini", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 373, "Koo Cowley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 382, "Dennie Dahlbom", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 384, "Hertha Pikett", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 385, "Cordie Gritsunov", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 386, "Hermina Dorney", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 387, "Lanita Dunsire", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 388, "Marja Bigglestone", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 389, "Fina Figiovanni", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 390, "Neddy Gladman", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 391, "Sheridan McDirmid", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 383, "Ebenezer Catton", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 392, "Car Callard", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 372, "Lonee Cran", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 370, "Hastie Willsmore", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 352, "Verla Scourfield", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 353, "Wylma Godball", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 354, "Coop Pountney", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 355, "Xerxes Pentelow", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 356, "Ana Delgardillo", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 357, "Antoni Hulse", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 358, "Yolande Kembley", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 359, "Brett Borrill", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 371, "Morgana O' Donohoe", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 360, "Madison Waller-Bridge", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 362, "Wald Mallender", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 363, "Bevan Worters", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 364, "Tailor Engledow", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 365, "Lane Siggery", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 366, "Waldon Buttler", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 367, "Ulrica Blain", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 368, "Jaimie Batham", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 369, "Trixy Goodanew", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 361, "Torin Edelheit", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 437, "Maje Pettecrew", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 393, "Suzy Olyfant", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 395, "Ira Leadbeater", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 418, "Fawn Jamblin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 419, "Rudolfo Dormer", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 420, "Kristien Tunsley", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 421, "Odille Kingswoode", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 422, "Ad Greave", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 423, "Martyn Ezzy", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 424, "Penrod Clancey", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 425, "Jenny Mangon", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 417, "Nollie Haggarth", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 426, "Giacopo Allbones", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 428, "Maisie Offiler", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 429, "Valentia Reeds", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 430, "Tarrance MacMearty", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 431, "Freddy Swires", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 432, "Libbie Haddacks", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 433, "Constantino Lawlance", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 434, "Hirsch Shama", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 435, "Lorelle Orrom", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 523, "Issie Moyce", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 394, "Shirline Hamshar", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 416, "Aldon Biagioni", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 414, "Justis Troup", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 396, "Berke Diable", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 397, "Anderson Phayre", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 398, "Belia Tideswell", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 399, "Dosi Fancet", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 400, "Johnath Sherrott", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 401, "Lawrence Bamblett", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 402, "Audre Larmett", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 403, "Ramona Franzelini", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 415, "Marleen Ort", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 404, "Vite Astling", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 406, "Luce Duran", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 407, "Jillie Duffit", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 408, "Caterina Hawkings", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 409, "Corrianne Rumbold", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 410, "Frederico Cossey", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 411, "Cloe Sadler", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 412, "Galvin Antoniou", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 413, "Joyous Kingswood", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 405, "Jose Barroux", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 524, "Rutger Jessop", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 535, "Eadith Cobley", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 526, "Mildred Begbie", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 637, "Ambur Leopard", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 638, "Brendon Lendrem", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 639, "Eilis Standrin", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 640, "Alfredo Strangeway", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 641, "Sheffie Digg", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 642, "Ebenezer Goodall", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 643, "Nessie Myrick", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 644, "Randolf Gribbin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 636, "Allianora Schach", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 645, "Cristi Ganter", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 647, "Vilhelmina Abramchik", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 648, "Sean MacLeese", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 649, "Gottfried Haxby", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 650, "Justen Willshire", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 651, "Kirstin Bindley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 652, "Adrien Keighley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 653, "Raimund Klemps", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 654, "Phedra Whieldon", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 646, "Merline Styche", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 655, "Joanne Dreelan", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 635, "Granny Sedgmond", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 633, "Mabel Sturgis", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 615, "Britney Paty", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 616, "Kessia Goldes", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 617, "Alika Speek", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 618, "Trixie Lambertson", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 619, "Adina Angerstein", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 620, "Car Edgeon", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 621, "Manon Giacopello", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 622, "Jarrad Geck", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 634, "Tabbitha Paterson", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 623, "Gabbie Belward", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 625, "Lief Langer", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 626, "Vilhelmina Highman", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 627, "Marijn Winney", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 628, "Tymon Blitzer", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 629, "Bradford Jovicic", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 630, "Allina Beumant", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 631, "Filmer Abramino", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 632, "Tate Kenewell", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 624, "Hadleigh Bowry", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 614, "Julia Bartke", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 656, "Kerrie Foffano", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 658, "Duane Casa", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 681, "Gavan Wassung", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 682, "Packston Kubatsch", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 683, "Ronnica Friedman", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 684, "Gal Stockall", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 685, "Minetta Rayhill", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 686, "Zsa zsa Burnhill", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 687, "Christel Philp", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 688, "Mersey Wellstood", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 680, "Demetrius MacDuffie", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 689, "Sheila Colliar", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 691, "Octavius Prescote", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 692, "Hasty O' Cuolahan", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 693, "Josey Biermatowicz", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 694, "Devina Yurasov", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 695, "Germaine Wehner", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 696, "Sloane Tremblett", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 697, "Kate Grimsdike", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 698, "Alon Onians", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 690, "Hillery Heibel", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 657, "Heath Willmett", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 679, "Stinky Showler", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 677, "Killy Posselwhite", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 659, "Liane Storrar", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 660, "Theo Soitoux", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 661, "Shelagh McGillreich", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 662, "Sasha Oakshott", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 663, "Lemar Cabrara", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 664, "Riccardo Illes", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 665, "Toddie Chrispin", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 666, "Kiele Crisell", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 678, "Flinn Stapleton", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 667, "Karee Denham", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 669, "Newton Float", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 670, "Delano Copland", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 671, "Edan Nevinson", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 672, "Robinia Dalgleish", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 673, "Dino Dowzell", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 674, "Eugenius Killgus", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 675, "Judi Olyet", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 676, "Jenine Keming", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 668, "Flor Poulston", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 525, "Alix Kochlin", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 613, "Velvet Daniell", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 611, "Joseph Shelsher", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 549, "Wileen Enrrico", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 550, "Jami Leas", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 551, "Lombard Truckett", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 552, "Roderigo Matteotti", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 553, "Sheba Spens", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 554, "Fiona Purveys", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 555, "Giorgio Terrelly", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 556, "Daphene Minihane", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 548, "Duncan Laneham", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 557, "Bird Dufoure", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 559, "Arluene Bapty", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 560, "Shalne Hillett", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 561, "Sheena Krink", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 562, "Layton Pudney", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 563, "Sumner Dallewater", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 564, "Clay Muggleton", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 565, "Joleen Morant", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 566, "Michael Strewther", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 558, "Seana Spick", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 567, "Franklyn Kiely", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 547, "Leda Tuerena", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 545, "Noell Ruter", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 527, "Ailina Kirk", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 528, "Kristien Kamen", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 529, "Maynard Dechelette", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 530, "Dav Gieves", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 531, "Yankee Noke", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 532, "Carie Crosfield", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 533, "Rita Trice", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 534, "Andrew Covert", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 546, "Towney Eldershaw", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 351, "Shepherd Trassler", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 537, "Gilemette Klimko", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 538, "Carlyle Hanley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 539, "Steffane Abadam", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 540, "Vicki Mcsarry", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 541, "Timmy Acton", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 542, "Tove Fould", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 543, "Alfonse Reoch", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 544, "Karylin Bernon", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 536, "Merell Pude", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 612, "Lorna Brattan", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 568, "Jaclyn Massingberd", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 570, "Frederico Sawkins", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 593, "Ave Pettyfar", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 594, "Petr Ruane", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 595, "Bastien Fibbings", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 596, "Moira Golden of Ireland", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 597, "Betty Brownhill", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 598, "Teddi Carncross", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 599, "Corenda Phifer", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 600, "Cherilyn Codlin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 592, "Etty Scougal", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 601, "Blakelee Canadine", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 603, "Renado Debill", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 604, "Perl Borrowman", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 605, "Calv Reubel", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 606, "Tobie Krolak", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 607, "Matilde Bartoleyn", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 608, "Alena Sprionghall", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 609, "Vitia Pratley", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 610, "Nicolina Mawditt", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 602, "Marnia Druhan", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 569, "Lillian Ollarenshaw", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 591, "Dagmar Makinson", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 589, "Brenn Gillooly", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 571, "Mead Loiterton", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 572, "Tedi Ablewhite", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 573, "Doralynn Ramelot", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 574, "Gayle Reyes", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 575, "Keene Matthews", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 576, "Bambi Meecher", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 577, "Carmelia Waddingham", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 578, "Winne Rabbitts", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 590, "Dougy Thomsen", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 579, "Drud Simonnin", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 581, "Xenia Allwood", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 582, "Hakim Jesson", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 583, "Vi Hassall", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 584, "Sharon MacClay", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 585, "Osmond Stennings", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 586, "Leoine McKernan", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 587, "Carolus Harner", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 588, "Wyn Parsell", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 580, "Arleyne Gillam", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 350, "Freedman Gladtbach", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 339, "Hazlett Lowen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 348, "Jacqui Kondrat", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 111, "Mord Lansley", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 112, "Eustacia Kinnen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 113, "Maria Valero", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 114, "Emilee Poyle", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 115, "Paolina Slimme", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 116, "Amandy Mangion", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 117, "Kandace Crowson", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 118, "Erminia Tunney", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 119, "Lev Tidcombe", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 120, "Theodore Duckitt", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 121, "Noelle Stening", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 122, "Kent Elbourne", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 123, "Berty Keenor", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 124, "Melloney O'Fallowne", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 125, "Lalo Petren", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 126, "Lulu Lawley", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 127, "Addison Ritchman", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 110, "Wallis Lamden", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 109, "Payton Juza", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 108, "Darice Derycot", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 107, "Bernardo Jenik", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 89, "Mohandas Derrell", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 90, "Alvina Hayman", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 91, "Camille Sandal", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 92, "Cob Bellhouse", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 93, "Carie Boerderman", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 94, "Dalt Coghlin", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 95, "Anders Bessell", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 96, "Marget Dombrell", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 128, "Moritz Swaile", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 97, "Ernst Allflatt", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 99, "Lucas Casillas", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 100, "Nancie Gymblett", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 101, "Johnath Ratazzi", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 102, "Darice Lewsley", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 103, "Claudetta Lynskey", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 104, "Giulio Pitcher", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 105, "Kynthia Yonge", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 106, "Gottfried Groarty", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 98, "Rudolf Southcott", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 129, "Nita Pappi", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 130, "Lila Muckeen", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 131, "Libbi Meachen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 154, "Alick Sutherley", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 155, "Lonni Cawsy", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 156, "Ibby Escala", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 157, "Felicity Dowd", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 158, "Pierce Basire", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 159, "Burk Millmore", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 160, "Aldridge Rysdale", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 161, "Mollee Ruslen", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 153, "Dorette Skingle", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 162, "Tessa Massy", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 164, "Mata Rumin", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 165, "Laney Aberchirder", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 166, "Felita Trays", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 167, "Cozmo Cobon", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 168, "Loise Frampton", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 169, "Natty Allner", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 170, "Jany Rulten", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 171, "Verena Louys", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 163, "Charo Josskowitz", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 88, "Laureen Cadore", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 152, "Shanta Lodevick", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 150, "Ree Collar", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 132, "Saunders Bes", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 133, "Dion Cowton", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 134, "Elnar Storek", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 135, "Derward Spores", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 136, "Conrado Cockley", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 137, "Maryrose McGonigal", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 138, "Delcine Le Prevost", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 139, "Cherish Franzke", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 151, "Richart Seaking", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 140, "Borg Bigglestone", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 142, "Aymer Lowndes", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 143, "Bruce Brankley", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 144, "Francyne Erwin", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 145, "Alwin Folks", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 146, "Verla Newbold", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 147, "Thacher Booth", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 148, "Robinette Raddish", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 149, "Babita Pocklington", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 141, "Lowell Bessom", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 87, "Hillary Folley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 86, "Milzie Alty", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 85, "Estrellita Pitchers", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 23, "Rodolfo Thomsson", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 24, "Loretta Lyle", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 25, "Gallard MacGuiness", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 26, "Lewes Chesshyre", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 27, "Patty Raselles", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 28, "Ruddy Loughead", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 29, "Junia Stern", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 30, "Jobie Jakobssen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 22, "Beth Kemshell", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 31, "Kelsy Devil", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 33, "Gerti Hirche", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 34, "Maribeth Yerrall", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 35, "Hillie Frankton", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 36, "Jeramie Confort", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 37, "Port Jennaway", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 38, "Woodman Rofe", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 39, "Svend Vaen", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 40, "Filippo Killwick", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 32, "Kirsten Denington", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 41, "Stevana Hudspith", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 21, "Isabelle Sproson", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 19, "Sadye Dudgeon", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 1, "Kip Harnett", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 2, "Baillie Alpine", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 3, "Elnore Fetherstone", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 4, "Rickard Bencher", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 5, "Lewes Romanin", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 6, "Barton McTeague", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 7, "Davey Gould", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 8, "Florencia Howarth", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 20, "Terrie Mattis", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 9, "Bearnard Elner", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 11, "Bryon Lyburn", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 12, "Daniela Golsthorp", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 13, "Simone Rubberts", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 14, "Lian Corcoran", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 15, "Demetris Mapston", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 16, "Sholom Van Cassel", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 17, "Karissa Antao", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 18, "Noreen Devonish", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 10, "Sacha Simmings", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 172, "Bobbette Grewe", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 42, "Amory Alywen", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 44, "Corny Lightowler", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 67, "Gert Dansken", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 68, "Frants Martelet", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 69, "Pietro Tant", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 70, "Rahel Tinwell", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 71, "Tito Beatey", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 72, "Hamil Deesly", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 73, "Laurella Darch", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 74, "Blayne Southey", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 66, "Martica Dawidowsky", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 75, "Eleen Moloney", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 77, "Dal Biesterfeld", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 78, "Patty Smurfitt", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 79, "Vinni Guilloux", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 80, "Anissa Allbut", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 81, "Goddard Issac", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 82, "Gaylene Morrel", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 83, "Nadia Bundock", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 84, "Florinda Aylwin", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 76, "Cris Maasz", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 43, "Kirsten Innes", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 65, "Davine Pomfrey", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 63, "Spenser Roder", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 45, "Lory Bartkiewicz", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 46, "Anny Bugg", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 47, "Milt Vinau", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 48, "Nadya Pottell", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 49, "Clarey Yerby", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 50, "Barris Warrillow", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 51, "Son Harfleet", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 52, "Clevey McAughtrie", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 64, "Marga Hess", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 53, "Alta Quinnette", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 55, "Leontine McDaid", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 56, "Gil Ivashkin", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 57, "Heloise Inchbald", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 58, "Brandy de Courcey", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 59, "Antonella Boots", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 60, "Oona Kildea", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 61, "Lefty Lavalde", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 62, "Corey Folca", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 54, "Waylon Wavish", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 173, "Celene Overstreet", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 174, "Tom Davidwitz", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 175, "Serene Ramm", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 286, "Silvie Leyman", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 287, "Randi Kinnier", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 288, "Ferrell Sellar", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 289, "Benedick Morrant", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 290, "Rafi Mc Andrew", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 291, "Mair Streets", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 292, "Sammie Parres", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 293, "Sharia Videler", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 285, "Riannon Yarnley", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 294, "Kaleb Williamson", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 296, "Tresa Weighell", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 297, "Ezechiel Potteridge", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 298, "Dyanna Camelli", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 299, "Kip Ivanets", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 300, "Fidel Skrine", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 301, "Tedie McKag", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 302, "Lynn Succamore", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 303, "Agatha Jodlkowski", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 295, "Olive Chilcott", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 304, "Artus Ferrelli", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 284, "Jan Vern", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 282, "Ettore Maffin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 264, "Brook Oppy", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 265, "Dorisa Wilcott", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 266, "Howard Petken", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 267, "Artemas Jedrychowski", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 268, "Auguste Vogt", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 269, "Elbertina Skirven", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 270, "Marlene Cumes", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 271, "Beale Croad", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 283, "Barn Clynman", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 272, "Letisha Aleksahkin", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 274, "Flossi Baggallay", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 275, "Willi Maysor", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 276, "Giana Gloyens", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 277, "Skippie Jaynes", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 278, "Goldy O'Currine", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 279, "Opalina Scatchar", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 280, "Jaquelin Pren", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 281, "Florrie Domesday", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 273, "Alyss Brunone", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 263, "Ravi O'Neal", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 305, "Claretta Galpen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 307, "Saraann Wilsher", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 330, "Rozalie Huckleby", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 331, "Harlen Klinck", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 332, "Amity Tayloe", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 333, "Hugues Greer", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 334, "Maiga Schimank", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 335, "Fayina Mongin", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 336, "Isahella Clench", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 337, "Currey Windham", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 329, "Cordy Smowton", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 338, "Lenna Lear", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 340, "Vernon O'Cannavan", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 341, "Skylar Skyme", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 342, "Seumas Spurdens", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 343, "Reagen Mower", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 344, "Terrel Noyce", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 345, "Annalee Dmitrichenko", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 346, "Gran Barnewell", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 347, "Nichole Knibb", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 699, "Gizela Nussgen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 306, "Vale Gosselin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 328, "Carlynne Crannach", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 326, "Wash Gieraths", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 308, "Bili Vitte", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 309, "Maible de Marco", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 310, "Kristi Zorn", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 311, "Krystalle Kryska", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 312, "Saul Johncey", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 313, "Tiffy Behnecke", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 314, "Sterne Waywell", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 315, "Anatole McSperrin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 327, "Reta Ranstead", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 316, "Connie D'Oyly", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 318, "Bevvy Newlove", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 319, "Antoine Clemmens", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 320, "Burty Wybern", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 321, "Ephrayim Puvia", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 322, "Arabelle Gerald", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 323, "Andie Le Gall", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 324, "Cointon Mallya", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 325, "Immanuel Spuffard", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 317, "Romola Baume", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 349, "Winifield Mewe", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 262, "Baxter Arran", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 260, "Vikki O'Dunneen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 198, "Dorrie Netley", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 199, "Chance Benoit", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 200, "Milena Patshull", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 201, "Carmita Seston", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 202, "Edik Clitherow", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 203, "Erica Castilla", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 204, "Eugenio O' Faherty", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 205, "Carolyn Lindenman", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 197, "Brian Ackery", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 206, "Pauli Barron", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 208, "Allegra Sellstrom", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 209, "Christos Regis", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 210, "Bess Weed", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 211, "Sandy Wyllcock", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 212, "Jamaal Peevor", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 213, "Patin Brunet", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 214, "Grata Cereceres", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 215, "Lotti Hunnam", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 207, "Ruthe O'Gorman", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 216, "Ofella Kimmins", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 196, "Myra Cossons", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 194, "Caro Mees", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 176, "Oswell Goodlett", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 177, "Blake Hankard", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 178, "Nola Onge", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 179, "Hewett Saker", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 180, "Brannon McGeown", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 181, "Lurline Boatswain", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 182, "Konrad Haslum", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 183, "Munroe Ivanilov", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 195, "Nert Pitts", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 184, "Burlie Antonescu", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 186, "Carita Billyard", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 187, "Calli Skillen", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 188, "Vicki Rickarsey", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 189, "Stephie Setford", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 190, "Fairleigh Snowling", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 191, "Hortensia Hazeup", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 192, "Fred Yepiskov", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 193, "Ricoriki Whyatt", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 185, "Sig Harborow", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 261, "My Sorsbie", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 217, "Mendel Naris", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 219, "Arluene Torrans", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 242, "Letitia McNish", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 243, "Care Deelay", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 244, "Kym Leechman", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 245, "Devin Ferries", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 246, "Marcile Tavernor", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 247, "Alix Warricker", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 248, "Hildagarde Staveley", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 249, "Hayyim Gatrell", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 241, "Abby Eagle", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 250, "Justus Richichi", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 252, "Callean Antonetti", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 253, "Tish Abrashkin", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 254, "Ranee Krochmann", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 255, "Othelia Juggings", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 256, "Courtney O' Byrne", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 257, "Karisa Fraser", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 258, "Latashia Somes", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 259, "Geri Janca", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 251, "Gay Sheehan", null, "DI Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 218, "Brinn Joselevitch", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 240, "Gene Turbefield", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 238, "Lyssa Syder", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 220, "Isidoro Astell", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 221, "Minnnie Pechet", null, "MMag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 222, "Kariotta Leith-Harvey", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 223, "Isador Snailham", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 224, "Filip Caddie", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 225, "Rolfe Dunks", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 226, "Verene Suffield", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 227, "Vachel Last", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 239, "Stillmann Linnard", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 228, "Cosme Kennelly", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 230, "Mendie Bartusek", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 231, "Lorenza Kevlin", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 232, "Amalita L'Hommee", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 233, "Isador Basezzi", null, "Mag" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 234, "Demetre Sabberton", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 235, "Leonard Duddell", null, "Mag DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 236, "Gale Strelitz", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 237, "Coleen Bleythin", null, "Dr" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 229, "Giffard Covotto", null, "DI" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[] { 700, "Sibel MacMenamy", null, "Dr" });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationItems_CriteriaId",
                table: "EvaluationItems",
                column: "CriteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationItems_EvaluationId",
                table: "EvaluationItems",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationItems");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Criterias");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
