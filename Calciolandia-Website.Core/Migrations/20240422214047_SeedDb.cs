using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Round = table.Column<int>(type: "int", nullable: false),
                    Season = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    StadiumId = table.Column<int>(type: "int", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fixtures_FootballClubs_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "FootballClubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fixtures_FootballClubs_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "FootballClubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fixtures_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fixtures_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("469c79e1-d881-4c0b-952f-f08af274800d"), "e0519b69-392d-4f6c-92a4-2050215ad104", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "LogoImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Italy", "https://tmssl.akamaized.net/images/logo/header/it1.png?lm=1656073460", "Serie A" },
                    { 2, "Italy", "https://tmssl.akamaized.net/images/logo/header/it2.png?lm=1548242827", "Serie B" },
                    { 3, "Italy", "https://tmssl.akamaized.net/images/logo/header/it3a.png?lm=1599832650", "Serie C" }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Address", "Capacity", "City", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Piazzale Angelo Moratti, 20151 Milan MI", 80018, "Milan", "https://img.legaseriea.it/vimages/632b5612/775454473ML003_FC_Internazi.JPG?webp&q=70&size=999x-", "Giuseppe Meazza" },
                    { 2, "Viale dei Gladiatori, 00135 Roma RM", 73261, "Rome", "https://img.legaseriea.it/vimages/635a8731/stadio-olimpico-roma.png?webp&q=70&size=999x-", "Olimpico" },
                    { 3, "Viale Giulio Cesare, 18, 24124 Bergamo BG", 19768, "Bergamo", "https://img.legaseriea.it/vimages/62cef799/7%20(1).jpg?webp&q=70&size=999x-", "Gewiss Stadium" },
                    { 4, "Via Andrea Costa, 174, 40134 Bologna BO", 38279, "Bologna", "https://img.legaseriea.it/vimages/62d9651c/dallara_bologna.png?webp&q=70&size=999x-", "Renato Dall' Ara" },
                    { 5, "Via Raimondo Carta Raspi, 09126 Cagliari CA", 16416, "Cagliari", "https://img.legaseriea.it/vimages/649d9299/unipol%20domus%203.jpg?webp&q=70&size=999x-", "Unipol Domus" },
                    { 6, "Via delle Olimpiadi, 50053 Empoli FI", 19847, "Empoli", "https://img.legaseriea.it/vimages/6346b2cf/EMPOLISITO.png?webp&q=70&size=999x-", "Castellani Computer Gross Arena" },
                    { 7, "Viale Manfredo Fanti, 4, 50137 Firenze FI", 47282, "Florence", "https://img.legaseriea.it/vimages/632865d1/208879_0001_3764373.png?webp&q=70&size=999x-", "Artemio Franchi" },
                    { 8, "Viale Olimpia, 03100 Frosinone FR", 16227, "Frozinone", "https://img.legaseriea.it/vimages/649d7c5a/stadio-benito-stirpe.png?webp&q=70&size=999x-", "Benito Stirpe" },
                    { 9, "Via Giovanni de Prà, 1, 16139", 36348, "Genoa", "https://img.legaseriea.it/vimages/64a2c8bb/IMG_3486.jpg?webp&q=70&size=999x-", "Luigi Ferraris" },
                    { 10, "Piazzale Olimpia,2,37138 Verona VR", 39211, "Verona", "https://img.legaseriea.it/vimages/62d9745c/stadio_03verona.jpg?webp&q=70&size=999x-", "Marcantonio Bentegodi" },
                    { 11, "Corso Gaetano Scirea, 50, 10151 Torino TO", 41507, "Turin", "https://img.legaseriea.it/vimages/62d965db/allianz-stadium.jpg?webp&q=70&size=999x-", "Allianz Stadium" },
                    { 12, "Viale Stadio, 73024 Lecce LE", 31559, "Lecce", "https://img.legaseriea.it/vimages/63564923/STADIO-LECCE.png?webp&q=70&size=999x-", "Ettore Giardiniero - Via Del Mare" },
                    { 13, "Via Franco Tognini, 4, 20900 Monza MB", 15039, "Monza", "https://img.legaseriea.it/vimages/635647a2/STADIO-MONZA.png?webp&q=70&size=999x-", "U-Power Stadium" },
                    { 14, "Piazzale Vincenzo Tecchio, 80125 Napoli NA", 54726, "Naples", "https://img.legaseriea.it/vimages/62da938f/stadio-maradona%20dettaglio-curva.jpg?webp&q=70&size=999x-", "Diego Armando Maradona" },
                    { 15, "Via Salvador Allende, 84131 Salerno SA", 30739, "Salerno", "https://img.legaseriea.it/vimages/63564996/STADIO-ARECHI.png?webp&q=70&size=999x-", "Arechi" },
                    { 16, "Piazzale Atleti Azzurri D`Italia, 1, 42122 Reggio Emilia RE", 21584, "Reggio Emilia", "https://img.legaseriea.it/vimages/635648b4/STADIO-MAPEI.png?webp&q=70&size=999x-", "Mapei Stadium - Citta Del Tricolore" },
                    { 17, "Via Filadelfia, 96/b, 10134 Torino TO", 27994, "Turin", "https://img.legaseriea.it/vimages/6346b263/TORINOSITO.png?webp&q=70&size=999x-", "Olimpico Grande Torino" },
                    { 18, "Viale Agostino ed Angelo Candolini, 2 , 33100 Udine UD", 25144, "Udine", "https://img.legaseriea.it/vimages/64a7e2b8/udinese-stadio.png?webp&q=70&size=999x-", "Udinese Arena" }
                });

            migrationBuilder.InsertData(
                table: "FootballClubs",
                columns: new[] { "Id", "Address", "City", "FoundedYear", "LeagueId", "LogoImageUrl", "Name", "Nickname", "StadiumId", "Trophies" },
                values: new object[,]
                {
                    { 1, "Zingonia - Corso Europa 20040 Bergamo Italy", "Bergamo", 1907, 1, "https://img.legaseriea.it/vimages/62cfd69d/atalanta.png?webp&q=70&size=300x-", "Atalanta BC", "La Dea", 3, 0 },
                    { 2, "Via Casteldebole 10 40132 Bologna Italy", "Bologna", 1909, 1, "https://img.legaseriea.it/vimages/62cef3f6/bologna.png?webp&q=70&size=300x-", "Bologna FC 1909", "Rossoblù", 4, 7 },
                    { 3, "Via Mameli 106 09123 Cagliari Italy", "Cagliari", 1907, 1, "https://img.legaseriea.it/vimages/62cfd202/cagliari.png?webp&q=70&size=300x-", "Cagliari Calcio", "Rossoblù", 5, 1 },
                    { 4, "Via di Pianezzoli 50053 Empoli Italy", "Empoli", 1907, 1, "https://img.legaseriea.it/vimages/62cef42e/empoli.png?webp&q=70&size=300x-", "FC Empoli", "Azzurri", 6, 0 },
                    { 5, " Viale Manfredo Fanti, 4 50137 Firenze Italy", "Florence", 1907, 1, "https://img.legaseriea.it/vimages/62cef452/fiorentina.png?webp&q=70&size=300x-", "ACF Fiorentina", "Viola", 7, 2 },
                    { 6, "Viale Olimpia 03100 Frosinone Italy", "Frosinone", 1907, 1, "https://img.legaseriea.it/vimages/62cfdfec/frosinone.png?webp&q=70&size=300x-", "Frosinone Calcio", "Giallazzurri", 8, 0 },
                    { 7, "Via Ronchi 67 16155 Genova Italy", "Genoa", 1907, 1, "https://img.legaseriea.it/vimages/649e8a06/GENOA-1.png?webp&q=70&size=300x-", "Genoa CFC", "Grifone", 9, 9 },
                    { 8, "Via Torricelli 37 37136 Verona Italy", "Verona", 1907, 1, "https://img.legaseriea.it/vimages/62cef475/colore=YELLOW.png?webp&q=70&size=300x-", "Hellas Verona FC", "Gialloblu", 10, 1 },
                    { 9, "Viale della Liberazione Milano Italy", "Milan", 1907, 1, "https://img.legaseriea.it/vimages/62cef496/inter.png?webp&q=70&size=300x-", "Inter Milan", "Nerazzurri", 1, 19 },
                    { 10, "Via Druento, 175 10151 Torino Italy", "Turin", 1907, 1, "https://img.legaseriea.it/vimages/62cef4b7/colore=WHITE.png?webp&q=70&size=300x-", "Juventus FC", "Bianconeri", 11, 36 },
                    { 11, "Via di Santa Cornelia 1000 00060 Roma Italy", "Rome", 1907, 1, "https://img.legaseriea.it/vimages/62cef4d5/lazio.png?webp&q=70&size=300x-", "SS Lazio", "Biancocelesti", 2, 2 },
                    { 12, "Colonello Archimede Costadura 3 73100 Lecce Italy", "Lecce", 1907, 1, "https://img.legaseriea.it/vimages/62cef4f6/lecce.png?webp&q=70&size=300x-", "US Lecce", "Giallorossi", 12, 0 },
                    { 13, "Via Aldo Rossi 8 20149 Milano Italy", "Milan", 1907, 1, "https://img.legaseriea.it/vimages/62cef513/milan.png?webp&q=70&size=300x-", "AC Milan", "Rossoneri", 1, 19 },
                    { 14, "Via Ragazzi del '99, 14 20900 Monza Italy", "Monza", 1907, 1, "https://img.legaseriea.it/vimages/62c6acbd/monza.png?webp&q=70&size=300x-", "AC Monza", "Biancorossi", 13, 0 },
                    { 15, "Via del Maio di Porto 9 80133 Napoli Italy", "Naples", 1907, 1, "https://img.legaseriea.it/vimages/62cef532/napoli.png?webp&q=70&size=300x-", "SSC Napoli", "Partenopei", 14, 3 },
                    { 16, "Piazzale Dino Viola 1 00128 Roma Italy", "Rome", 1907, 1, "https://img.legaseriea.it/vimages/62cfd5ce/roma.png?webp&q=70&size=300x-", "AS Roma", "Giallorossi", 2, 3 },
                    { 17, "Via Salvador Allende 84131 Salerno Italy", "Salerno", 1907, 1, "https://img.legaseriea.it/vimages/62cef553/salernitana.png?webp&q=70&size=300x-", "US Salernitana 1919", "Granata", 15, 0 },
                    { 18, "Piazza Risorgimento 47 41049 Sassuolo Italy", "Sassuolo", 1907, 1, "https://img.legaseriea.it/vimages/62cef590/sassuolo.png?webp&q=70&size=300x-", "US Sassuolo Calcio", "Neroverdi", 16, 0 },
                    { 19, "Via Arcivescovado 1 10121 Torino Italy", "Turin", 1907, 1, "https://img.legaseriea.it/vimages/62cef5cb/torino.png?webp&q=70&size=300x-", "Torino FC", "Toro", 17, 7 },
                    { 20, "Via A. e A. Candolini 2 33100 Udine Italy", "Udine", 1907, 1, "https://img.legaseriea.it/vimages/62cef5e9/udinese.png?webp&q=70&size=300x-", "Udinese Calcio", "Friulani", 18, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "FootballClubId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a"), 0, "bd06493c-2941-478a-b347-af64542cf964", "m_fvidenov@abv.bg", true, "Mihail", 5, "Videnov", false, null, "m_fvidenov@abv.bg", "mishaka002", "AQAAAAEAACcQAAAAEEWysyqrve35NRkGyOn0/x03Ray5XPUWZ92oubGpp1k/9IcO+j513QYhgBSZhVOqXw==", null, false, "425a98be-1b21-4136-b1ca-f0c8e6ba4c80", false, "mishaka002" },
                    { new Guid("37390eb1-f3f7-45ee-835f-9712488e3aa5"), 0, "aa5ad2d1-b7d3-4cfc-91d5-22b9da383f0a", "luben_6@abv.bg", true, "Luben", 7, "Videnov", false, null, "luben_6@abv.bg", "luben_v", "AQAAAAEAACcQAAAAEBWdVtqgpMxdSmWyX+1Ot0dlsY/bFmI+9xidYWATDiDVd5PoCRsTOZF3pxBQUA/vlQ==", null, false, "044c46a9-07a6-4b16-9707-28bb221d472f", false, "luben_v" }
                });

            migrationBuilder.InsertData(
                table: "Fixtures",
                columns: new[] { "Id", "AwayTeamId", "Date", "HomeTeamId", "LeagueId", "Result", "Round", "Season", "StadiumId", "Time" },
                values: new object[,]
                {
                    { new Guid("38130c98-accb-4e0a-818a-5f47d2b08dc9"), 10, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "2 - 2", 33, "2023/2024", 5, "21:45" },
                    { new Guid("43a79872-0c0a-4fd6-9675-7198708ce662"), 11, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, "0 - 1", 33, "2023/2024", 9, "19:30" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "BirthDate", "ContractExpiredDate", "ContractSignedDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("0343df0b-cf7b-4ea1-b22e-b5d1b37d6b01"), 55, new DateTime(1968, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francesco", 15, "https://img.a.transfermarkt.technology/portrait/big/33804-1697643746.jpg?lm=1", "Calzona", "Italy" },
                    { new Guid("060dcb8f-8672-4425-b4ea-1cb5786470dc"), 48, new DateTime(1975, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriele", 20, "https://img.a.transfermarkt.technology/portrait/big/31903-1639297579.jpg?lm=1", "Cioffi", "Italy" },
                    { new Guid("0ac01812-5943-4e1e-af5a-0296e9dffb73"), 60, new DateTime(1964, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davide", 18, "https://img.a.transfermarkt.technology/portrait/big/3793-1631177487.jpg?lm=1", "Ballardini", "Italy" },
                    { new Guid("10b38ca7-9319-49c4-93a8-b49a371083b6"), 47, new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", 19, "https://img.a.transfermarkt.technology/portrait/big/16508-1594718677.jpg?lm=1", "Juric", "Croatia" },
                    { new Guid("188a7590-3b45-40a5-bc4c-e660369bc2e5"), 40, new DateTime(1983, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniele", 16, "https://img.a.transfermarkt.technology/portrait/big/90748-1616069982.jpg?lm=1", "De Rossi", "Italy" },
                    { new Guid("26c069ee-17cc-4f2c-8d80-88658cf99b3e"), 61, new DateTime(1962, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefano", 17, "https://img.a.transfermarkt.technology/portrait/big/2127-1634565915.jpg?lm=1", "Colantuono", "Italy" },
                    { new Guid("51125581-f439-4f2a-aa8c-2ea1e001df3c"), 40, new DateTime(1982, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiago", 2, "https://img.a.transfermarkt.technology/portrait/big/61868-1663936050.jpg?lm=1", "Motta", "Italy/Brazil" },
                    { new Guid("53c51138-aa94-4f3f-8e1b-c26a45d28f69"), 39, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raffaele", 14, "https://img.a.transfermarkt.technology/portrait/big/95674-1663872108.jpg?lm=1", "Palladino", "Italy" },
                    { new Guid("53e492a8-c95d-4b01-bc24-79c63939233c"), 41, new DateTime(1982, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto", 7, "https://img.a.transfermarkt.technology/portrait/big/64045-1673622044.jpg?lm=1", "Gilardino", "Italy" },
                    { new Guid("64637af9-4047-4840-b202-a855a9414bc1"), 59, new DateTime(1963, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 8, "https://img.a.transfermarkt.technology/portrait/big/12015-1649752265.jpg?lm=1", "Baroni", "Italy" },
                    { new Guid("7596dcb1-be28-4810-894f-0d108c4746ad"), 57, new DateTime(1965, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefano", 13, "https://img.a.transfermarkt.technology/portrait/big/2135-1663977168.jpg?lm=1", "Pioli", "Italy" },
                    { new Guid("871c26b3-c051-43ce-a662-db5571f69606"), 45, new DateTime(1978, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igor", 11, "https://img.a.transfermarkt.technology/portrait/big/28632-1646406004.jpg?lm=1", "Tudor", "Croatia" },
                    { new Guid("a72e3e49-4099-46e3-a389-8d1dae6c1961"), 51, new DateTime(1973, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davide", 4, "https://img.a.transfermarkt.technology/portrait/big/14892-1644914474.png?lm=1", "Nicola", "Italy" },
                    { new Guid("c2fc6829-ee9e-4f13-86aa-f5b858f5d792"), 53, new DateTime(1969, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eusebio", 6, "https://img.a.transfermarkt.technology/portrait/big/12924-1631177386.jpg?lm=1", "Di Francesco", "Italy" },
                    { new Guid("c91969c6-bcfa-48ae-8795-908277ae4abf"), 65, new DateTime(1958, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gian Piero", 1, "https://img.a.transfermarkt.technology/portrait/big/3436-1663862210.jpg?lm=1", "Gasperini", "Italy" },
                    { new Guid("d6981722-772b-44c0-acf2-8ef5f411ea4c"), 71, new DateTime(1951, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claudio", 3, "https://img.a.transfermarkt.technology/portrait/big/456-1521199129.jpg?lm=1", "Ranieri", "Italy" },
                    { new Guid("db0ccb79-686a-4756-b769-46a7291d781f"), 55, new DateTime(1967, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massimiliano", 10, "https://img.a.transfermarkt.technology/portrait/big/7671-1663973141.jpg?lm=1", "Allegri", "Italy" },
                    { new Guid("ed8a8072-57bd-4e2a-a751-1b4550228ab9"), 47, new DateTime(1976, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simone", 9, "https://img.a.transfermarkt.technology/portrait/big/21624-1663979865.jpg?lm=1", "Inzaghi", "Italy" },
                    { new Guid("fbb1b90a-a685-4120-ab28-858978bbd2a1"), 56, new DateTime(1967, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luca", 12, "https://img.a.transfermarkt.technology/portrait/big/7521-1663926746.jpg?lm=1", "Gotti", "Italy" },
                    { new Guid("fe1bf65e-e8d6-4e6c-9bd4-552c4f483159"), 45, new DateTime(1977, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincenzo", 5, "https://img.a.transfermarkt.technology/portrait/big/47288-1663950225.jpg?lm=1", "Italiano", "Italy" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "BirthDate", "ContractExpiredDate", "ContractSignedDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "MarketValue", "Nationality", "Number", "Position" },
                values: new object[,]
                {
                    { new Guid("10c6c12d-1b35-42bc-802a-6e88e84acd11"), 23, new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pierre", 13, "https://img.a.transfermarkt.technology/portrait/big/585949-1684854558.jpg?lm=1", "Kalulu", "€30.00m", "France", 20, "Centre-Back" },
                    { new Guid("18faea62-bacf-43d0-bc27-91ebe995b3d1"), 32, new DateTime(1991, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francesco", 1, "https://img.a.transfermarkt.technology/portrait/big/126634-1644234341.jpg?lm=1", "Rossi", "€100k", "Italy", 31, "Goalkeeper" },
                    { new Guid("1ea4137b-c356-403e-915a-926f52057afc"), 25, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fikayo", 13, "https://img.a.transfermarkt.technology/portrait/big/303254-1684856117.jpg?lm=1", "Tomori", "€40.00m", "England", 23, "Centre-Back" },
                    { new Guid("2159a3fc-2173-46da-8960-c4ec703b1154"), 23, new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 1, "https://img.a.transfermarkt.technology/portrait/big/459763-1598856203.jpg?lm=1", "Carnesecchi", "€13.00m", "Italy", 29, "Goalkeeper" },
                    { new Guid("721d0eb7-e122-425b-a808-33bb10a1493a"), 28, new DateTime(1995, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike", 13, "https://img.a.transfermarkt.technology/portrait/big/182906-1681459155.jpg?lm=1", "Maignan", "€45.00m", "France", 16, "Goalkeeper" },
                    { new Guid("75e2d346-b8ad-4aa0-bfd2-33d3f6a83f55"), 31, new DateTime(1992, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 13, "https://img.a.transfermarkt.technology/portrait/big/199976-1661351013.jpg?lm=1", "Sportiello", "€1.50m", "Italy", 57, "Goalkeeper" },
                    { new Guid("76b27127-2c65-47cf-9136-82c9eab274dd"), 29, new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", 1, "https://img.a.transfermarkt.technology/portrait/big/242359-1663583047.jpg?lm=1", "Musso", "€8.00m", "Argentina", 1, "Goalkeeper" },
                    { new Guid("848e40e2-7ddf-4642-990c-6767b488120f"), 40, new DateTime(1983, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", 13, "https://img.a.transfermarkt.technology/portrait/big/22141-1663574908.jpg?lm=1", "Mirante", "€100k", "Italy", 83, "Goalkeeper" },
                    { new Guid("9d1abc71-bd4f-4348-9a84-8143aaec879c"), 19, new DateTime(2003, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giorgio", 1, "https://img.a.transfermarkt.technology/portrait/big/571604-1679479850.jpg?lm=1", "Scalvini", "€40.00m", "Italy", 42, "Centre-Back" },
                    { new Guid("afb16257-fa10-451c-8541-591642792273"), 30, new DateTime(1993, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berat", 1, "https://img.a.transfermarkt.technology/portrait/big/165513-1663582842.jpg?lm=1", "Djimsiti", "€10.00m", "Albania", 19, "Centre-Back" }
                });

            migrationBuilder.InsertData(
                table: "Presidents",
                columns: new[] { "Id", "Age", "BirthDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("01e8d9f6-9cb8-41dd-a56a-b2689ea8ae63"), 59, new DateTime(1963, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gianluca", 10, "https://img.a.transfermarkt.technology/portrait/big/112227-1675245583.jpg?lm=1", "Ferrero", "Italy" },
                    { new Guid("06b45893-172c-4f65-82b9-7d1aa2b6a207"), 73, new DateTime(1949, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocco", 5, "https://img.a.transfermarkt.technology/portrait/big/70038-1586856311.jpg?lm=1", "Commisso", "USA" },
                    { new Guid("094caad9-570a-4a4d-81f7-ce2141ad8c48"), 65, new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurizio", 6, "https://img.a.transfermarkt.technology/portrait/big/16894-1454497522.jpg?lm=1", "Stirpe", "Italy" },
                    { new Guid("0b420965-da31-415c-a42f-137d63b449de"), 60, new DateTime(1963, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurizio", 8, "https://img.a.transfermarkt.technology/portrait/big/31168-1663949590.jpg?lm=1", "Setti", "Italy" },
                    { new Guid("1eb8cc36-c42c-45fd-8c12-2f1f6a6422e9"), 70, new DateTime(1953, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", 1, "https://img.a.transfermarkt.technology/portrait/big/13226-1554472586.jpg?lm=1", "Percassi", "Italy" },
                    { new Guid("36ed41b3-f7b5-4391-abe2-1306bcdad666"), 65, new DateTime(1958, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto", 7, "https://img.a.transfermarkt.technology/portrait/big/98501-1637592266.jpg?lm=1", "Zangrillo", "Italy" },
                    { new Guid("447a5a8d-9354-4d65-a452-6be8135bb074"), 46, new DateTime(1977, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommaso", 3, "https://img.a.transfermarkt.technology/portrait/big/35327-1419868018.jpg?lm=1", "Giulini", "Italy" },
                    { new Guid("4f65253e-9756-4fdc-a7be-85e82456bd4c"), 31, new DateTime(1991, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", 9, "https://img.a.transfermarkt.technology/portrait/big/50590-1663979396.jpg?lm=1", "Zhang", "China" }
                });

            migrationBuilder.InsertData(
                table: "Presidents",
                columns: new[] { "Id", "Age", "BirthDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("57e1df18-3494-4179-b666-f7f2accc9914"), 73, new DateTime(1949, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paolo", 14, "https://img.a.transfermarkt.technology/portrait/big/13647-1553874773.jpg?lm=1", "Berlusconi", "Italy" },
                    { new Guid("5eea96dc-9ca6-4ec4-b269-7fe6a1fda61d"), 66, new DateTime(1957, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claudio", 11, "https://img.a.transfermarkt.technology/portrait/big/8685-1584712373.jpg?lm=1", "Lotito", "Italy" },
                    { new Guid("7a16dca4-ee2c-4512-ac46-b1085e84a569"), 66, new DateTime(1957, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urbano", 19, "https://img.a.transfermarkt.technology/portrait/big/13945-1663947949.jpg?lm=1", "Cairo", "Italy" },
                    { new Guid("88a88895-c486-47bb-93e9-a0a8edf135bc"), 58, new DateTime(1964, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joey", 2, "https://img.a.transfermarkt.technology/portrait/big/43324-1663930539.jpg?lm=1", "Saputo", "Canada" },
                    { new Guid("8f705a22-54ec-4dd1-88d9-69e99e771b4a"), 48, new DateTime(1975, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saverio", 12, "https://img.a.transfermarkt.technology/portrait/big/78495-1586856165.jpg?lm=1", "Sticchi Damiani", "Italy" },
                    { new Guid("9292d3e2-9cdf-4e6a-b646-1de9a5023e40"), 58, new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan", 16, "https://img.a.transfermarkt.technology/portrait/header/default.jpg?lm=1", "Friedkin", "USA" },
                    { new Guid("9d8c7686-078a-4199-af4c-5678e6e1b19a"), 74, new DateTime(1949, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aurelio", 15, "https://img.a.transfermarkt.technology/portrait/big/12590-1663975832.jpg?lm=1", "de Laurentis", "Italy" },
                    { new Guid("c1539dc0-b2dc-4933-8af4-677f30953802"), 82, new DateTime(1941, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giampaolo", 20, "https://img.a.transfermarkt.technology/portrait/big/_1366357924.jpg?lm=1", "Pozzo", "Italy" },
                    { new Guid("cb01a8b3-47e9-4d31-8a87-de45df1122c2"), 72, new DateTime(1951, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlo", 18, "https://img.a.transfermarkt.technology/portrait/big/16896-1663947412.jpg?lm=1", "Rossi", "Italy" },
                    { new Guid("d18f69d1-4406-4803-b13f-b5c0d390edef"), 45, new DateTime(1978, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danilo", 17, "https://img.a.transfermarkt.technology/portrait/big/104555-1663926110.jpg?lm=1", "Iervolino", "Italy" },
                    { new Guid("e8bee67e-e0ed-4789-a308-0b1bf5e6b0b6"), 62, new DateTime(1960, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabrizio", 4, "https://img.a.transfermarkt.technology/portrait/big/16891-1663929957.jpg?lm=1", "Corsi", "Italy" },
                    { new Guid("f5c3e91e-4ab4-436e-a6b9-a31da4bb1da5"), 76, new DateTime(1946, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paolo", 13, "https://img.a.transfermarkt.technology/portrait/big/61951-1663977917.jpg?lm=1", "Scaroni", "Italy" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("469c79e1-d881-4c0b-952f-f08af274800d"), new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a") });

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_AwayTeamId",
                table: "Fixtures",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_HomeTeamId",
                table: "Fixtures",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_LeagueId",
                table: "Fixtures",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_StadiumId",
                table: "Fixtures",
                column: "StadiumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("469c79e1-d881-4c0b-952f-f08af274800d"), new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("37390eb1-f3f7-45ee-835f-9712488e3aa5"));

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("0343df0b-cf7b-4ea1-b22e-b5d1b37d6b01"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("060dcb8f-8672-4425-b4ea-1cb5786470dc"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("0ac01812-5943-4e1e-af5a-0296e9dffb73"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("10b38ca7-9319-49c4-93a8-b49a371083b6"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("188a7590-3b45-40a5-bc4c-e660369bc2e5"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("26c069ee-17cc-4f2c-8d80-88658cf99b3e"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("51125581-f439-4f2a-aa8c-2ea1e001df3c"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("53c51138-aa94-4f3f-8e1b-c26a45d28f69"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("53e492a8-c95d-4b01-bc24-79c63939233c"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("64637af9-4047-4840-b202-a855a9414bc1"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("7596dcb1-be28-4810-894f-0d108c4746ad"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("871c26b3-c051-43ce-a662-db5571f69606"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("a72e3e49-4099-46e3-a389-8d1dae6c1961"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("c2fc6829-ee9e-4f13-86aa-f5b858f5d792"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("c91969c6-bcfa-48ae-8795-908277ae4abf"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("d6981722-772b-44c0-acf2-8ef5f411ea4c"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("db0ccb79-686a-4756-b769-46a7291d781f"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("ed8a8072-57bd-4e2a-a751-1b4550228ab9"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("fbb1b90a-a685-4120-ab28-858978bbd2a1"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("fe1bf65e-e8d6-4e6c-9bd4-552c4f483159"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("10c6c12d-1b35-42bc-802a-6e88e84acd11"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("18faea62-bacf-43d0-bc27-91ebe995b3d1"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1ea4137b-c356-403e-915a-926f52057afc"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2159a3fc-2173-46da-8960-c4ec703b1154"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("721d0eb7-e122-425b-a808-33bb10a1493a"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("75e2d346-b8ad-4aa0-bfd2-33d3f6a83f55"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("76b27127-2c65-47cf-9136-82c9eab274dd"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("848e40e2-7ddf-4642-990c-6767b488120f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9d1abc71-bd4f-4348-9a84-8143aaec879c"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("afb16257-fa10-451c-8541-591642792273"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("01e8d9f6-9cb8-41dd-a56a-b2689ea8ae63"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("06b45893-172c-4f65-82b9-7d1aa2b6a207"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("094caad9-570a-4a4d-81f7-ce2141ad8c48"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("0b420965-da31-415c-a42f-137d63b449de"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("1eb8cc36-c42c-45fd-8c12-2f1f6a6422e9"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("36ed41b3-f7b5-4391-abe2-1306bcdad666"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("447a5a8d-9354-4d65-a452-6be8135bb074"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("4f65253e-9756-4fdc-a7be-85e82456bd4c"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("57e1df18-3494-4179-b666-f7f2accc9914"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("5eea96dc-9ca6-4ec4-b269-7fe6a1fda61d"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("7a16dca4-ee2c-4512-ac46-b1085e84a569"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("88a88895-c486-47bb-93e9-a0a8edf135bc"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("8f705a22-54ec-4dd1-88d9-69e99e771b4a"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("9292d3e2-9cdf-4e6a-b646-1de9a5023e40"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("9d8c7686-078a-4199-af4c-5678e6e1b19a"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("c1539dc0-b2dc-4933-8af4-677f30953802"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("cb01a8b3-47e9-4d31-8a87-de45df1122c2"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("d18f69d1-4406-4803-b13f-b5c0d390edef"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("e8bee67e-e0ed-4789-a308-0b1bf5e6b0b6"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("f5c3e91e-4ab4-436e-a6b9-a31da4bb1da5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("469c79e1-d881-4c0b-952f-f08af274800d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a"));

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FootballClubs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
