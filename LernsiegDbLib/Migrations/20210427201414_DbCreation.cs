using Microsoft.EntityFrameworkCore.Migrations;

namespace LernsiegDbLib.Migrations
{
    public partial class DbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Criterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvaluationType = table.Column<int>(type: "int", nullable: false),
                    SequenceNr = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolOrTeacherId = table.Column<int>(type: "int", nullable: false),
                    EvaluationType = table.Column<int>(type: "int", nullable: false),
                    PhoneNr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.UniqueConstraint("CO_Schools", x => x.SchoolNumber);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriteriaId = table.Column<int>(type: "int", nullable: true),
                    EvaluationId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolNumber = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolNumber,
                        principalTable: "Schools",
                        principalColumn: "SchoolNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "Country", "Name", "SchoolNumber" },
                values: new object[,]
                {
                    { 1, "4020 Linz, Donau, Honauerstraße 24", "at", "Bundes-Oberstufenrealgymnasium", 401046 },
                    { 22, "4840 Vöcklabruck, Bahnhofstraße 42", "at", "Höhere technische Bundeslehranstalt", 417427 },
                    { 20, "4770 Andorf, Hannes-Schrattenecker-Straße 1", "at", "Höhere technische Bundeslehranstalt", 414437 },
                    { 19, "4120 Neufelden, Höferweg 47", "at", "Höhere technische Bundeslehranstalt", 413447 },
                    { 18, "4170 Haslach an der Mühl, Grubberg 3", "at", "Technische Fachschule des Landes Oberösterreich", 413417 },
                    { 17, "4910 Ried im Innkreis, Molkereistraße 2", "at", "Höhere technische Bundeslehranstalt", 412477 },
                    { 16, "4910 Ried im Innkreis, Dr.Thomas-Senn-Straße 5", "at", "Bundes-Oberstufenrealgymnasium", 412026 },
                    { 15, "4320 Perg, Machlandstraße 48", "at", "Höhere technische Bundeslehranstalt", 411457 },
                    { 14, "4320 Perg, Dirnbergerstraße 43", "at", "Bundes-Oberstufenrealgymnasium", 411016 },
                    { 13, "4050 Traun, Bahnhofstraße 52", "at", "Höhere technische Bundeslehranstalt Traun", 410457 },
                    { 12, "4060 Leonding, Limesstraße 12-14", "at", "Höhere technische Bundeslehranstalt", 410427 },
                    { 21, "4190 Bad Leonfelden, Hagauerstraße 17", "at", "Bundes-Oberstufenrealgymnasium", 416016 },
                    { 10, "4710 Grieskirchen, Parzer Schulstraße 1", "at", "Höhere technische Bundeslehranstalt", 408427 },
                    { 9, "4710 Grieskirchen, Gymnasiumstraße 2", "at", "Bundes-Oberstufenrealgymnasium", 408016 },
                    { 8, "4830 Hallstatt, Lahnstraße 69", "at", "Höhere technische Bundeslehranstalt", 407417 },
                    { 7, "5280 Braunau am Inn, Osternbergerstraße 55", "at", "Höhere technische Bundeslehranstalt", 404427 },
                    { 6, "4600 Wels, Fischergasse 30", "at", "Höhere technische Bundeslehranstalt", 403457 },
                    { 5, "4600 Wels, Carl Blum-Straße 4", "at", "Höhere technische Lehranstalt für Lebensmitteltechnologie- Getreidewirtschaft des Landes OÖ", 403427 },
                    { 4, "4400 Steyr, Schlüsselhofgasse 63", "at", "Höhere technische Bundeslehranstalt", 402417 },
                    { 3, "4020 Linz, Donau, Paul-Hahn-Straße 4", "at", "Höhere technische Bundeslehranstalt \"LiTEC Linzer Technikum\"", 401467 },
                    { 2, "4020 Linz, Donau, Goethestraße 17", "at", "Höhere technische Bundeslehranstalt", 401417 },
                    { 11, "4560 Kirchdorf an der Krems, Weinzierler Straße 22", "at", "Bundesrealgymnasium und Bundes-Oberstufenrealgymnasium", 409036 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 467, "Robyn Ewbach", null, 413447, "Mag DI" },
                    { 466, "Tomlin Billin", null, 411457, "MMag" },
                    { 462, "Archambault Jelks", null, 408427, "DI" },
                    { 464, "Anatol Gemlett", null, 413447, "DI Dr" },
                    { 463, "Butch Haly", null, 401046, "MMag" },
                    { 468, "Jon Schrader", null, 401467, "DI" },
                    { 465, "Iolanthe Nelles", null, 416016, "DI Dr" },
                    { 469, "Catherin Revington", null, 410457, "Mag DI" },
                    { 474, "Marna Pilipyak", null, 410457, "DI Dr" },
                    { 471, "Stanly Librey", null, 401046, "Dr" },
                    { 472, "Benita Brearley", null, 412026, "MMag" },
                    { 473, "Inger Proudley", null, 408016, "DI Dr" },
                    { 475, "Elwira Minker", null, 414437, "DI Dr" },
                    { 476, "Thorsten Samways", null, 404427, "MMag" },
                    { 477, "Magnum Scading", null, 416016, "DI" },
                    { 478, "Devi Dillinger", null, 404427, "MMag" },
                    { 461, "Arch Lemasney", null, 401417, "Dr" },
                    { 470, "Doll Gove", null, 401046, "DI Dr" },
                    { 460, "Michell Huckleby", null, 403457, "DI" },
                    { 449, "Hallie Keslake", null, 414437, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 458, "Vikki Josupeit", null, 401467, "Mag" },
                    { 440, "Joline Shugg", null, 404427, "Dr" },
                    { 441, "Tammie Rawsthorn", null, 411016, "DI" },
                    { 442, "Sayre Skae", null, 411457, "DI" },
                    { 443, "Ninon Hanscome", null, 401467, "MMag" },
                    { 444, "Aldridge Mattioli", null, 412477, "DI Dr" },
                    { 445, "Frazier Rasher", null, 404427, "MMag" },
                    { 446, "Alisa Zellick", null, 414437, "DI Dr" },
                    { 447, "Inigo Gyorffy", null, 411457, "MMag" },
                    { 459, "Eba Castellaccio", null, 407417, "MMag" },
                    { 448, "Rosalind Wardel", null, 413417, "Dr" },
                    { 450, "Burr Callcott", null, 403457, "Mag DI" },
                    { 451, "Terri O' Gara", null, 411016, "Dr" },
                    { 452, "Minda Fullstone", null, 411457, "DI" },
                    { 453, "Talia Stonard", null, 410457, "DI" },
                    { 454, "Briney Niesing", null, 404427, "Mag DI" },
                    { 455, "Libbey Frean", null, 401417, "Dr" },
                    { 456, "Benoite Cusack", null, 401417, "DI Dr" },
                    { 457, "Park Regorz", null, 401417, "Mag" },
                    { 479, "Danit Peiser", null, 408427, "Mag" },
                    { 480, "Hugues Phette", null, 407417, "Dr" },
                    { 491, "Caleb Verey", null, 412477, "MMag" },
                    { 482, "Aguistin Skewis", null, 408016, "Mag" },
                    { 505, "Vinny Ixor", null, 402417, "DI" },
                    { 506, "Kimmi Astley", null, 416016, "Mag DI" },
                    { 507, "Paolina Cluney", null, 403427, "MMag" },
                    { 508, "Kassandra Shillington", null, 403457, "Mag" },
                    { 509, "Ebonee Squelch", null, 414437, "DI" },
                    { 510, "Annemarie Verdie", null, 414437, "Mag" },
                    { 511, "Lara Jennison", null, 402417, "MMag" },
                    { 512, "Kelli Curds", null, 408016, "Mag" },
                    { 504, "Melly Curtayne", null, 417427, "MMag" },
                    { 513, "Tessie Raunds", null, 408427, "DI Dr" },
                    { 515, "Aprilette Gain", null, 404427, "Dr" },
                    { 516, "Neddy Summers", null, 410427, "Mag DI" },
                    { 517, "Maurene Truitt", null, 416016, "Dr" },
                    { 518, "Sherman O'Hartnedy", null, 410427, "Mag" },
                    { 519, "Gilbertine de Savery", null, 412477, "Mag" },
                    { 520, "Field Harburtson", null, 412477, "Mag" },
                    { 521, "Trisha Iacapucci", null, 408427, "MMag" },
                    { 522, "Hazel Bullent", null, 411016, "DI" },
                    { 514, "Lexy Watkiss", null, 410457, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 481, "Ab Aime", null, 416016, "Dr" },
                    { 503, "Nicoli Volke", null, 410427, "Mag DI" },
                    { 501, "Ferris Petchey", null, 401046, "Mag" },
                    { 483, "Caria Ovill", null, 412026, "MMag" },
                    { 484, "Ange Sayton", null, 411457, "Mag DI" },
                    { 485, "Jillayne Hendren", null, 404427, "MMag" },
                    { 486, "Wiatt Freegard", null, 412026, "Mag DI" },
                    { 487, "Obadiah Dosdale", null, 403427, "Mag DI" },
                    { 488, "Maryann Dewey", null, 410457, "MMag" },
                    { 489, "Hyacinthia Durrett", null, 403427, "Mag DI" },
                    { 490, "Kellie McCleod", null, 414437, "Dr" },
                    { 502, "Damian Kirkup", null, 412477, "Mag" },
                    { 439, "Cristiano Forde", null, 403427, "Mag" },
                    { 493, "Hugibert Cotterill", null, 412026, "DI" },
                    { 494, "Elsbeth Smeeton", null, 403457, "DI" },
                    { 495, "Suellen Berge", null, 401046, "Dr" },
                    { 496, "Maxwell Secombe", null, 412477, "Mag DI" },
                    { 497, "Olympia Mottley", null, 402417, "Mag" },
                    { 498, "Bord Coleyshaw", null, 413447, "DI" },
                    { 499, "Denny Iacofo", null, 410427, "Mag DI" },
                    { 500, "Jobina Gianulli", null, 407417, "DI" },
                    { 492, "Vernen Sprouls", null, 416016, "Dr" },
                    { 438, "Bennett Naile", null, 416016, "Dr" },
                    { 427, "George Straun", null, 412477, "Mag" },
                    { 436, "Bobette Ferraresi", null, 416016, "Mag DI" },
                    { 374, "Dennie Ivons", null, 404427, "Dr" },
                    { 375, "Dario Londsdale", null, 412026, "Dr" },
                    { 376, "Tish Kayzer", null, 417427, "DI" },
                    { 377, "Hyatt Heck", null, 412026, "DI" },
                    { 378, "Jessy Sheerman", null, 413447, "Dr" },
                    { 379, "Grata Lingfoot", null, 412477, "Mag" },
                    { 380, "Gearalt Birnie", null, 401046, "DI Dr" },
                    { 381, "Perren Ghilardini", null, 407417, "MMag" },
                    { 373, "Koo Cowley", null, 416016, "DI Dr" },
                    { 382, "Dennie Dahlbom", null, 404427, "Mag" },
                    { 384, "Hertha Pikett", null, 408016, "Mag DI" },
                    { 385, "Cordie Gritsunov", null, 413417, "DI" },
                    { 386, "Hermina Dorney", null, 411457, "Mag DI" },
                    { 387, "Lanita Dunsire", null, 409036, "MMag" },
                    { 388, "Marja Bigglestone", null, 409036, "Mag DI" },
                    { 389, "Fina Figiovanni", null, 410427, "DI" },
                    { 390, "Neddy Gladman", null, 410457, "Mag DI" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 391, "Sheridan McDirmid", null, 410427, "Dr" },
                    { 383, "Ebenezer Catton", null, 412477, "Dr" },
                    { 392, "Car Callard", null, 412026, "Dr" },
                    { 372, "Lonee Cran", null, 411457, "Dr" },
                    { 370, "Hastie Willsmore", null, 409036, "Mag" },
                    { 352, "Verla Scourfield", null, 408016, "DI Dr" },
                    { 353, "Wylma Godball", null, 411457, "Dr" },
                    { 354, "Coop Pountney", null, 404427, "Dr" },
                    { 355, "Xerxes Pentelow", null, 410427, "DI Dr" },
                    { 356, "Ana Delgardillo", null, 402417, "DI" },
                    { 357, "Antoni Hulse", null, 414437, "DI" },
                    { 358, "Yolande Kembley", null, 401417, "Dr" },
                    { 359, "Brett Borrill", null, 413417, "MMag" },
                    { 371, "Morgana O' Donohoe", null, 410427, "DI" },
                    { 360, "Madison Waller-Bridge", null, 404427, "MMag" },
                    { 362, "Wald Mallender", null, 412477, "Dr" },
                    { 363, "Bevan Worters", null, 417427, "DI" },
                    { 364, "Tailor Engledow", null, 401467, "DI" },
                    { 365, "Lane Siggery", null, 407417, "Mag" },
                    { 366, "Waldon Buttler", null, 403457, "MMag" },
                    { 367, "Ulrica Blain", null, 414437, "DI" },
                    { 368, "Jaimie Batham", null, 404427, "DI" },
                    { 369, "Trixy Goodanew", null, 413447, "DI Dr" },
                    { 361, "Torin Edelheit", null, 412477, "DI" },
                    { 437, "Maje Pettecrew", null, 403457, "Mag DI" },
                    { 393, "Suzy Olyfant", null, 407417, "Dr" },
                    { 395, "Ira Leadbeater", null, 411457, "MMag" },
                    { 418, "Fawn Jamblin", null, 416016, "Dr" },
                    { 419, "Rudolfo Dormer", null, 403457, "Dr" },
                    { 420, "Kristien Tunsley", null, 407417, "Dr" },
                    { 421, "Odille Kingswoode", null, 409036, "Mag" },
                    { 422, "Ad Greave", null, 401046, "DI Dr" },
                    { 423, "Martyn Ezzy", null, 414437, "Mag" },
                    { 424, "Penrod Clancey", null, 411457, "Dr" },
                    { 425, "Jenny Mangon", null, 407417, "Mag" },
                    { 417, "Nollie Haggarth", null, 413447, "Mag" },
                    { 426, "Giacopo Allbones", null, 401467, "Mag" },
                    { 428, "Maisie Offiler", null, 402417, "DI Dr" },
                    { 429, "Valentia Reeds", null, 408016, "DI Dr" },
                    { 430, "Tarrance MacMearty", null, 417427, "Mag DI" },
                    { 431, "Freddy Swires", null, 412477, "DI" },
                    { 432, "Libbie Haddacks", null, 411457, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 433, "Constantino Lawlance", null, 403427, "MMag" },
                    { 434, "Hirsch Shama", null, 403427, "Mag" },
                    { 435, "Lorelle Orrom", null, 407417, "Mag" },
                    { 523, "Issie Moyce", null, 407417, "Mag DI" },
                    { 394, "Shirline Hamshar", null, 401046, "DI Dr" },
                    { 416, "Aldon Biagioni", null, 403457, "MMag" },
                    { 414, "Justis Troup", null, 411457, "DI Dr" },
                    { 396, "Berke Diable", null, 402417, "MMag" },
                    { 397, "Anderson Phayre", null, 413417, "Dr" },
                    { 398, "Belia Tideswell", null, 414437, "DI" },
                    { 399, "Dosi Fancet", null, 409036, "Dr" },
                    { 400, "Johnath Sherrott", null, 413417, "Mag" },
                    { 401, "Lawrence Bamblett", null, 413447, "Mag" },
                    { 402, "Audre Larmett", null, 407417, "Mag" },
                    { 403, "Ramona Franzelini", null, 412477, "MMag" },
                    { 415, "Marleen Ort", null, 408427, "DI" },
                    { 404, "Vite Astling", null, 401417, "DI" },
                    { 406, "Luce Duran", null, 417427, "Mag DI" },
                    { 407, "Jillie Duffit", null, 414437, "MMag" },
                    { 408, "Caterina Hawkings", null, 404427, "Mag DI" },
                    { 409, "Corrianne Rumbold", null, 414437, "MMag" },
                    { 410, "Frederico Cossey", null, 413417, "MMag" },
                    { 411, "Cloe Sadler", null, 410457, "Dr" },
                    { 412, "Galvin Antoniou", null, 417427, "Dr" },
                    { 413, "Joyous Kingswood", null, 410457, "Mag DI" },
                    { 405, "Jose Barroux", null, 413417, "DI Dr" },
                    { 524, "Rutger Jessop", null, 413447, "DI" },
                    { 535, "Eadith Cobley", null, 408016, "DI" },
                    { 526, "Mildred Begbie", null, 412026, "Mag" },
                    { 637, "Ambur Leopard", null, 411457, "Mag" },
                    { 638, "Brendon Lendrem", null, 402417, "DI Dr" },
                    { 639, "Eilis Standrin", null, 411016, "Mag" },
                    { 640, "Alfredo Strangeway", null, 401417, "Mag DI" },
                    { 641, "Sheffie Digg", null, 410427, "Dr" },
                    { 642, "Ebenezer Goodall", null, 416016, "DI" },
                    { 643, "Nessie Myrick", null, 417427, "DI" },
                    { 644, "Randolf Gribbin", null, 411457, "Dr" },
                    { 636, "Allianora Schach", null, 413447, "DI" },
                    { 645, "Cristi Ganter", null, 410457, "DI Dr" },
                    { 647, "Vilhelmina Abramchik", null, 408016, "Mag DI" },
                    { 648, "Sean MacLeese", null, 412026, "DI Dr" },
                    { 649, "Gottfried Haxby", null, 416016, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 650, "Justen Willshire", null, 410427, "MMag" },
                    { 651, "Kirstin Bindley", null, 410427, "DI Dr" },
                    { 652, "Adrien Keighley", null, 404427, "DI Dr" },
                    { 653, "Raimund Klemps", null, 408016, "DI Dr" },
                    { 654, "Phedra Whieldon", null, 413417, "MMag" },
                    { 646, "Merline Styche", null, 412477, "DI Dr" },
                    { 655, "Joanne Dreelan", null, 412026, "DI Dr" },
                    { 635, "Granny Sedgmond", null, 411016, "Dr" },
                    { 633, "Mabel Sturgis", null, 408427, "Mag" },
                    { 615, "Britney Paty", null, 411016, "MMag" },
                    { 616, "Kessia Goldes", null, 413447, "Mag" },
                    { 617, "Alika Speek", null, 401417, "DI" },
                    { 618, "Trixie Lambertson", null, 409036, "Dr" },
                    { 619, "Adina Angerstein", null, 417427, "Dr" },
                    { 620, "Car Edgeon", null, 404427, "Dr" },
                    { 621, "Manon Giacopello", null, 401417, "Mag DI" },
                    { 622, "Jarrad Geck", null, 416016, "Mag" },
                    { 634, "Tabbitha Paterson", null, 417427, "Dr" },
                    { 623, "Gabbie Belward", null, 408016, "Mag DI" },
                    { 625, "Lief Langer", null, 413417, "Mag" },
                    { 626, "Vilhelmina Highman", null, 412026, "Mag DI" },
                    { 627, "Marijn Winney", null, 403457, "Mag" },
                    { 628, "Tymon Blitzer", null, 403427, "Mag" },
                    { 629, "Bradford Jovicic", null, 414437, "Dr" },
                    { 630, "Allina Beumant", null, 417427, "MMag" },
                    { 631, "Filmer Abramino", null, 408427, "DI" },
                    { 632, "Tate Kenewell", null, 411016, "Mag" },
                    { 624, "Hadleigh Bowry", null, 410427, "Dr" },
                    { 614, "Julia Bartke", null, 403427, "DI Dr" },
                    { 656, "Kerrie Foffano", null, 409036, "Mag" },
                    { 658, "Duane Casa", null, 401467, "Mag DI" },
                    { 681, "Gavan Wassung", null, 401467, "Mag" },
                    { 682, "Packston Kubatsch", null, 417427, "Dr" },
                    { 683, "Ronnica Friedman", null, 401046, "DI Dr" },
                    { 684, "Gal Stockall", null, 413417, "DI" },
                    { 685, "Minetta Rayhill", null, 412026, "Dr" },
                    { 686, "Zsa zsa Burnhill", null, 413447, "Mag" },
                    { 687, "Christel Philp", null, 401417, "Dr" },
                    { 688, "Mersey Wellstood", null, 401467, "Mag DI" },
                    { 680, "Demetrius MacDuffie", null, 404427, "DI" },
                    { 689, "Sheila Colliar", null, 407417, "Dr" },
                    { 691, "Octavius Prescote", null, 410427, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 692, "Hasty O' Cuolahan", null, 410457, "MMag" },
                    { 693, "Josey Biermatowicz", null, 416016, "Mag DI" },
                    { 694, "Devina Yurasov", null, 401046, "DI" },
                    { 695, "Germaine Wehner", null, 413447, "MMag" },
                    { 696, "Sloane Tremblett", null, 412026, "DI Dr" },
                    { 697, "Kate Grimsdike", null, 409036, "DI Dr" },
                    { 698, "Alon Onians", null, 409036, "DI" },
                    { 690, "Hillery Heibel", null, 410457, "Dr" },
                    { 657, "Heath Willmett", null, 417427, "Mag DI" },
                    { 679, "Stinky Showler", null, 412477, "DI" },
                    { 677, "Killy Posselwhite", null, 413417, "Mag DI" },
                    { 659, "Liane Storrar", null, 401417, "DI" },
                    { 660, "Theo Soitoux", null, 416016, "Dr" },
                    { 661, "Shelagh McGillreich", null, 403457, "MMag" },
                    { 662, "Sasha Oakshott", null, 410457, "Mag" },
                    { 663, "Lemar Cabrara", null, 401467, "DI Dr" },
                    { 664, "Riccardo Illes", null, 413447, "DI" },
                    { 665, "Toddie Chrispin", null, 402417, "DI" },
                    { 666, "Kiele Crisell", null, 409036, "DI Dr" },
                    { 678, "Flinn Stapleton", null, 417427, "Dr" },
                    { 667, "Karee Denham", null, 413447, "Mag DI" },
                    { 669, "Newton Float", null, 417427, "DI Dr" },
                    { 670, "Delano Copland", null, 413447, "DI" },
                    { 671, "Edan Nevinson", null, 411457, "DI Dr" },
                    { 672, "Robinia Dalgleish", null, 411016, "Dr" },
                    { 673, "Dino Dowzell", null, 408427, "DI" },
                    { 674, "Eugenius Killgus", null, 403427, "Mag" },
                    { 675, "Judi Olyet", null, 401046, "Mag DI" },
                    { 676, "Jenine Keming", null, 412477, "Mag" },
                    { 668, "Flor Poulston", null, 410457, "DI" },
                    { 525, "Alix Kochlin", null, 413447, "DI Dr" },
                    { 613, "Velvet Daniell", null, 410427, "Mag DI" },
                    { 611, "Joseph Shelsher", null, 414437, "DI" },
                    { 549, "Wileen Enrrico", null, 412477, "MMag" },
                    { 550, "Jami Leas", null, 401046, "DI Dr" },
                    { 551, "Lombard Truckett", null, 417427, "Mag DI" },
                    { 552, "Roderigo Matteotti", null, 411457, "MMag" },
                    { 553, "Sheba Spens", null, 408016, "Mag DI" },
                    { 554, "Fiona Purveys", null, 410427, "Dr" },
                    { 555, "Giorgio Terrelly", null, 413447, "MMag" },
                    { 556, "Daphene Minihane", null, 412026, "Dr" },
                    { 548, "Duncan Laneham", null, 408427, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 557, "Bird Dufoure", null, 412477, "Mag" },
                    { 559, "Arluene Bapty", null, 401417, "Dr" },
                    { 560, "Shalne Hillett", null, 411016, "Mag" },
                    { 561, "Sheena Krink", null, 401046, "Mag" },
                    { 562, "Layton Pudney", null, 407417, "Mag" },
                    { 563, "Sumner Dallewater", null, 407417, "Mag DI" },
                    { 564, "Clay Muggleton", null, 402417, "MMag" },
                    { 565, "Joleen Morant", null, 411016, "DI Dr" },
                    { 566, "Michael Strewther", null, 410427, "Mag" },
                    { 558, "Seana Spick", null, 408016, "DI Dr" },
                    { 567, "Franklyn Kiely", null, 412026, "DI" },
                    { 547, "Leda Tuerena", null, 416016, "Mag DI" },
                    { 545, "Noell Ruter", null, 414437, "Mag" },
                    { 527, "Ailina Kirk", null, 414437, "MMag" },
                    { 528, "Kristien Kamen", null, 401467, "MMag" },
                    { 529, "Maynard Dechelette", null, 411016, "DI Dr" },
                    { 530, "Dav Gieves", null, 408016, "DI Dr" },
                    { 531, "Yankee Noke", null, 408427, "Mag DI" },
                    { 532, "Carie Crosfield", null, 413447, "DI Dr" },
                    { 533, "Rita Trice", null, 403457, "MMag" },
                    { 534, "Andrew Covert", null, 401467, "Mag" },
                    { 546, "Towney Eldershaw", null, 408427, "Dr" },
                    { 351, "Shepherd Trassler", null, 408016, "MMag" },
                    { 537, "Gilemette Klimko", null, 413417, "Mag DI" },
                    { 538, "Carlyle Hanley", null, 401046, "DI Dr" },
                    { 539, "Steffane Abadam", null, 409036, "MMag" },
                    { 540, "Vicki Mcsarry", null, 403427, "Mag" },
                    { 541, "Timmy Acton", null, 402417, "MMag" },
                    { 542, "Tove Fould", null, 402417, "DI Dr" },
                    { 543, "Alfonse Reoch", null, 411016, "DI Dr" },
                    { 544, "Karylin Bernon", null, 414437, "DI" },
                    { 536, "Merell Pude", null, 401467, "Mag DI" },
                    { 612, "Lorna Brattan", null, 412026, "DI Dr" },
                    { 568, "Jaclyn Massingberd", null, 407417, "Mag DI" },
                    { 570, "Frederico Sawkins", null, 411457, "DI" },
                    { 593, "Ave Pettyfar", null, 413447, "DI" },
                    { 594, "Petr Ruane", null, 401417, "DI" },
                    { 595, "Bastien Fibbings", null, 411016, "MMag" },
                    { 596, "Moira Golden of Ireland", null, 401046, "MMag" },
                    { 597, "Betty Brownhill", null, 401467, "Mag" },
                    { 598, "Teddi Carncross", null, 408427, "Mag DI" },
                    { 599, "Corenda Phifer", null, 409036, "Mag DI" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 600, "Cherilyn Codlin", null, 414437, "Dr" },
                    { 592, "Etty Scougal", null, 409036, "Dr" },
                    { 601, "Blakelee Canadine", null, 408016, "Dr" },
                    { 603, "Renado Debill", null, 401467, "Mag" },
                    { 604, "Perl Borrowman", null, 411457, "DI" },
                    { 605, "Calv Reubel", null, 403427, "DI Dr" },
                    { 606, "Tobie Krolak", null, 411016, "Mag" },
                    { 607, "Matilde Bartoleyn", null, 412026, "DI Dr" },
                    { 608, "Alena Sprionghall", null, 412026, "DI" },
                    { 609, "Vitia Pratley", null, 401417, "Mag DI" },
                    { 610, "Nicolina Mawditt", null, 402417, "Dr" },
                    { 602, "Marnia Druhan", null, 408016, "Mag" },
                    { 569, "Lillian Ollarenshaw", null, 407417, "Mag DI" },
                    { 591, "Dagmar Makinson", null, 414437, "MMag" },
                    { 589, "Brenn Gillooly", null, 412026, "Mag DI" },
                    { 571, "Mead Loiterton", null, 403427, "Dr" },
                    { 572, "Tedi Ablewhite", null, 417427, "Dr" },
                    { 573, "Doralynn Ramelot", null, 412477, "Mag DI" },
                    { 574, "Gayle Reyes", null, 413417, "Mag DI" },
                    { 575, "Keene Matthews", null, 411457, "Dr" },
                    { 576, "Bambi Meecher", null, 411016, "DI Dr" },
                    { 577, "Carmelia Waddingham", null, 413447, "MMag" },
                    { 578, "Winne Rabbitts", null, 409036, "Mag" },
                    { 590, "Dougy Thomsen", null, 410457, "DI" },
                    { 579, "Drud Simonnin", null, 401046, "Mag" },
                    { 581, "Xenia Allwood", null, 413417, "Mag DI" },
                    { 582, "Hakim Jesson", null, 410457, "Mag" },
                    { 583, "Vi Hassall", null, 410457, "MMag" },
                    { 584, "Sharon MacClay", null, 408016, "Mag DI" },
                    { 585, "Osmond Stennings", null, 417427, "Dr" },
                    { 586, "Leoine McKernan", null, 408427, "Dr" },
                    { 587, "Carolus Harner", null, 409036, "Mag" },
                    { 588, "Wyn Parsell", null, 411016, "Mag DI" },
                    { 580, "Arleyne Gillam", null, 401417, "DI Dr" },
                    { 350, "Freedman Gladtbach", null, 412477, "Dr" },
                    { 339, "Hazlett Lowen", null, 402417, "DI Dr" },
                    { 348, "Jacqui Kondrat", null, 412026, "Mag" },
                    { 111, "Mord Lansley", null, 403457, "Mag" },
                    { 112, "Eustacia Kinnen", null, 411016, "DI Dr" },
                    { 113, "Maria Valero", null, 410427, "MMag" },
                    { 114, "Emilee Poyle", null, 412477, "Mag DI" },
                    { 115, "Paolina Slimme", null, 408016, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 116, "Amandy Mangion", null, 403427, "Mag DI" },
                    { 117, "Kandace Crowson", null, 409036, "DI Dr" },
                    { 118, "Erminia Tunney", null, 411457, "MMag" },
                    { 119, "Lev Tidcombe", null, 403457, "MMag" },
                    { 120, "Theodore Duckitt", null, 411457, "DI" },
                    { 121, "Noelle Stening", null, 417427, "Mag" },
                    { 122, "Kent Elbourne", null, 402417, "Mag DI" },
                    { 123, "Berty Keenor", null, 408427, "Mag DI" },
                    { 124, "Melloney O'Fallowne", null, 404427, "MMag" },
                    { 125, "Lalo Petren", null, 414437, "Mag DI" },
                    { 126, "Lulu Lawley", null, 401046, "DI" },
                    { 127, "Addison Ritchman", null, 401417, "Dr" },
                    { 110, "Wallis Lamden", null, 401046, "MMag" },
                    { 109, "Payton Juza", null, 407417, "MMag" },
                    { 108, "Darice Derycot", null, 413447, "Mag" },
                    { 107, "Bernardo Jenik", null, 403457, "DI Dr" },
                    { 89, "Mohandas Derrell", null, 414437, "Mag" },
                    { 90, "Alvina Hayman", null, 401417, "Mag DI" },
                    { 91, "Camille Sandal", null, 411457, "Mag DI" },
                    { 92, "Cob Bellhouse", null, 416016, "MMag" },
                    { 93, "Carie Boerderman", null, 414437, "Mag DI" },
                    { 94, "Dalt Coghlin", null, 410457, "DI Dr" },
                    { 95, "Anders Bessell", null, 412477, "Dr" },
                    { 96, "Marget Dombrell", null, 412026, "DI Dr" },
                    { 128, "Moritz Swaile", null, 413417, "MMag" },
                    { 97, "Ernst Allflatt", null, 413447, "Mag" },
                    { 99, "Lucas Casillas", null, 412477, "MMag" },
                    { 100, "Nancie Gymblett", null, 412026, "Mag" },
                    { 101, "Johnath Ratazzi", null, 407417, "Mag DI" },
                    { 102, "Darice Lewsley", null, 407417, "Mag" },
                    { 103, "Claudetta Lynskey", null, 403427, "DI" },
                    { 104, "Giulio Pitcher", null, 417427, "Dr" },
                    { 105, "Kynthia Yonge", null, 403427, "MMag" },
                    { 106, "Gottfried Groarty", null, 413417, "DI Dr" },
                    { 98, "Rudolf Southcott", null, 408427, "Mag" },
                    { 129, "Nita Pappi", null, 403427, "MMag" },
                    { 130, "Lila Muckeen", null, 409036, "DI" },
                    { 131, "Libbi Meachen", null, 401046, "DI Dr" },
                    { 154, "Alick Sutherley", null, 411457, "Dr" },
                    { 155, "Lonni Cawsy", null, 413417, "DI Dr" },
                    { 156, "Ibby Escala", null, 408427, "DI Dr" },
                    { 157, "Felicity Dowd", null, 412477, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 158, "Pierce Basire", null, 403457, "Mag DI" },
                    { 159, "Burk Millmore", null, 413417, "Dr" },
                    { 160, "Aldridge Rysdale", null, 402417, "MMag" },
                    { 161, "Mollee Ruslen", null, 417427, "DI" },
                    { 153, "Dorette Skingle", null, 401046, "DI Dr" },
                    { 162, "Tessa Massy", null, 401467, "DI Dr" },
                    { 164, "Mata Rumin", null, 412026, "MMag" },
                    { 165, "Laney Aberchirder", null, 413417, "Mag" },
                    { 166, "Felita Trays", null, 412477, "Mag" },
                    { 167, "Cozmo Cobon", null, 413417, "Mag DI" },
                    { 168, "Loise Frampton", null, 401417, "DI" },
                    { 169, "Natty Allner", null, 412477, "Mag" },
                    { 170, "Jany Rulten", null, 407417, "MMag" },
                    { 171, "Verena Louys", null, 410427, "DI" },
                    { 163, "Charo Josskowitz", null, 410427, "Mag DI" },
                    { 88, "Laureen Cadore", null, 412477, "Mag" },
                    { 152, "Shanta Lodevick", null, 408427, "Mag" },
                    { 150, "Ree Collar", null, 407417, "Mag DI" },
                    { 132, "Saunders Bes", null, 416016, "Mag" },
                    { 133, "Dion Cowton", null, 412026, "Dr" },
                    { 134, "Elnar Storek", null, 408016, "Mag" },
                    { 135, "Derward Spores", null, 403427, "DI Dr" },
                    { 136, "Conrado Cockley", null, 410457, "Dr" },
                    { 137, "Maryrose McGonigal", null, 411016, "DI Dr" },
                    { 138, "Delcine Le Prevost", null, 407417, "MMag" },
                    { 139, "Cherish Franzke", null, 401417, "MMag" },
                    { 151, "Richart Seaking", null, 411457, "Mag" },
                    { 140, "Borg Bigglestone", null, 412477, "Mag DI" },
                    { 142, "Aymer Lowndes", null, 401046, "Mag DI" },
                    { 143, "Bruce Brankley", null, 407417, "Mag DI" },
                    { 144, "Francyne Erwin", null, 401417, "MMag" },
                    { 145, "Alwin Folks", null, 411016, "DI" },
                    { 146, "Verla Newbold", null, 404427, "DI" },
                    { 147, "Thacher Booth", null, 408427, "Mag DI" },
                    { 148, "Robinette Raddish", null, 402417, "DI Dr" },
                    { 149, "Babita Pocklington", null, 410427, "Mag DI" },
                    { 141, "Lowell Bessom", null, 407417, "Mag DI" },
                    { 87, "Hillary Folley", null, 413447, "DI Dr" },
                    { 86, "Milzie Alty", null, 408016, "Dr" },
                    { 85, "Estrellita Pitchers", null, 411016, "Dr" },
                    { 23, "Rodolfo Thomsson", null, 411457, "MMag" },
                    { 24, "Loretta Lyle", null, 410457, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 25, "Gallard MacGuiness", null, 417427, "MMag" },
                    { 26, "Lewes Chesshyre", null, 409036, "Mag" },
                    { 27, "Patty Raselles", null, 410457, "Dr" },
                    { 28, "Ruddy Loughead", null, 407417, "MMag" },
                    { 29, "Junia Stern", null, 401046, "Mag DI" },
                    { 30, "Jobie Jakobssen", null, 412026, "DI Dr" },
                    { 22, "Beth Kemshell", null, 409036, "DI Dr" },
                    { 31, "Kelsy Devil", null, 408016, "DI" },
                    { 33, "Gerti Hirche", null, 411016, "Dr" },
                    { 34, "Maribeth Yerrall", null, 402417, "DI" },
                    { 35, "Hillie Frankton", null, 410427, "MMag" },
                    { 36, "Jeramie Confort", null, 403457, "Mag" },
                    { 37, "Port Jennaway", null, 413417, "DI Dr" },
                    { 38, "Woodman Rofe", null, 413447, "MMag" },
                    { 39, "Svend Vaen", null, 401417, "Dr" },
                    { 40, "Filippo Killwick", null, 413417, "Dr" },
                    { 32, "Kirsten Denington", null, 410427, "DI Dr" },
                    { 41, "Stevana Hudspith", null, 410457, "MMag" },
                    { 21, "Isabelle Sproson", null, 402417, "MMag" },
                    { 19, "Sadye Dudgeon", null, 403427, "DI Dr" },
                    { 1, "Kip Harnett", null, 404427, "DI Dr" },
                    { 2, "Baillie Alpine", null, 413447, "DI" },
                    { 3, "Elnore Fetherstone", null, 411016, "MMag" },
                    { 4, "Rickard Bencher", null, 411016, "Mag DI" },
                    { 5, "Lewes Romanin", null, 410427, "Mag" },
                    { 6, "Barton McTeague", null, 401467, "Dr" },
                    { 7, "Davey Gould", null, 401467, "DI Dr" },
                    { 8, "Florencia Howarth", null, 403457, "Mag DI" },
                    { 20, "Terrie Mattis", null, 403457, "Mag" },
                    { 9, "Bearnard Elner", null, 410457, "DI" },
                    { 11, "Bryon Lyburn", null, 403457, "DI" },
                    { 12, "Daniela Golsthorp", null, 414437, "MMag" },
                    { 13, "Simone Rubberts", null, 408427, "Mag DI" },
                    { 14, "Lian Corcoran", null, 412477, "MMag" },
                    { 15, "Demetris Mapston", null, 414437, "DI Dr" },
                    { 16, "Sholom Van Cassel", null, 412026, "MMag" },
                    { 17, "Karissa Antao", null, 416016, "Mag DI" },
                    { 18, "Noreen Devonish", null, 410427, "Mag" },
                    { 10, "Sacha Simmings", null, 411457, "MMag" },
                    { 172, "Bobbette Grewe", null, 413447, "Mag DI" },
                    { 42, "Amory Alywen", null, 408427, "Mag" },
                    { 44, "Corny Lightowler", null, 410427, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 67, "Gert Dansken", null, 411457, "DI Dr" },
                    { 68, "Frants Martelet", null, 401046, "Mag" },
                    { 69, "Pietro Tant", null, 417427, "MMag" },
                    { 70, "Rahel Tinwell", null, 404427, "Mag DI" },
                    { 71, "Tito Beatey", null, 413417, "DI Dr" },
                    { 72, "Hamil Deesly", null, 407417, "DI Dr" },
                    { 73, "Laurella Darch", null, 407417, "Dr" },
                    { 74, "Blayne Southey", null, 407417, "DI Dr" },
                    { 66, "Martica Dawidowsky", null, 401417, "Dr" },
                    { 75, "Eleen Moloney", null, 408016, "DI Dr" },
                    { 77, "Dal Biesterfeld", null, 401417, "Mag" },
                    { 78, "Patty Smurfitt", null, 401046, "Mag" },
                    { 79, "Vinni Guilloux", null, 401467, "DI Dr" },
                    { 80, "Anissa Allbut", null, 402417, "DI Dr" },
                    { 81, "Goddard Issac", null, 413447, "Mag DI" },
                    { 82, "Gaylene Morrel", null, 412026, "Dr" },
                    { 83, "Nadia Bundock", null, 402417, "DI Dr" },
                    { 84, "Florinda Aylwin", null, 417427, "MMag" },
                    { 76, "Cris Maasz", null, 410457, "DI" },
                    { 43, "Kirsten Innes", null, 417427, "MMag" },
                    { 65, "Davine Pomfrey", null, 401417, "DI Dr" },
                    { 63, "Spenser Roder", null, 409036, "Mag DI" },
                    { 45, "Lory Bartkiewicz", null, 413417, "MMag" },
                    { 46, "Anny Bugg", null, 412477, "DI Dr" },
                    { 47, "Milt Vinau", null, 403427, "DI" },
                    { 48, "Nadya Pottell", null, 401467, "Dr" },
                    { 49, "Clarey Yerby", null, 413417, "DI Dr" },
                    { 50, "Barris Warrillow", null, 407417, "Mag" },
                    { 51, "Son Harfleet", null, 411457, "MMag" },
                    { 52, "Clevey McAughtrie", null, 407417, "DI Dr" },
                    { 64, "Marga Hess", null, 407417, "DI Dr" },
                    { 53, "Alta Quinnette", null, 401467, "DI Dr" },
                    { 55, "Leontine McDaid", null, 416016, "Dr" },
                    { 56, "Gil Ivashkin", null, 401417, "DI" },
                    { 57, "Heloise Inchbald", null, 411016, "Mag" },
                    { 58, "Brandy de Courcey", null, 416016, "DI" },
                    { 59, "Antonella Boots", null, 412026, "DI Dr" },
                    { 60, "Oona Kildea", null, 412026, "DI" },
                    { 61, "Lefty Lavalde", null, 401417, "Mag" },
                    { 62, "Corey Folca", null, 402417, "Mag DI" },
                    { 54, "Waylon Wavish", null, 412026, "MMag" },
                    { 173, "Celene Overstreet", null, 403457, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 174, "Tom Davidwitz", null, 417427, "Dr" },
                    { 175, "Serene Ramm", null, 408016, "Dr" },
                    { 286, "Silvie Leyman", null, 417427, "Mag" },
                    { 287, "Randi Kinnier", null, 411016, "DI" },
                    { 288, "Ferrell Sellar", null, 410427, "Mag" },
                    { 289, "Benedick Morrant", null, 408427, "Mag" },
                    { 290, "Rafi Mc Andrew", null, 414437, "Dr" },
                    { 291, "Mair Streets", null, 417427, "Mag DI" },
                    { 292, "Sammie Parres", null, 403457, "Dr" },
                    { 293, "Sharia Videler", null, 412026, "Mag DI" },
                    { 285, "Riannon Yarnley", null, 404427, "Mag" },
                    { 294, "Kaleb Williamson", null, 413417, "MMag" },
                    { 296, "Tresa Weighell", null, 401046, "Mag" },
                    { 297, "Ezechiel Potteridge", null, 411457, "MMag" },
                    { 298, "Dyanna Camelli", null, 417427, "MMag" },
                    { 299, "Kip Ivanets", null, 408016, "Mag" },
                    { 300, "Fidel Skrine", null, 402417, "DI" },
                    { 301, "Tedie McKag", null, 413447, "Mag DI" },
                    { 302, "Lynn Succamore", null, 410427, "MMag" },
                    { 303, "Agatha Jodlkowski", null, 412026, "MMag" },
                    { 295, "Olive Chilcott", null, 410457, "Mag" },
                    { 304, "Artus Ferrelli", null, 404427, "MMag" },
                    { 284, "Jan Vern", null, 402417, "DI" },
                    { 282, "Ettore Maffin", null, 404427, "Dr" },
                    { 264, "Brook Oppy", null, 417427, "Dr" },
                    { 265, "Dorisa Wilcott", null, 401046, "MMag" },
                    { 266, "Howard Petken", null, 409036, "Mag" },
                    { 267, "Artemas Jedrychowski", null, 414437, "DI" },
                    { 268, "Auguste Vogt", null, 417427, "DI" },
                    { 269, "Elbertina Skirven", null, 413447, "Mag" },
                    { 270, "Marlene Cumes", null, 408427, "Mag" },
                    { 271, "Beale Croad", null, 408427, "DI Dr" },
                    { 283, "Barn Clynman", null, 402417, "Mag" },
                    { 272, "Letisha Aleksahkin", null, 416016, "Mag" },
                    { 274, "Flossi Baggallay", null, 403457, "Mag DI" },
                    { 275, "Willi Maysor", null, 409036, "Dr" },
                    { 276, "Giana Gloyens", null, 408427, "MMag" },
                    { 277, "Skippie Jaynes", null, 416016, "DI" },
                    { 278, "Goldy O'Currine", null, 401467, "Dr" },
                    { 279, "Opalina Scatchar", null, 417427, "Dr" },
                    { 280, "Jaquelin Pren", null, 413447, "Mag" },
                    { 281, "Florrie Domesday", null, 403427, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 273, "Alyss Brunone", null, 409036, "DI" },
                    { 263, "Ravi O'Neal", null, 410427, "DI Dr" },
                    { 305, "Claretta Galpen", null, 408016, "DI Dr" },
                    { 307, "Saraann Wilsher", null, 409036, "MMag" },
                    { 330, "Rozalie Huckleby", null, 412026, "Dr" },
                    { 331, "Harlen Klinck", null, 402417, "MMag" },
                    { 332, "Amity Tayloe", null, 416016, "Mag" },
                    { 333, "Hugues Greer", null, 404427, "Mag DI" },
                    { 334, "Maiga Schimank", null, 404427, "Mag" },
                    { 335, "Fayina Mongin", null, 409036, "DI" },
                    { 336, "Isahella Clench", null, 413417, "Mag" },
                    { 337, "Currey Windham", null, 412477, "Mag DI" },
                    { 329, "Cordy Smowton", null, 417427, "DI Dr" },
                    { 338, "Lenna Lear", null, 416016, "Dr" },
                    { 340, "Vernon O'Cannavan", null, 403457, "DI" },
                    { 341, "Skylar Skyme", null, 401046, "DI Dr" },
                    { 342, "Seumas Spurdens", null, 411457, "Dr" },
                    { 343, "Reagen Mower", null, 408016, "MMag" },
                    { 344, "Terrel Noyce", null, 414437, "Dr" },
                    { 345, "Annalee Dmitrichenko", null, 409036, "Mag DI" },
                    { 346, "Gran Barnewell", null, 412477, "Mag" },
                    { 347, "Nichole Knibb", null, 401467, "Mag DI" },
                    { 699, "Gizela Nussgen", null, 404427, "DI Dr" },
                    { 306, "Vale Gosselin", null, 417427, "Dr" },
                    { 328, "Carlynne Crannach", null, 411457, "DI Dr" },
                    { 326, "Wash Gieraths", null, 417427, "Mag" },
                    { 308, "Bili Vitte", null, 413447, "Mag DI" },
                    { 309, "Maible de Marco", null, 416016, "MMag" },
                    { 310, "Kristi Zorn", null, 408016, "Mag DI" },
                    { 311, "Krystalle Kryska", null, 401467, "DI" },
                    { 312, "Saul Johncey", null, 411457, "Mag" },
                    { 313, "Tiffy Behnecke", null, 401467, "Dr" },
                    { 314, "Sterne Waywell", null, 411457, "Mag" },
                    { 315, "Anatole McSperrin", null, 416016, "Dr" },
                    { 327, "Reta Ranstead", null, 404427, "Dr" },
                    { 316, "Connie D'Oyly", null, 410457, "MMag" },
                    { 318, "Bevvy Newlove", null, 413447, "Dr" },
                    { 319, "Antoine Clemmens", null, 404427, "DI Dr" },
                    { 320, "Burty Wybern", null, 411016, "Dr" },
                    { 321, "Ephrayim Puvia", null, 407417, "Dr" },
                    { 322, "Arabelle Gerald", null, 412026, "DI Dr" },
                    { 323, "Andie Le Gall", null, 401417, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 324, "Cointon Mallya", null, 411457, "Mag" },
                    { 325, "Immanuel Spuffard", null, 408427, "Dr" },
                    { 317, "Romola Baume", null, 411016, "DI" },
                    { 349, "Winifield Mewe", null, 408016, "Mag" },
                    { 262, "Baxter Arran", null, 411457, "Mag DI" },
                    { 260, "Vikki O'Dunneen", null, 409036, "DI Dr" },
                    { 198, "Dorrie Netley", null, 403427, "Mag" },
                    { 199, "Chance Benoit", null, 407417, "Mag" },
                    { 200, "Milena Patshull", null, 413417, "MMag" },
                    { 201, "Carmita Seston", null, 401417, "MMag" },
                    { 202, "Edik Clitherow", null, 401046, "MMag" },
                    { 203, "Erica Castilla", null, 407417, "Dr" },
                    { 204, "Eugenio O' Faherty", null, 403427, "MMag" },
                    { 205, "Carolyn Lindenman", null, 413417, "MMag" },
                    { 197, "Brian Ackery", null, 414437, "MMag" },
                    { 206, "Pauli Barron", null, 411457, "DI Dr" },
                    { 208, "Allegra Sellstrom", null, 414437, "DI" },
                    { 209, "Christos Regis", null, 401046, "Mag DI" },
                    { 210, "Bess Weed", null, 408427, "Mag DI" },
                    { 211, "Sandy Wyllcock", null, 412026, "DI" },
                    { 212, "Jamaal Peevor", null, 410457, "MMag" },
                    { 213, "Patin Brunet", null, 401467, "Dr" },
                    { 214, "Grata Cereceres", null, 413447, "DI Dr" },
                    { 215, "Lotti Hunnam", null, 408427, "DI" },
                    { 207, "Ruthe O'Gorman", null, 407417, "Mag DI" },
                    { 216, "Ofella Kimmins", null, 409036, "Dr" },
                    { 196, "Myra Cossons", null, 408427, "MMag" },
                    { 194, "Caro Mees", null, 408427, "Mag" },
                    { 176, "Oswell Goodlett", null, 403457, "MMag" },
                    { 177, "Blake Hankard", null, 413417, "Mag" },
                    { 178, "Nola Onge", null, 409036, "MMag" },
                    { 179, "Hewett Saker", null, 408016, "Dr" },
                    { 180, "Brannon McGeown", null, 407417, "Dr" },
                    { 181, "Lurline Boatswain", null, 401467, "Mag" },
                    { 182, "Konrad Haslum", null, 407417, "MMag" },
                    { 183, "Munroe Ivanilov", null, 414437, "Mag" },
                    { 195, "Nert Pitts", null, 408016, "Mag DI" },
                    { 184, "Burlie Antonescu", null, 410427, "DI" },
                    { 186, "Carita Billyard", null, 410427, "DI" },
                    { 187, "Calli Skillen", null, 412026, "DI Dr" },
                    { 188, "Vicki Rickarsey", null, 409036, "DI" },
                    { 189, "Stephie Setford", null, 411457, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 190, "Fairleigh Snowling", null, 412477, "Mag" },
                    { 191, "Hortensia Hazeup", null, 401467, "DI Dr" },
                    { 192, "Fred Yepiskov", null, 413417, "Mag DI" },
                    { 193, "Ricoriki Whyatt", null, 404427, "Mag" },
                    { 185, "Sig Harborow", null, 401467, "Dr" },
                    { 261, "My Sorsbie", null, 416016, "DI Dr" },
                    { 217, "Mendel Naris", null, 403457, "DI Dr" },
                    { 219, "Arluene Torrans", null, 403427, "Mag" },
                    { 242, "Letitia McNish", null, 401467, "MMag" },
                    { 243, "Care Deelay", null, 404427, "Mag DI" },
                    { 244, "Kym Leechman", null, 412477, "MMag" },
                    { 245, "Devin Ferries", null, 410457, "Mag DI" },
                    { 246, "Marcile Tavernor", null, 409036, "Mag" },
                    { 247, "Alix Warricker", null, 407417, "DI Dr" },
                    { 248, "Hildagarde Staveley", null, 414437, "DI Dr" },
                    { 249, "Hayyim Gatrell", null, 411457, "DI" },
                    { 241, "Abby Eagle", null, 403427, "MMag" },
                    { 250, "Justus Richichi", null, 411016, "Mag DI" },
                    { 252, "Callean Antonetti", null, 416016, "Dr" },
                    { 253, "Tish Abrashkin", null, 410427, "DI Dr" },
                    { 254, "Ranee Krochmann", null, 411457, "Mag" },
                    { 255, "Othelia Juggings", null, 413447, "MMag" },
                    { 256, "Courtney O' Byrne", null, 404427, "Mag DI" },
                    { 257, "Karisa Fraser", null, 408427, "Mag" },
                    { 258, "Latashia Somes", null, 414437, "MMag" },
                    { 259, "Geri Janca", null, 413447, "DI" },
                    { 251, "Gay Sheehan", null, 412026, "DI Dr" },
                    { 218, "Brinn Joselevitch", null, 413417, "MMag" },
                    { 240, "Gene Turbefield", null, 404427, "MMag" },
                    { 238, "Lyssa Syder", null, 402417, "DI" },
                    { 220, "Isidoro Astell", null, 408016, "MMag" },
                    { 221, "Minnnie Pechet", null, 403457, "MMag" },
                    { 222, "Kariotta Leith-Harvey", null, 414437, "Mag" },
                    { 223, "Isador Snailham", null, 411457, "DI" },
                    { 224, "Filip Caddie", null, 410427, "Mag" },
                    { 225, "Rolfe Dunks", null, 401467, "Mag DI" },
                    { 226, "Verene Suffield", null, 401046, "Mag DI" },
                    { 227, "Vachel Last", null, 409036, "Mag DI" },
                    { 239, "Stillmann Linnard", null, 417427, "DI" },
                    { 228, "Cosme Kennelly", null, 416016, "Dr" },
                    { 230, "Mendie Bartusek", null, 407417, "Mag DI" },
                    { 231, "Lorenza Kevlin", null, 408427, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "SchoolNumber", "Title" },
                values: new object[,]
                {
                    { 232, "Amalita L'Hommee", null, 404427, "Mag" },
                    { 233, "Isador Basezzi", null, 412026, "Mag" },
                    { 234, "Demetre Sabberton", null, 417427, "DI" },
                    { 235, "Leonard Duddell", null, 408016, "Mag DI" },
                    { 236, "Gale Strelitz", null, 401046, "DI" },
                    { 237, "Coleen Bleythin", null, 401417, "Dr" },
                    { 229, "Giffard Covotto", null, 411016, "DI" },
                    { 700, "Sibel MacMenamy", null, 401046, "Dr" }
                });

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
