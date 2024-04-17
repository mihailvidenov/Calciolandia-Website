using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calciolandia_Website.Core.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("469c79e1-d881-4c0b-952f-f08af274800d"), "88653cad-d5ac-46b2-9138-ee768498d3f2", "Admin", "ADMIN" });

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
                    { new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a"), 0, "d218c484-a3e4-478f-85d7-918e0689592c", "m_fvidenov@abv.bg", true, "Mihail", 5, "Videnov", false, null, "m_fvidenov@abv.bg", "mishaka002", "AQAAAAEAACcQAAAAEHRpevlGNv+im53ROtN46AKfCZ0pyk7NoqRLuzmyL9imXK6CGasukDe2b/MJrUAL0w==", null, false, "35ed46ee-1769-45e3-9423-1220a3e00937", false, "mishaka002" },
                    { new Guid("37390eb1-f3f7-45ee-835f-9712488e3aa5"), 0, "488d0f22-e1a6-4991-8555-3bcab20a52f1", "luben_6@abv.bg", true, "Luben", 7, "Videnov", false, null, "luben_6@abv.bg", "luben_v", "AQAAAAEAACcQAAAAEPBfPiwyGlZSNxdm+JPx0g5h/m1NM7G0/QyEuvj+jh0B9UamUI/3xKUXL6gatTMU2Q==", null, false, "8e479450-eaa6-4ddd-bd0f-80b8418c2ca3", false, "luben_v" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "BirthDate", "ContractExpiredDate", "ContractSignedDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("06359a11-1b8e-4d68-8a14-93a9f62df023"), 45, new DateTime(1977, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincenzo", 5, "https://img.a.transfermarkt.technology/portrait/big/47288-1663950225.jpg?lm=1", "Italiano", "Italy" },
                    { new Guid("09c15472-4b49-4159-a7e2-2bcbd3574482"), 45, new DateTime(1978, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Igor", 11, "https://img.a.transfermarkt.technology/portrait/big/28632-1646406004.jpg?lm=1", "Tudor", "Croatia" },
                    { new Guid("0badfa91-6a6e-473e-ad94-e3fa773ca8f3"), 40, new DateTime(1982, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiago", 2, "https://img.a.transfermarkt.technology/portrait/big/61868-1663936050.jpg?lm=1", "Motta", "Italy/Brazil" },
                    { new Guid("20a2ca55-015e-495e-8625-c33835279de5"), 47, new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", 19, "https://img.a.transfermarkt.technology/portrait/big/16508-1594718677.jpg?lm=1", "Juric", "Croatia" },
                    { new Guid("43ab269e-5d82-4597-b48a-8d30242eb9db"), 61, new DateTime(1962, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefano", 17, "https://img.a.transfermarkt.technology/portrait/big/2127-1634565915.jpg?lm=1", "Colantuono", "Italy" },
                    { new Guid("6441b949-99f5-47ec-81cf-88428a68106c"), 48, new DateTime(1975, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriele", 20, "https://img.a.transfermarkt.technology/portrait/big/31903-1639297579.jpg?lm=1", "Cioffi", "Italy" },
                    { new Guid("684cc1a8-aba9-468f-9064-50cf93dc38b6"), 51, new DateTime(1973, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davide", 4, "https://img.a.transfermarkt.technology/portrait/big/14892-1644914474.png?lm=1", "Nicola", "Italy" },
                    { new Guid("7e174150-46d8-4212-a277-71bcf48533ca"), 47, new DateTime(1976, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simone", 9, "https://img.a.transfermarkt.technology/portrait/big/21624-1663979865.jpg?lm=1", "Inzaghi", "Italy" },
                    { new Guid("8a26d55a-b31e-42cb-9d9f-59b3264fb010"), 60, new DateTime(1964, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davide", 18, "https://img.a.transfermarkt.technology/portrait/big/3793-1631177487.jpg?lm=1", "Ballardini", "Italy" },
                    { new Guid("9036b20d-a358-45a8-b365-c650bfbc4f1e"), 56, new DateTime(1967, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luca", 12, "https://img.a.transfermarkt.technology/portrait/big/7521-1663926746.jpg?lm=1", "Gotti", "Italy" },
                    { new Guid("9329eae6-8c15-498d-8d93-4337977b9a4d"), 55, new DateTime(1968, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francesco", 15, "https://img.a.transfermarkt.technology/portrait/big/33804-1697643746.jpg?lm=1", "Calzona", "Italy" },
                    { new Guid("972b0b8b-8eaa-423d-bbff-1f7e8c1e535c"), 65, new DateTime(1958, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gian Piero", 1, "https://img.a.transfermarkt.technology/portrait/big/3436-1663862210.jpg?lm=1", "Gasperini", "Italy" },
                    { new Guid("972c4f08-af5d-4272-bcb4-4b21fb3b2fae"), 53, new DateTime(1969, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eusebio", 6, "https://img.a.transfermarkt.technology/portrait/big/12924-1631177386.jpg?lm=1", "Di Francesco", "Italy" },
                    { new Guid("9c317d80-2087-4057-ad68-ac4daffcfa90"), 40, new DateTime(1983, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniele", 16, "https://img.a.transfermarkt.technology/portrait/big/90748-1616069982.jpg?lm=1", "De Rossi", "Italy" },
                    { new Guid("ac6a9d0b-0ed7-40f5-8fe0-c403678a4682"), 59, new DateTime(1963, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 8, "https://img.a.transfermarkt.technology/portrait/big/12015-1649752265.jpg?lm=1", "Baroni", "Italy" },
                    { new Guid("b058c585-5d3e-4211-8d6a-ea2938360418"), 57, new DateTime(1965, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefano", 13, "https://img.a.transfermarkt.technology/portrait/big/2135-1663977168.jpg?lm=1", "Pioli", "Italy" },
                    { new Guid("b6f3ff15-f349-4b29-93a1-fe011ee9df12"), 55, new DateTime(1967, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massimiliano", 10, "https://img.a.transfermarkt.technology/portrait/big/7671-1663973141.jpg?lm=1", "Allegri", "Italy" },
                    { new Guid("d6b7d86d-9e3d-4c59-87da-dd61b04cea25"), 41, new DateTime(1982, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto", 7, "https://img.a.transfermarkt.technology/portrait/big/64045-1673622044.jpg?lm=1", "Gilardino", "Italy" },
                    { new Guid("e6c70dea-5f3f-4649-9f1e-7044458e91e3"), 39, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raffaele", 14, "https://img.a.transfermarkt.technology/portrait/big/95674-1663872108.jpg?lm=1", "Palladino", "Italy" },
                    { new Guid("fe23bdcb-7edf-4ce1-9507-60939a62ed78"), 71, new DateTime(1951, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claudio", 3, "https://img.a.transfermarkt.technology/portrait/big/456-1521199129.jpg?lm=1", "Ranieri", "Italy" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "BirthDate", "ContractExpiredDate", "ContractSignedDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "MarketValue", "Nationality", "Number", "Position" },
                values: new object[,]
                {
                    { new Guid("09a3af60-0bc2-41f6-9461-64eaa5acb913"), 30, new DateTime(1993, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berat", 1, "https://img.a.transfermarkt.technology/portrait/big/165513-1663582842.jpg?lm=1", "Djimsiti", "€10.00m", "Albania", 19, "Centre-Back" },
                    { new Guid("18f68436-ad9f-4659-909a-03cb28a147b8"), 32, new DateTime(1991, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francesco", 1, "https://img.a.transfermarkt.technology/portrait/big/126634-1644234341.jpg?lm=1", "Rossi", "€100k", "Italy", 31, "Goalkeeper" },
                    { new Guid("28a4fc6c-6fd3-48d6-a157-4f927703e115"), 19, new DateTime(2003, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giorgio", 1, "https://img.a.transfermarkt.technology/portrait/big/571604-1679479850.jpg?lm=1", "Scalvini", "€40.00m", "Italy", 42, "Centre-Back" },
                    { new Guid("2d6ec059-3f59-4caf-873a-55eb0119a5e1"), 28, new DateTime(1995, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mike", 13, "https://img.a.transfermarkt.technology/portrait/big/182906-1681459155.jpg?lm=1", "Maignan", "€45.00m", "France", 16, "Goalkeeper" },
                    { new Guid("33cfbefc-5132-41e9-985f-ee9453d70648"), 23, new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 1, "https://img.a.transfermarkt.technology/portrait/big/459763-1598856203.jpg?lm=1", "Carnesecchi", "€13.00m", "Italy", 29, "Goalkeeper" },
                    { new Guid("4e95973f-49ed-4d57-9f80-86bb887163da"), 25, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fikayo", 13, "https://img.a.transfermarkt.technology/portrait/big/303254-1684856117.jpg?lm=1", "Tomori", "€40.00m", "England", 23, "Centre-Back" },
                    { new Guid("58a03745-8249-432c-836b-b24ba69805dc"), 23, new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pierre", 13, "https://img.a.transfermarkt.technology/portrait/big/585949-1684854558.jpg?lm=1", "Kalulu", "€30.00m", "France", 20, "Centre-Back" },
                    { new Guid("7ddc6035-0f42-4b50-9d31-8ec50599f238"), 31, new DateTime(1992, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2027, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco", 13, "https://img.a.transfermarkt.technology/portrait/big/199976-1661351013.jpg?lm=1", "Sportiello", "€1.50m", "Italy", 57, "Goalkeeper" },
                    { new Guid("a532c3d6-c754-4b74-8d9d-cd3c7ca309c6"), 29, new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", 1, "https://img.a.transfermarkt.technology/portrait/big/242359-1663583047.jpg?lm=1", "Musso", "€8.00m", "Argentina", 1, "Goalkeeper" },
                    { new Guid("cd5c47a9-c5ec-49e8-9473-82dd0e99979c"), 40, new DateTime(1983, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", 13, "https://img.a.transfermarkt.technology/portrait/big/22141-1663574908.jpg?lm=1", "Mirante", "€100k", "Italy", 83, "Goalkeeper" }
                });

            migrationBuilder.InsertData(
                table: "Presidents",
                columns: new[] { "Id", "Age", "BirthDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("106d838d-410f-4b90-843d-62a589054401"), 59, new DateTime(1963, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gianluca", 10, "https://img.a.transfermarkt.technology/portrait/big/112227-1675245583.jpg?lm=1", "Ferrero", "Italy" },
                    { new Guid("1fe8807f-92e6-4ff0-967c-828ecc314145"), 76, new DateTime(1946, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paolo", 13, "https://img.a.transfermarkt.technology/portrait/big/61951-1663977917.jpg?lm=1", "Scaroni", "Italy" },
                    { new Guid("2542fa4d-0464-4370-a02c-625b15fe53bf"), 73, new DateTime(1949, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paolo", 14, "https://img.a.transfermarkt.technology/portrait/big/13647-1553874773.jpg?lm=1", "Berlusconi", "Italy" },
                    { new Guid("3d3866ed-9cbf-4e5b-add0-0bc786eaf034"), 70, new DateTime(1953, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", 1, "https://img.a.transfermarkt.technology/portrait/big/13226-1554472586.jpg?lm=1", "Percassi", "Italy" },
                    { new Guid("46aaa8d3-7b7b-44b3-8f48-08654feb57ac"), 66, new DateTime(1957, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claudio", 11, "https://img.a.transfermarkt.technology/portrait/big/8685-1584712373.jpg?lm=1", "Lotito", "Italy" },
                    { new Guid("51da2fdb-f426-4ee8-ac2f-61742657f50a"), 74, new DateTime(1949, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aurelio", 15, "https://img.a.transfermarkt.technology/portrait/big/12590-1663975832.jpg?lm=1", "de Laurentis", "Italy" },
                    { new Guid("609d07e1-8779-499f-86c8-a55cdf92df45"), 65, new DateTime(1958, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto", 7, "https://img.a.transfermarkt.technology/portrait/big/98501-1637592266.jpg?lm=1", "Zangrillo", "Italy" },
                    { new Guid("61a18c6b-519d-42a2-8a7e-fe1faa7464e0"), 65, new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurizio", 6, "https://img.a.transfermarkt.technology/portrait/big/16894-1454497522.jpg?lm=1", "Stirpe", "Italy" },
                    { new Guid("7288f208-c722-4f42-a8cc-e76eaaf98b25"), 31, new DateTime(1991, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", 9, "https://img.a.transfermarkt.technology/portrait/big/50590-1663979396.jpg?lm=1", "Zhang", "China" },
                    { new Guid("8b4ef94d-a1ab-465d-8902-018d6fa145c7"), 60, new DateTime(1963, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurizio", 8, "https://img.a.transfermarkt.technology/portrait/big/31168-1663949590.jpg?lm=1", "Setti", "Italy" }
                });

            migrationBuilder.InsertData(
                table: "Presidents",
                columns: new[] { "Id", "Age", "BirthDate", "FirstName", "FootballClubId", "ImageUrl", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("9f78e5f9-9d80-43f6-9da1-da416be31847"), 46, new DateTime(1977, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommaso", 3, "https://img.a.transfermarkt.technology/portrait/big/35327-1419868018.jpg?lm=1", "Giulini", "Italy" },
                    { new Guid("aad00937-c629-4a4e-b078-582ecc17b60b"), 82, new DateTime(1941, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giampaolo", 20, "https://img.a.transfermarkt.technology/portrait/big/_1366357924.jpg?lm=1", "Pozzo", "Italy" },
                    { new Guid("b9f15c84-f76a-4656-9790-df37b2f454b3"), 58, new DateTime(1964, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joey", 2, "https://img.a.transfermarkt.technology/portrait/big/43324-1663930539.jpg?lm=1", "Saputo", "Canada" },
                    { new Guid("bdcf999d-5027-489d-9f89-40b8cfba5f9a"), 45, new DateTime(1978, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danilo", 17, "https://img.a.transfermarkt.technology/portrait/big/104555-1663926110.jpg?lm=1", "Iervolino", "Italy" },
                    { new Guid("c95b95de-b569-46dc-b4d1-1a6ea1b11187"), 66, new DateTime(1957, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urbano", 19, "https://img.a.transfermarkt.technology/portrait/big/13945-1663947949.jpg?lm=1", "Cairo", "Italy" },
                    { new Guid("d8428001-ae9a-4074-bb41-e13cfe73ff0e"), 48, new DateTime(1975, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saverio", 12, "https://img.a.transfermarkt.technology/portrait/big/78495-1586856165.jpg?lm=1", "Sticchi Damiani", "Italy" },
                    { new Guid("de9c779b-e42d-490c-b9c2-5e55c7aaeed8"), 62, new DateTime(1960, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabrizio", 4, "https://img.a.transfermarkt.technology/portrait/big/16891-1663929957.jpg?lm=1", "Corsi", "Italy" },
                    { new Guid("e35cb67a-49b6-4631-93ca-4bc7f3fa228f"), 72, new DateTime(1951, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlo", 18, "https://img.a.transfermarkt.technology/portrait/big/16896-1663947412.jpg?lm=1", "Rossi", "Italy" },
                    { new Guid("e5fc55d0-7354-4856-abf0-0b478fbc9fb8"), 73, new DateTime(1949, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocco", 5, "https://img.a.transfermarkt.technology/portrait/big/70038-1586856311.jpg?lm=1", "Commisso", "USA" },
                    { new Guid("f6335916-2e6c-466f-86ce-4b1555e0ce2d"), 58, new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan", 16, "https://img.a.transfermarkt.technology/portrait/header/default.jpg?lm=1", "Friedkin", "USA" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("469c79e1-d881-4c0b-952f-f08af274800d"), new Guid("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("06359a11-1b8e-4d68-8a14-93a9f62df023"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("09c15472-4b49-4159-a7e2-2bcbd3574482"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("0badfa91-6a6e-473e-ad94-e3fa773ca8f3"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("20a2ca55-015e-495e-8625-c33835279de5"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("43ab269e-5d82-4597-b48a-8d30242eb9db"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("6441b949-99f5-47ec-81cf-88428a68106c"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("684cc1a8-aba9-468f-9064-50cf93dc38b6"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("7e174150-46d8-4212-a277-71bcf48533ca"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("8a26d55a-b31e-42cb-9d9f-59b3264fb010"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("9036b20d-a358-45a8-b365-c650bfbc4f1e"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("9329eae6-8c15-498d-8d93-4337977b9a4d"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("972b0b8b-8eaa-423d-bbff-1f7e8c1e535c"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("972c4f08-af5d-4272-bcb4-4b21fb3b2fae"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("9c317d80-2087-4057-ad68-ac4daffcfa90"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("ac6a9d0b-0ed7-40f5-8fe0-c403678a4682"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("b058c585-5d3e-4211-8d6a-ea2938360418"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("b6f3ff15-f349-4b29-93a1-fe011ee9df12"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("d6b7d86d-9e3d-4c59-87da-dd61b04cea25"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("e6c70dea-5f3f-4649-9f1e-7044458e91e3"));

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("fe23bdcb-7edf-4ce1-9507-60939a62ed78"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("09a3af60-0bc2-41f6-9461-64eaa5acb913"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("18f68436-ad9f-4659-909a-03cb28a147b8"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("28a4fc6c-6fd3-48d6-a157-4f927703e115"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("2d6ec059-3f59-4caf-873a-55eb0119a5e1"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("33cfbefc-5132-41e9-985f-ee9453d70648"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("4e95973f-49ed-4d57-9f80-86bb887163da"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("58a03745-8249-432c-836b-b24ba69805dc"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7ddc6035-0f42-4b50-9d31-8ec50599f238"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("a532c3d6-c754-4b74-8d9d-cd3c7ca309c6"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("cd5c47a9-c5ec-49e8-9473-82dd0e99979c"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("106d838d-410f-4b90-843d-62a589054401"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("1fe8807f-92e6-4ff0-967c-828ecc314145"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("2542fa4d-0464-4370-a02c-625b15fe53bf"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("3d3866ed-9cbf-4e5b-add0-0bc786eaf034"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("46aaa8d3-7b7b-44b3-8f48-08654feb57ac"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("51da2fdb-f426-4ee8-ac2f-61742657f50a"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("609d07e1-8779-499f-86c8-a55cdf92df45"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("61a18c6b-519d-42a2-8a7e-fe1faa7464e0"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("7288f208-c722-4f42-a8cc-e76eaaf98b25"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("8b4ef94d-a1ab-465d-8902-018d6fa145c7"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("9f78e5f9-9d80-43f6-9da1-da416be31847"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("aad00937-c629-4a4e-b078-582ecc17b60b"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("b9f15c84-f76a-4656-9790-df37b2f454b3"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("bdcf999d-5027-489d-9f89-40b8cfba5f9a"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("c95b95de-b569-46dc-b4d1-1a6ea1b11187"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("d8428001-ae9a-4074-bb41-e13cfe73ff0e"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("de9c779b-e42d-490c-b9c2-5e55c7aaeed8"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("e35cb67a-49b6-4631-93ca-4bc7f3fa228f"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("e5fc55d0-7354-4856-abf0-0b478fbc9fb8"));

            migrationBuilder.DeleteData(
                table: "Presidents",
                keyColumn: "Id",
                keyValue: new Guid("f6335916-2e6c-466f-86ce-4b1555e0ce2d"));

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
