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
                    SchoolId = table.Column<int>(type: "int", nullable: true)
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
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 467, "Robyn Ewbach", null, "Mag DI" },
                    { 466, "Tomlin Billin", null, "MMag" },
                    { 462, "Archambault Jelks", null, "DI" },
                    { 464, "Anatol Gemlett", null, "DI Dr" },
                    { 463, "Butch Haly", null, "MMag" },
                    { 468, "Jon Schrader", null, "DI" },
                    { 465, "Iolanthe Nelles", null, "DI Dr" },
                    { 469, "Catherin Revington", null, "Mag DI" },
                    { 474, "Marna Pilipyak", null, "DI Dr" },
                    { 471, "Stanly Librey", null, "Dr" },
                    { 472, "Benita Brearley", null, "MMag" },
                    { 473, "Inger Proudley", null, "DI Dr" },
                    { 475, "Elwira Minker", null, "DI Dr" },
                    { 476, "Thorsten Samways", null, "MMag" },
                    { 477, "Magnum Scading", null, "DI" },
                    { 478, "Devi Dillinger", null, "MMag" },
                    { 461, "Arch Lemasney", null, "Dr" },
                    { 470, "Doll Gove", null, "DI Dr" },
                    { 460, "Michell Huckleby", null, "DI" },
                    { 449, "Hallie Keslake", null, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 458, "Vikki Josupeit", null, "Mag" },
                    { 440, "Joline Shugg", null, "Dr" },
                    { 441, "Tammie Rawsthorn", null, "DI" },
                    { 442, "Sayre Skae", null, "DI" },
                    { 443, "Ninon Hanscome", null, "MMag" },
                    { 444, "Aldridge Mattioli", null, "DI Dr" },
                    { 445, "Frazier Rasher", null, "MMag" },
                    { 446, "Alisa Zellick", null, "DI Dr" },
                    { 447, "Inigo Gyorffy", null, "MMag" },
                    { 459, "Eba Castellaccio", null, "MMag" },
                    { 448, "Rosalind Wardel", null, "Dr" },
                    { 450, "Burr Callcott", null, "Mag DI" },
                    { 451, "Terri O' Gara", null, "Dr" },
                    { 452, "Minda Fullstone", null, "DI" },
                    { 453, "Talia Stonard", null, "DI" },
                    { 454, "Briney Niesing", null, "Mag DI" },
                    { 455, "Libbey Frean", null, "Dr" },
                    { 456, "Benoite Cusack", null, "DI Dr" },
                    { 457, "Park Regorz", null, "Mag" },
                    { 479, "Danit Peiser", null, "Mag" },
                    { 480, "Hugues Phette", null, "Dr" },
                    { 491, "Caleb Verey", null, "MMag" },
                    { 482, "Aguistin Skewis", null, "Mag" },
                    { 505, "Vinny Ixor", null, "DI" },
                    { 506, "Kimmi Astley", null, "Mag DI" },
                    { 507, "Paolina Cluney", null, "MMag" },
                    { 508, "Kassandra Shillington", null, "Mag" },
                    { 509, "Ebonee Squelch", null, "DI" },
                    { 510, "Annemarie Verdie", null, "Mag" },
                    { 511, "Lara Jennison", null, "MMag" },
                    { 512, "Kelli Curds", null, "Mag" },
                    { 504, "Melly Curtayne", null, "MMag" },
                    { 513, "Tessie Raunds", null, "DI Dr" },
                    { 515, "Aprilette Gain", null, "Dr" },
                    { 516, "Neddy Summers", null, "Mag DI" },
                    { 517, "Maurene Truitt", null, "Dr" },
                    { 518, "Sherman O'Hartnedy", null, "Mag" },
                    { 519, "Gilbertine de Savery", null, "Mag" },
                    { 520, "Field Harburtson", null, "Mag" },
                    { 521, "Trisha Iacapucci", null, "MMag" },
                    { 522, "Hazel Bullent", null, "DI" },
                    { 514, "Lexy Watkiss", null, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 481, "Ab Aime", null, "Dr" },
                    { 503, "Nicoli Volke", null, "Mag DI" },
                    { 501, "Ferris Petchey", null, "Mag" },
                    { 483, "Caria Ovill", null, "MMag" },
                    { 484, "Ange Sayton", null, "Mag DI" },
                    { 485, "Jillayne Hendren", null, "MMag" },
                    { 486, "Wiatt Freegard", null, "Mag DI" },
                    { 487, "Obadiah Dosdale", null, "Mag DI" },
                    { 488, "Maryann Dewey", null, "MMag" },
                    { 489, "Hyacinthia Durrett", null, "Mag DI" },
                    { 490, "Kellie McCleod", null, "Dr" },
                    { 502, "Damian Kirkup", null, "Mag" },
                    { 439, "Cristiano Forde", null, "Mag" },
                    { 493, "Hugibert Cotterill", null, "DI" },
                    { 494, "Elsbeth Smeeton", null, "DI" },
                    { 495, "Suellen Berge", null, "Dr" },
                    { 496, "Maxwell Secombe", null, "Mag DI" },
                    { 497, "Olympia Mottley", null, "Mag" },
                    { 498, "Bord Coleyshaw", null, "DI" },
                    { 499, "Denny Iacofo", null, "Mag DI" },
                    { 500, "Jobina Gianulli", null, "DI" },
                    { 492, "Vernen Sprouls", null, "Dr" },
                    { 438, "Bennett Naile", null, "Dr" },
                    { 427, "George Straun", null, "Mag" },
                    { 436, "Bobette Ferraresi", null, "Mag DI" },
                    { 374, "Dennie Ivons", null, "Dr" },
                    { 375, "Dario Londsdale", null, "Dr" },
                    { 376, "Tish Kayzer", null, "DI" },
                    { 377, "Hyatt Heck", null, "DI" },
                    { 378, "Jessy Sheerman", null, "Dr" },
                    { 379, "Grata Lingfoot", null, "Mag" },
                    { 380, "Gearalt Birnie", null, "DI Dr" },
                    { 381, "Perren Ghilardini", null, "MMag" },
                    { 373, "Koo Cowley", null, "DI Dr" },
                    { 382, "Dennie Dahlbom", null, "Mag" },
                    { 384, "Hertha Pikett", null, "Mag DI" },
                    { 385, "Cordie Gritsunov", null, "DI" },
                    { 386, "Hermina Dorney", null, "Mag DI" },
                    { 387, "Lanita Dunsire", null, "MMag" },
                    { 388, "Marja Bigglestone", null, "Mag DI" },
                    { 389, "Fina Figiovanni", null, "DI" },
                    { 390, "Neddy Gladman", null, "Mag DI" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 391, "Sheridan McDirmid", null, "Dr" },
                    { 383, "Ebenezer Catton", null, "Dr" },
                    { 392, "Car Callard", null, "Dr" },
                    { 372, "Lonee Cran", null, "Dr" },
                    { 370, "Hastie Willsmore", null, "Mag" },
                    { 352, "Verla Scourfield", null, "DI Dr" },
                    { 353, "Wylma Godball", null, "Dr" },
                    { 354, "Coop Pountney", null, "Dr" },
                    { 355, "Xerxes Pentelow", null, "DI Dr" },
                    { 356, "Ana Delgardillo", null, "DI" },
                    { 357, "Antoni Hulse", null, "DI" },
                    { 358, "Yolande Kembley", null, "Dr" },
                    { 359, "Brett Borrill", null, "MMag" },
                    { 371, "Morgana O' Donohoe", null, "DI" },
                    { 360, "Madison Waller-Bridge", null, "MMag" },
                    { 362, "Wald Mallender", null, "Dr" },
                    { 363, "Bevan Worters", null, "DI" },
                    { 364, "Tailor Engledow", null, "DI" },
                    { 365, "Lane Siggery", null, "Mag" },
                    { 366, "Waldon Buttler", null, "MMag" },
                    { 367, "Ulrica Blain", null, "DI" },
                    { 368, "Jaimie Batham", null, "DI" },
                    { 369, "Trixy Goodanew", null, "DI Dr" },
                    { 361, "Torin Edelheit", null, "DI" },
                    { 437, "Maje Pettecrew", null, "Mag DI" },
                    { 393, "Suzy Olyfant", null, "Dr" },
                    { 395, "Ira Leadbeater", null, "MMag" },
                    { 418, "Fawn Jamblin", null, "Dr" },
                    { 419, "Rudolfo Dormer", null, "Dr" },
                    { 420, "Kristien Tunsley", null, "Dr" },
                    { 421, "Odille Kingswoode", null, "Mag" },
                    { 422, "Ad Greave", null, "DI Dr" },
                    { 423, "Martyn Ezzy", null, "Mag" },
                    { 424, "Penrod Clancey", null, "Dr" },
                    { 425, "Jenny Mangon", null, "Mag" },
                    { 417, "Nollie Haggarth", null, "Mag" },
                    { 426, "Giacopo Allbones", null, "Mag" },
                    { 428, "Maisie Offiler", null, "DI Dr" },
                    { 429, "Valentia Reeds", null, "DI Dr" },
                    { 430, "Tarrance MacMearty", null, "Mag DI" },
                    { 431, "Freddy Swires", null, "DI" },
                    { 432, "Libbie Haddacks", null, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 433, "Constantino Lawlance", null, "MMag" },
                    { 434, "Hirsch Shama", null, "Mag" },
                    { 435, "Lorelle Orrom", null, "Mag" },
                    { 523, "Issie Moyce", null, "Mag DI" },
                    { 394, "Shirline Hamshar", null, "DI Dr" },
                    { 416, "Aldon Biagioni", null, "MMag" },
                    { 414, "Justis Troup", null, "DI Dr" },
                    { 396, "Berke Diable", null, "MMag" },
                    { 397, "Anderson Phayre", null, "Dr" },
                    { 398, "Belia Tideswell", null, "DI" },
                    { 399, "Dosi Fancet", null, "Dr" },
                    { 400, "Johnath Sherrott", null, "Mag" },
                    { 401, "Lawrence Bamblett", null, "Mag" },
                    { 402, "Audre Larmett", null, "Mag" },
                    { 403, "Ramona Franzelini", null, "MMag" },
                    { 415, "Marleen Ort", null, "DI" },
                    { 404, "Vite Astling", null, "DI" },
                    { 406, "Luce Duran", null, "Mag DI" },
                    { 407, "Jillie Duffit", null, "MMag" },
                    { 408, "Caterina Hawkings", null, "Mag DI" },
                    { 409, "Corrianne Rumbold", null, "MMag" },
                    { 410, "Frederico Cossey", null, "MMag" },
                    { 411, "Cloe Sadler", null, "Dr" },
                    { 412, "Galvin Antoniou", null, "Dr" },
                    { 413, "Joyous Kingswood", null, "Mag DI" },
                    { 405, "Jose Barroux", null, "DI Dr" },
                    { 524, "Rutger Jessop", null, "DI" },
                    { 535, "Eadith Cobley", null, "DI" },
                    { 526, "Mildred Begbie", null, "Mag" },
                    { 637, "Ambur Leopard", null, "Mag" },
                    { 638, "Brendon Lendrem", null, "DI Dr" },
                    { 639, "Eilis Standrin", null, "Mag" },
                    { 640, "Alfredo Strangeway", null, "Mag DI" },
                    { 641, "Sheffie Digg", null, "Dr" },
                    { 642, "Ebenezer Goodall", null, "DI" },
                    { 643, "Nessie Myrick", null, "DI" },
                    { 644, "Randolf Gribbin", null, "Dr" },
                    { 636, "Allianora Schach", null, "DI" },
                    { 645, "Cristi Ganter", null, "DI Dr" },
                    { 647, "Vilhelmina Abramchik", null, "Mag DI" },
                    { 648, "Sean MacLeese", null, "DI Dr" },
                    { 649, "Gottfried Haxby", null, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 650, "Justen Willshire", null, "MMag" },
                    { 651, "Kirstin Bindley", null, "DI Dr" },
                    { 652, "Adrien Keighley", null, "DI Dr" },
                    { 653, "Raimund Klemps", null, "DI Dr" },
                    { 654, "Phedra Whieldon", null, "MMag" },
                    { 646, "Merline Styche", null, "DI Dr" },
                    { 655, "Joanne Dreelan", null, "DI Dr" },
                    { 635, "Granny Sedgmond", null, "Dr" },
                    { 633, "Mabel Sturgis", null, "Mag" },
                    { 615, "Britney Paty", null, "MMag" },
                    { 616, "Kessia Goldes", null, "Mag" },
                    { 617, "Alika Speek", null, "DI" },
                    { 618, "Trixie Lambertson", null, "Dr" },
                    { 619, "Adina Angerstein", null, "Dr" },
                    { 620, "Car Edgeon", null, "Dr" },
                    { 621, "Manon Giacopello", null, "Mag DI" },
                    { 622, "Jarrad Geck", null, "Mag" },
                    { 634, "Tabbitha Paterson", null, "Dr" },
                    { 623, "Gabbie Belward", null, "Mag DI" },
                    { 625, "Lief Langer", null, "Mag" },
                    { 626, "Vilhelmina Highman", null, "Mag DI" },
                    { 627, "Marijn Winney", null, "Mag" },
                    { 628, "Tymon Blitzer", null, "Mag" },
                    { 629, "Bradford Jovicic", null, "Dr" },
                    { 630, "Allina Beumant", null, "MMag" },
                    { 631, "Filmer Abramino", null, "DI" },
                    { 632, "Tate Kenewell", null, "Mag" },
                    { 624, "Hadleigh Bowry", null, "Dr" },
                    { 614, "Julia Bartke", null, "DI Dr" },
                    { 656, "Kerrie Foffano", null, "Mag" },
                    { 658, "Duane Casa", null, "Mag DI" },
                    { 681, "Gavan Wassung", null, "Mag" },
                    { 682, "Packston Kubatsch", null, "Dr" },
                    { 683, "Ronnica Friedman", null, "DI Dr" },
                    { 684, "Gal Stockall", null, "DI" },
                    { 685, "Minetta Rayhill", null, "Dr" },
                    { 686, "Zsa zsa Burnhill", null, "Mag" },
                    { 687, "Christel Philp", null, "Dr" },
                    { 688, "Mersey Wellstood", null, "Mag DI" },
                    { 680, "Demetrius MacDuffie", null, "DI" },
                    { 689, "Sheila Colliar", null, "Dr" },
                    { 691, "Octavius Prescote", null, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 692, "Hasty O' Cuolahan", null, "MMag" },
                    { 693, "Josey Biermatowicz", null, "Mag DI" },
                    { 694, "Devina Yurasov", null, "DI" },
                    { 695, "Germaine Wehner", null, "MMag" },
                    { 696, "Sloane Tremblett", null, "DI Dr" },
                    { 697, "Kate Grimsdike", null, "DI Dr" },
                    { 698, "Alon Onians", null, "DI" },
                    { 690, "Hillery Heibel", null, "Dr" },
                    { 657, "Heath Willmett", null, "Mag DI" },
                    { 679, "Stinky Showler", null, "DI" },
                    { 677, "Killy Posselwhite", null, "Mag DI" },
                    { 659, "Liane Storrar", null, "DI" },
                    { 660, "Theo Soitoux", null, "Dr" },
                    { 661, "Shelagh McGillreich", null, "MMag" },
                    { 662, "Sasha Oakshott", null, "Mag" },
                    { 663, "Lemar Cabrara", null, "DI Dr" },
                    { 664, "Riccardo Illes", null, "DI" },
                    { 665, "Toddie Chrispin", null, "DI" },
                    { 666, "Kiele Crisell", null, "DI Dr" },
                    { 678, "Flinn Stapleton", null, "Dr" },
                    { 667, "Karee Denham", null, "Mag DI" },
                    { 669, "Newton Float", null, "DI Dr" },
                    { 670, "Delano Copland", null, "DI" },
                    { 671, "Edan Nevinson", null, "DI Dr" },
                    { 672, "Robinia Dalgleish", null, "Dr" },
                    { 673, "Dino Dowzell", null, "DI" },
                    { 674, "Eugenius Killgus", null, "Mag" },
                    { 675, "Judi Olyet", null, "Mag DI" },
                    { 676, "Jenine Keming", null, "Mag" },
                    { 668, "Flor Poulston", null, "DI" },
                    { 525, "Alix Kochlin", null, "DI Dr" },
                    { 613, "Velvet Daniell", null, "Mag DI" },
                    { 611, "Joseph Shelsher", null, "DI" },
                    { 549, "Wileen Enrrico", null, "MMag" },
                    { 550, "Jami Leas", null, "DI Dr" },
                    { 551, "Lombard Truckett", null, "Mag DI" },
                    { 552, "Roderigo Matteotti", null, "MMag" },
                    { 553, "Sheba Spens", null, "Mag DI" },
                    { 554, "Fiona Purveys", null, "Dr" },
                    { 555, "Giorgio Terrelly", null, "MMag" },
                    { 556, "Daphene Minihane", null, "Dr" },
                    { 548, "Duncan Laneham", null, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 557, "Bird Dufoure", null, "Mag" },
                    { 559, "Arluene Bapty", null, "Dr" },
                    { 560, "Shalne Hillett", null, "Mag" },
                    { 561, "Sheena Krink", null, "Mag" },
                    { 562, "Layton Pudney", null, "Mag" },
                    { 563, "Sumner Dallewater", null, "Mag DI" },
                    { 564, "Clay Muggleton", null, "MMag" },
                    { 565, "Joleen Morant", null, "DI Dr" },
                    { 566, "Michael Strewther", null, "Mag" },
                    { 558, "Seana Spick", null, "DI Dr" },
                    { 567, "Franklyn Kiely", null, "DI" },
                    { 547, "Leda Tuerena", null, "Mag DI" },
                    { 545, "Noell Ruter", null, "Mag" },
                    { 527, "Ailina Kirk", null, "MMag" },
                    { 528, "Kristien Kamen", null, "MMag" },
                    { 529, "Maynard Dechelette", null, "DI Dr" },
                    { 530, "Dav Gieves", null, "DI Dr" },
                    { 531, "Yankee Noke", null, "Mag DI" },
                    { 532, "Carie Crosfield", null, "DI Dr" },
                    { 533, "Rita Trice", null, "MMag" },
                    { 534, "Andrew Covert", null, "Mag" },
                    { 546, "Towney Eldershaw", null, "Dr" },
                    { 351, "Shepherd Trassler", null, "MMag" },
                    { 537, "Gilemette Klimko", null, "Mag DI" },
                    { 538, "Carlyle Hanley", null, "DI Dr" },
                    { 539, "Steffane Abadam", null, "MMag" },
                    { 540, "Vicki Mcsarry", null, "Mag" },
                    { 541, "Timmy Acton", null, "MMag" },
                    { 542, "Tove Fould", null, "DI Dr" },
                    { 543, "Alfonse Reoch", null, "DI Dr" },
                    { 544, "Karylin Bernon", null, "DI" },
                    { 536, "Merell Pude", null, "Mag DI" },
                    { 612, "Lorna Brattan", null, "DI Dr" },
                    { 568, "Jaclyn Massingberd", null, "Mag DI" },
                    { 570, "Frederico Sawkins", null, "DI" },
                    { 593, "Ave Pettyfar", null, "DI" },
                    { 594, "Petr Ruane", null, "DI" },
                    { 595, "Bastien Fibbings", null, "MMag" },
                    { 596, "Moira Golden of Ireland", null, "MMag" },
                    { 597, "Betty Brownhill", null, "Mag" },
                    { 598, "Teddi Carncross", null, "Mag DI" },
                    { 599, "Corenda Phifer", null, "Mag DI" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 600, "Cherilyn Codlin", null, "Dr" },
                    { 592, "Etty Scougal", null, "Dr" },
                    { 601, "Blakelee Canadine", null, "Dr" },
                    { 603, "Renado Debill", null, "Mag" },
                    { 604, "Perl Borrowman", null, "DI" },
                    { 605, "Calv Reubel", null, "DI Dr" },
                    { 606, "Tobie Krolak", null, "Mag" },
                    { 607, "Matilde Bartoleyn", null, "DI Dr" },
                    { 608, "Alena Sprionghall", null, "DI" },
                    { 609, "Vitia Pratley", null, "Mag DI" },
                    { 610, "Nicolina Mawditt", null, "Dr" },
                    { 602, "Marnia Druhan", null, "Mag" },
                    { 569, "Lillian Ollarenshaw", null, "Mag DI" },
                    { 591, "Dagmar Makinson", null, "MMag" },
                    { 589, "Brenn Gillooly", null, "Mag DI" },
                    { 571, "Mead Loiterton", null, "Dr" },
                    { 572, "Tedi Ablewhite", null, "Dr" },
                    { 573, "Doralynn Ramelot", null, "Mag DI" },
                    { 574, "Gayle Reyes", null, "Mag DI" },
                    { 575, "Keene Matthews", null, "Dr" },
                    { 576, "Bambi Meecher", null, "DI Dr" },
                    { 577, "Carmelia Waddingham", null, "MMag" },
                    { 578, "Winne Rabbitts", null, "Mag" },
                    { 590, "Dougy Thomsen", null, "DI" },
                    { 579, "Drud Simonnin", null, "Mag" },
                    { 581, "Xenia Allwood", null, "Mag DI" },
                    { 582, "Hakim Jesson", null, "Mag" },
                    { 583, "Vi Hassall", null, "MMag" },
                    { 584, "Sharon MacClay", null, "Mag DI" },
                    { 585, "Osmond Stennings", null, "Dr" },
                    { 586, "Leoine McKernan", null, "Dr" },
                    { 587, "Carolus Harner", null, "Mag" },
                    { 588, "Wyn Parsell", null, "Mag DI" },
                    { 580, "Arleyne Gillam", null, "DI Dr" },
                    { 350, "Freedman Gladtbach", null, "Dr" },
                    { 339, "Hazlett Lowen", null, "DI Dr" },
                    { 348, "Jacqui Kondrat", null, "Mag" },
                    { 111, "Mord Lansley", null, "Mag" },
                    { 112, "Eustacia Kinnen", null, "DI Dr" },
                    { 113, "Maria Valero", null, "MMag" },
                    { 114, "Emilee Poyle", null, "Mag DI" },
                    { 115, "Paolina Slimme", null, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 116, "Amandy Mangion", null, "Mag DI" },
                    { 117, "Kandace Crowson", null, "DI Dr" },
                    { 118, "Erminia Tunney", null, "MMag" },
                    { 119, "Lev Tidcombe", null, "MMag" },
                    { 120, "Theodore Duckitt", null, "DI" },
                    { 121, "Noelle Stening", null, "Mag" },
                    { 122, "Kent Elbourne", null, "Mag DI" },
                    { 123, "Berty Keenor", null, "Mag DI" },
                    { 124, "Melloney O'Fallowne", null, "MMag" },
                    { 125, "Lalo Petren", null, "Mag DI" },
                    { 126, "Lulu Lawley", null, "DI" },
                    { 127, "Addison Ritchman", null, "Dr" },
                    { 110, "Wallis Lamden", null, "MMag" },
                    { 109, "Payton Juza", null, "MMag" },
                    { 108, "Darice Derycot", null, "Mag" },
                    { 107, "Bernardo Jenik", null, "DI Dr" },
                    { 89, "Mohandas Derrell", null, "Mag" },
                    { 90, "Alvina Hayman", null, "Mag DI" },
                    { 91, "Camille Sandal", null, "Mag DI" },
                    { 92, "Cob Bellhouse", null, "MMag" },
                    { 93, "Carie Boerderman", null, "Mag DI" },
                    { 94, "Dalt Coghlin", null, "DI Dr" },
                    { 95, "Anders Bessell", null, "Dr" },
                    { 96, "Marget Dombrell", null, "DI Dr" },
                    { 128, "Moritz Swaile", null, "MMag" },
                    { 97, "Ernst Allflatt", null, "Mag" },
                    { 99, "Lucas Casillas", null, "MMag" },
                    { 100, "Nancie Gymblett", null, "Mag" },
                    { 101, "Johnath Ratazzi", null, "Mag DI" },
                    { 102, "Darice Lewsley", null, "Mag" },
                    { 103, "Claudetta Lynskey", null, "DI" },
                    { 104, "Giulio Pitcher", null, "Dr" },
                    { 105, "Kynthia Yonge", null, "MMag" },
                    { 106, "Gottfried Groarty", null, "DI Dr" },
                    { 98, "Rudolf Southcott", null, "Mag" },
                    { 129, "Nita Pappi", null, "MMag" },
                    { 130, "Lila Muckeen", null, "DI" },
                    { 131, "Libbi Meachen", null, "DI Dr" },
                    { 154, "Alick Sutherley", null, "Dr" },
                    { 155, "Lonni Cawsy", null, "DI Dr" },
                    { 156, "Ibby Escala", null, "DI Dr" },
                    { 157, "Felicity Dowd", null, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 158, "Pierce Basire", null, "Mag DI" },
                    { 159, "Burk Millmore", null, "Dr" },
                    { 160, "Aldridge Rysdale", null, "MMag" },
                    { 161, "Mollee Ruslen", null, "DI" },
                    { 153, "Dorette Skingle", null, "DI Dr" },
                    { 162, "Tessa Massy", null, "DI Dr" },
                    { 164, "Mata Rumin", null, "MMag" },
                    { 165, "Laney Aberchirder", null, "Mag" },
                    { 166, "Felita Trays", null, "Mag" },
                    { 167, "Cozmo Cobon", null, "Mag DI" },
                    { 168, "Loise Frampton", null, "DI" },
                    { 169, "Natty Allner", null, "Mag" },
                    { 170, "Jany Rulten", null, "MMag" },
                    { 171, "Verena Louys", null, "DI" },
                    { 163, "Charo Josskowitz", null, "Mag DI" },
                    { 88, "Laureen Cadore", null, "Mag" },
                    { 152, "Shanta Lodevick", null, "Mag" },
                    { 150, "Ree Collar", null, "Mag DI" },
                    { 132, "Saunders Bes", null, "Mag" },
                    { 133, "Dion Cowton", null, "Dr" },
                    { 134, "Elnar Storek", null, "Mag" },
                    { 135, "Derward Spores", null, "DI Dr" },
                    { 136, "Conrado Cockley", null, "Dr" },
                    { 137, "Maryrose McGonigal", null, "DI Dr" },
                    { 138, "Delcine Le Prevost", null, "MMag" },
                    { 139, "Cherish Franzke", null, "MMag" },
                    { 151, "Richart Seaking", null, "Mag" },
                    { 140, "Borg Bigglestone", null, "Mag DI" },
                    { 142, "Aymer Lowndes", null, "Mag DI" },
                    { 143, "Bruce Brankley", null, "Mag DI" },
                    { 144, "Francyne Erwin", null, "MMag" },
                    { 145, "Alwin Folks", null, "DI" },
                    { 146, "Verla Newbold", null, "DI" },
                    { 147, "Thacher Booth", null, "Mag DI" },
                    { 148, "Robinette Raddish", null, "DI Dr" },
                    { 149, "Babita Pocklington", null, "Mag DI" },
                    { 141, "Lowell Bessom", null, "Mag DI" },
                    { 87, "Hillary Folley", null, "DI Dr" },
                    { 86, "Milzie Alty", null, "Dr" },
                    { 85, "Estrellita Pitchers", null, "Dr" },
                    { 23, "Rodolfo Thomsson", null, "MMag" },
                    { 24, "Loretta Lyle", null, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 25, "Gallard MacGuiness", null, "MMag" },
                    { 26, "Lewes Chesshyre", null, "Mag" },
                    { 27, "Patty Raselles", null, "Dr" },
                    { 28, "Ruddy Loughead", null, "MMag" },
                    { 29, "Junia Stern", null, "Mag DI" },
                    { 30, "Jobie Jakobssen", null, "DI Dr" },
                    { 22, "Beth Kemshell", null, "DI Dr" },
                    { 31, "Kelsy Devil", null, "DI" },
                    { 33, "Gerti Hirche", null, "Dr" },
                    { 34, "Maribeth Yerrall", null, "DI" },
                    { 35, "Hillie Frankton", null, "MMag" },
                    { 36, "Jeramie Confort", null, "Mag" },
                    { 37, "Port Jennaway", null, "DI Dr" },
                    { 38, "Woodman Rofe", null, "MMag" },
                    { 39, "Svend Vaen", null, "Dr" },
                    { 40, "Filippo Killwick", null, "Dr" },
                    { 32, "Kirsten Denington", null, "DI Dr" },
                    { 41, "Stevana Hudspith", null, "MMag" },
                    { 21, "Isabelle Sproson", null, "MMag" },
                    { 19, "Sadye Dudgeon", null, "DI Dr" },
                    { 1, "Kip Harnett", null, "DI Dr" },
                    { 2, "Baillie Alpine", null, "DI" },
                    { 3, "Elnore Fetherstone", null, "MMag" },
                    { 4, "Rickard Bencher", null, "Mag DI" },
                    { 5, "Lewes Romanin", null, "Mag" },
                    { 6, "Barton McTeague", null, "Dr" },
                    { 7, "Davey Gould", null, "DI Dr" },
                    { 8, "Florencia Howarth", null, "Mag DI" },
                    { 20, "Terrie Mattis", null, "Mag" },
                    { 9, "Bearnard Elner", null, "DI" },
                    { 11, "Bryon Lyburn", null, "DI" },
                    { 12, "Daniela Golsthorp", null, "MMag" },
                    { 13, "Simone Rubberts", null, "Mag DI" },
                    { 14, "Lian Corcoran", null, "MMag" },
                    { 15, "Demetris Mapston", null, "DI Dr" },
                    { 16, "Sholom Van Cassel", null, "MMag" },
                    { 17, "Karissa Antao", null, "Mag DI" },
                    { 18, "Noreen Devonish", null, "Mag" },
                    { 10, "Sacha Simmings", null, "MMag" },
                    { 172, "Bobbette Grewe", null, "Mag DI" },
                    { 42, "Amory Alywen", null, "Mag" },
                    { 44, "Corny Lightowler", null, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 67, "Gert Dansken", null, "DI Dr" },
                    { 68, "Frants Martelet", null, "Mag" },
                    { 69, "Pietro Tant", null, "MMag" },
                    { 70, "Rahel Tinwell", null, "Mag DI" },
                    { 71, "Tito Beatey", null, "DI Dr" },
                    { 72, "Hamil Deesly", null, "DI Dr" },
                    { 73, "Laurella Darch", null, "Dr" },
                    { 74, "Blayne Southey", null, "DI Dr" },
                    { 66, "Martica Dawidowsky", null, "Dr" },
                    { 75, "Eleen Moloney", null, "DI Dr" },
                    { 77, "Dal Biesterfeld", null, "Mag" },
                    { 78, "Patty Smurfitt", null, "Mag" },
                    { 79, "Vinni Guilloux", null, "DI Dr" },
                    { 80, "Anissa Allbut", null, "DI Dr" },
                    { 81, "Goddard Issac", null, "Mag DI" },
                    { 82, "Gaylene Morrel", null, "Dr" },
                    { 83, "Nadia Bundock", null, "DI Dr" },
                    { 84, "Florinda Aylwin", null, "MMag" },
                    { 76, "Cris Maasz", null, "DI" },
                    { 43, "Kirsten Innes", null, "MMag" },
                    { 65, "Davine Pomfrey", null, "DI Dr" },
                    { 63, "Spenser Roder", null, "Mag DI" },
                    { 45, "Lory Bartkiewicz", null, "MMag" },
                    { 46, "Anny Bugg", null, "DI Dr" },
                    { 47, "Milt Vinau", null, "DI" },
                    { 48, "Nadya Pottell", null, "Dr" },
                    { 49, "Clarey Yerby", null, "DI Dr" },
                    { 50, "Barris Warrillow", null, "Mag" },
                    { 51, "Son Harfleet", null, "MMag" },
                    { 52, "Clevey McAughtrie", null, "DI Dr" },
                    { 64, "Marga Hess", null, "DI Dr" },
                    { 53, "Alta Quinnette", null, "DI Dr" },
                    { 55, "Leontine McDaid", null, "Dr" },
                    { 56, "Gil Ivashkin", null, "DI" },
                    { 57, "Heloise Inchbald", null, "Mag" },
                    { 58, "Brandy de Courcey", null, "DI" },
                    { 59, "Antonella Boots", null, "DI Dr" },
                    { 60, "Oona Kildea", null, "DI" },
                    { 61, "Lefty Lavalde", null, "Mag" },
                    { 62, "Corey Folca", null, "Mag DI" },
                    { 54, "Waylon Wavish", null, "MMag" },
                    { 173, "Celene Overstreet", null, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 174, "Tom Davidwitz", null, "Dr" },
                    { 175, "Serene Ramm", null, "Dr" },
                    { 286, "Silvie Leyman", null, "Mag" },
                    { 287, "Randi Kinnier", null, "DI" },
                    { 288, "Ferrell Sellar", null, "Mag" },
                    { 289, "Benedick Morrant", null, "Mag" },
                    { 290, "Rafi Mc Andrew", null, "Dr" },
                    { 291, "Mair Streets", null, "Mag DI" },
                    { 292, "Sammie Parres", null, "Dr" },
                    { 293, "Sharia Videler", null, "Mag DI" },
                    { 285, "Riannon Yarnley", null, "Mag" },
                    { 294, "Kaleb Williamson", null, "MMag" },
                    { 296, "Tresa Weighell", null, "Mag" },
                    { 297, "Ezechiel Potteridge", null, "MMag" },
                    { 298, "Dyanna Camelli", null, "MMag" },
                    { 299, "Kip Ivanets", null, "Mag" },
                    { 300, "Fidel Skrine", null, "DI" },
                    { 301, "Tedie McKag", null, "Mag DI" },
                    { 302, "Lynn Succamore", null, "MMag" },
                    { 303, "Agatha Jodlkowski", null, "MMag" },
                    { 295, "Olive Chilcott", null, "Mag" },
                    { 304, "Artus Ferrelli", null, "MMag" },
                    { 284, "Jan Vern", null, "DI" },
                    { 282, "Ettore Maffin", null, "Dr" },
                    { 264, "Brook Oppy", null, "Dr" },
                    { 265, "Dorisa Wilcott", null, "MMag" },
                    { 266, "Howard Petken", null, "Mag" },
                    { 267, "Artemas Jedrychowski", null, "DI" },
                    { 268, "Auguste Vogt", null, "DI" },
                    { 269, "Elbertina Skirven", null, "Mag" },
                    { 270, "Marlene Cumes", null, "Mag" },
                    { 271, "Beale Croad", null, "DI Dr" },
                    { 283, "Barn Clynman", null, "Mag" },
                    { 272, "Letisha Aleksahkin", null, "Mag" },
                    { 274, "Flossi Baggallay", null, "Mag DI" },
                    { 275, "Willi Maysor", null, "Dr" },
                    { 276, "Giana Gloyens", null, "MMag" },
                    { 277, "Skippie Jaynes", null, "DI" },
                    { 278, "Goldy O'Currine", null, "Dr" },
                    { 279, "Opalina Scatchar", null, "Dr" },
                    { 280, "Jaquelin Pren", null, "Mag" },
                    { 281, "Florrie Domesday", null, "MMag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 273, "Alyss Brunone", null, "DI" },
                    { 263, "Ravi O'Neal", null, "DI Dr" },
                    { 305, "Claretta Galpen", null, "DI Dr" },
                    { 307, "Saraann Wilsher", null, "MMag" },
                    { 330, "Rozalie Huckleby", null, "Dr" },
                    { 331, "Harlen Klinck", null, "MMag" },
                    { 332, "Amity Tayloe", null, "Mag" },
                    { 333, "Hugues Greer", null, "Mag DI" },
                    { 334, "Maiga Schimank", null, "Mag" },
                    { 335, "Fayina Mongin", null, "DI" },
                    { 336, "Isahella Clench", null, "Mag" },
                    { 337, "Currey Windham", null, "Mag DI" },
                    { 329, "Cordy Smowton", null, "DI Dr" },
                    { 338, "Lenna Lear", null, "Dr" },
                    { 340, "Vernon O'Cannavan", null, "DI" },
                    { 341, "Skylar Skyme", null, "DI Dr" },
                    { 342, "Seumas Spurdens", null, "Dr" },
                    { 343, "Reagen Mower", null, "MMag" },
                    { 344, "Terrel Noyce", null, "Dr" },
                    { 345, "Annalee Dmitrichenko", null, "Mag DI" },
                    { 346, "Gran Barnewell", null, "Mag" },
                    { 347, "Nichole Knibb", null, "Mag DI" },
                    { 699, "Gizela Nussgen", null, "DI Dr" },
                    { 306, "Vale Gosselin", null, "Dr" },
                    { 328, "Carlynne Crannach", null, "DI Dr" },
                    { 326, "Wash Gieraths", null, "Mag" },
                    { 308, "Bili Vitte", null, "Mag DI" },
                    { 309, "Maible de Marco", null, "MMag" },
                    { 310, "Kristi Zorn", null, "Mag DI" },
                    { 311, "Krystalle Kryska", null, "DI" },
                    { 312, "Saul Johncey", null, "Mag" },
                    { 313, "Tiffy Behnecke", null, "Dr" },
                    { 314, "Sterne Waywell", null, "Mag" },
                    { 315, "Anatole McSperrin", null, "Dr" },
                    { 327, "Reta Ranstead", null, "Dr" },
                    { 316, "Connie D'Oyly", null, "MMag" },
                    { 318, "Bevvy Newlove", null, "Dr" },
                    { 319, "Antoine Clemmens", null, "DI Dr" },
                    { 320, "Burty Wybern", null, "Dr" },
                    { 321, "Ephrayim Puvia", null, "Dr" },
                    { 322, "Arabelle Gerald", null, "DI Dr" },
                    { 323, "Andie Le Gall", null, "Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 324, "Cointon Mallya", null, "Mag" },
                    { 325, "Immanuel Spuffard", null, "Dr" },
                    { 317, "Romola Baume", null, "DI" },
                    { 349, "Winifield Mewe", null, "Mag" },
                    { 262, "Baxter Arran", null, "Mag DI" },
                    { 260, "Vikki O'Dunneen", null, "DI Dr" },
                    { 198, "Dorrie Netley", null, "Mag" },
                    { 199, "Chance Benoit", null, "Mag" },
                    { 200, "Milena Patshull", null, "MMag" },
                    { 201, "Carmita Seston", null, "MMag" },
                    { 202, "Edik Clitherow", null, "MMag" },
                    { 203, "Erica Castilla", null, "Dr" },
                    { 204, "Eugenio O' Faherty", null, "MMag" },
                    { 205, "Carolyn Lindenman", null, "MMag" },
                    { 197, "Brian Ackery", null, "MMag" },
                    { 206, "Pauli Barron", null, "DI Dr" },
                    { 208, "Allegra Sellstrom", null, "DI" },
                    { 209, "Christos Regis", null, "Mag DI" },
                    { 210, "Bess Weed", null, "Mag DI" },
                    { 211, "Sandy Wyllcock", null, "DI" },
                    { 212, "Jamaal Peevor", null, "MMag" },
                    { 213, "Patin Brunet", null, "Dr" },
                    { 214, "Grata Cereceres", null, "DI Dr" },
                    { 215, "Lotti Hunnam", null, "DI" },
                    { 207, "Ruthe O'Gorman", null, "Mag DI" },
                    { 216, "Ofella Kimmins", null, "Dr" },
                    { 196, "Myra Cossons", null, "MMag" },
                    { 194, "Caro Mees", null, "Mag" },
                    { 176, "Oswell Goodlett", null, "MMag" },
                    { 177, "Blake Hankard", null, "Mag" },
                    { 178, "Nola Onge", null, "MMag" },
                    { 179, "Hewett Saker", null, "Dr" },
                    { 180, "Brannon McGeown", null, "Dr" },
                    { 181, "Lurline Boatswain", null, "Mag" },
                    { 182, "Konrad Haslum", null, "MMag" },
                    { 183, "Munroe Ivanilov", null, "Mag" },
                    { 195, "Nert Pitts", null, "Mag DI" },
                    { 184, "Burlie Antonescu", null, "DI" },
                    { 186, "Carita Billyard", null, "DI" },
                    { 187, "Calli Skillen", null, "DI Dr" },
                    { 188, "Vicki Rickarsey", null, "DI" },
                    { 189, "Stephie Setford", null, "DI Dr" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 190, "Fairleigh Snowling", null, "Mag" },
                    { 191, "Hortensia Hazeup", null, "DI Dr" },
                    { 192, "Fred Yepiskov", null, "Mag DI" },
                    { 193, "Ricoriki Whyatt", null, "Mag" },
                    { 185, "Sig Harborow", null, "Dr" },
                    { 261, "My Sorsbie", null, "DI Dr" },
                    { 217, "Mendel Naris", null, "DI Dr" },
                    { 219, "Arluene Torrans", null, "Mag" },
                    { 242, "Letitia McNish", null, "MMag" },
                    { 243, "Care Deelay", null, "Mag DI" },
                    { 244, "Kym Leechman", null, "MMag" },
                    { 245, "Devin Ferries", null, "Mag DI" },
                    { 246, "Marcile Tavernor", null, "Mag" },
                    { 247, "Alix Warricker", null, "DI Dr" },
                    { 248, "Hildagarde Staveley", null, "DI Dr" },
                    { 249, "Hayyim Gatrell", null, "DI" },
                    { 241, "Abby Eagle", null, "MMag" },
                    { 250, "Justus Richichi", null, "Mag DI" },
                    { 252, "Callean Antonetti", null, "Dr" },
                    { 253, "Tish Abrashkin", null, "DI Dr" },
                    { 254, "Ranee Krochmann", null, "Mag" },
                    { 255, "Othelia Juggings", null, "MMag" },
                    { 256, "Courtney O' Byrne", null, "Mag DI" },
                    { 257, "Karisa Fraser", null, "Mag" },
                    { 258, "Latashia Somes", null, "MMag" },
                    { 259, "Geri Janca", null, "DI" },
                    { 251, "Gay Sheehan", null, "DI Dr" },
                    { 218, "Brinn Joselevitch", null, "MMag" },
                    { 240, "Gene Turbefield", null, "MMag" },
                    { 238, "Lyssa Syder", null, "DI" },
                    { 220, "Isidoro Astell", null, "MMag" },
                    { 221, "Minnnie Pechet", null, "MMag" },
                    { 222, "Kariotta Leith-Harvey", null, "Mag" },
                    { 223, "Isador Snailham", null, "DI" },
                    { 224, "Filip Caddie", null, "Mag" },
                    { 225, "Rolfe Dunks", null, "Mag DI" },
                    { 226, "Verene Suffield", null, "Mag DI" },
                    { 227, "Vachel Last", null, "Mag DI" },
                    { 239, "Stillmann Linnard", null, "DI" },
                    { 228, "Cosme Kennelly", null, "Dr" },
                    { 230, "Mendie Bartusek", null, "Mag DI" },
                    { 231, "Lorenza Kevlin", null, "Mag" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name", "SchoolId", "Title" },
                values: new object[,]
                {
                    { 232, "Amalita L'Hommee", null, "Mag" },
                    { 233, "Isador Basezzi", null, "Mag" },
                    { 234, "Demetre Sabberton", null, "DI" },
                    { 235, "Leonard Duddell", null, "Mag DI" },
                    { 236, "Gale Strelitz", null, "DI" },
                    { 237, "Coleen Bleythin", null, "Dr" },
                    { 229, "Giffard Covotto", null, "DI" },
                    { 700, "Sibel MacMenamy", null, "Dr" }
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
