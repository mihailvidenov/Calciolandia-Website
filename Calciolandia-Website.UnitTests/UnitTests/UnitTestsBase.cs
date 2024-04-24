using Calciolandia_Website.Core.Data;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.UnitTests.Mocks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.UnitTests.UnitTests
{
    public class UnitTestsBase
    {
        protected ApplicationDbContext data;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            this.data = DatabaseMock.Instance;
            this.SeedDatabase();
        }

        public League SerieA { get; set; }
        public FootballClub Milan { get; set; }
        public FootballClub Atalanta { get; set; }
        public Stadium Gewiss { get; set; }
        public Stadium Meazza { get; set; }

        public Manager Gasperini { get; set; }
        public Player Djimsiti { get; set; }
        public Player Scalvini { get; set; }

        public President Percassi { get; set; }
        public Fixture Fixture1 { get; set; }

        private void SeedDatabase()
        {
            this.SerieA = new League()
            {
                Id = 1,
                Name = "Serie A",
                Country = "Italy",
                LogoImageUrl = "https://tmssl.akamaized.net/images/logo/header/it1.png?lm=1656073460"
            };

            this.data.Leagues.Add(this.SerieA);

            this.Gewiss = new Stadium()
            {
                Id = 1,
                Name = "Gewiss Stadium",
                Capacity = 19768,
                ImageUrl = "https://img.legaseriea.it/vimages/62cef799/7%20(1).jpg?webp&q=70&size=999x-",
                Address = "Viale Giulio Cesare, 18, 24124 Bergamo BG",
                City = "Bergamo"
            };

            this.data.Stadiums.Add(this.Gewiss);

            this.Meazza = new Stadium()
            {
                Id = 2,
                Name = "Giuseppe Meazza",
                Capacity = 80018,
                ImageUrl = "https://img.legaseriea.it/vimages/632b5612/775454473ML003_FC_Internazi.JPG?webp&q=70&size=999x-",
                Address = "Piazzale Angelo Moratti, 20151 Milan MI",
                City = "Milan"
            };

            this.data.Stadiums.Add(this.Meazza);

            this.Milan = new FootballClub()
            {
                Id = 1,
                Name = "AC Milan",
                Nickname = "Rossoneri",
                Trophies = 19,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef513/milan.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Milan",
                Address = "Via Aldo Rossi 8 20149 Milano Italy",
                LeagueId = 1,
                StadiumId = 2
            };
            this.data.FootballClubs.Add(this.Milan);

            this.Atalanta = new FootballClub()
            {
                Id = 2,
                Name = "Atalanta BC",
                Nickname = "La Dea",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cfd69d/atalanta.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Bergamo",
                Address = "Zingonia - Corso Europa 20040 Bergamo Italy",
                LeagueId = 1,
                StadiumId = 1
            };
            this.data.FootballClubs.Add(this.Atalanta);


            this.Djimsiti = new Player()
            {
                Id = Guid.Parse("3534674c-15bc-458f-b08d-a16a731e63ff"),
                FirstName = "Berat",
                LastName = "Djimsiti",
                Nationality = "Albania",
                Age = 30,
                BirthDate = DateTime.ParseExact("1993-02-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2016-01-18", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2026-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Centre-Back",
                MarketValue = "€10.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/165513-1663582842.jpg?lm=1",
                Number = 19,
                FootballClubId = 2
            };
            this.data.Players.Add(this.Djimsiti);

            this.Scalvini = new Player()
            {
                Id = Guid.Parse("cf3ad595-4bec-4929-ae4e-d5d1b1921f9d"),
                FirstName = "Giorgio",
                LastName = "Scalvini",
                Nationality = "Italy",
                Age = 19,
                BirthDate = DateTime.ParseExact("2003-12-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2027-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Centre-Back",
                MarketValue = "€40.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/571604-1679479850.jpg?lm=1",
                Number = 42,
                FootballClubId = 2
            };
            this.data.Players.Add(this.Scalvini);

            this.Percassi = new President()
            {
                Id = Guid.Parse("cebacb9b-443c-436f-a9c2-128c3f6b0af1"),
                FirstName = "Antonio",
                LastName = "Percassi",
                Nationality = "Italy",
                Age = 70,
                BirthDate = DateTime.ParseExact("1953-06-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/13226-1554472586.jpg?lm=1",
                FootballClubId = 2
            };
            this.data.Presidents.Add(this.Percassi);

            this.Gasperini = new Manager()
            {
                Id = Guid.Parse("a79d8cd6-d35e-4044-b23a-b9dd269a45ad"),
                FirstName = "Gian Piero",
                LastName = "Gasperini",
                Nationality = "Italy",
                Age = 65,
                BirthDate = DateTime.ParseExact("1958-01-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2016-06-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 2,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/3436-1663862210.jpg?lm=1"
            };
            this.data.Managers.Add(this.Gasperini);

            this.Fixture1 = new Fixture()
            {

                Id = Guid.Parse("5510d487-6fc1-4f46-95cb-a52da9973ae4"),
                Season = "2023/2024",
                Round = 33,
                Result = "0 - 1",
                Date = DateTime.ParseExact("2024-04-19", "yyyy-MM-dd",
                  CultureInfo.InvariantCulture),
                Time = "19:30",
                HomeTeamId = 1,
                AwayTeamId = 2,
                StadiumId = 1,
                LeagueId = 1
            };
            this.data.Fixtures.Add(this.Fixture1);

            this.data.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase()
            => this.data.Dispose();
    }
}
