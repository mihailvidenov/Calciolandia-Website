using Calciolandia_Website.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasData(CreatePlayers());
        }

        private List<Player> CreatePlayers()
        {
            var players = new List<Player>();

            var maignan = new Player()
            {
                Id = Guid.Parse("79981C6F-F60E-4E7B-2A5B-08DB9A8B4C5F"),
                FirstName = "Mike",
                LastName = "Maignan",
                Nationality = "France",
                Age = 28,
                BirthDate = DateTime.ParseExact("1995-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2026-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€45.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/182906-1681459155.jpg?lm=1",
                Number = 16,
                FootballClubId = 13
            };

            players.Add(maignan);

            var sportiello = new Player()
            {
                Id = Guid.Parse("6F12A378-E4EB-4529-2A5C-08DB9A8B4C5F"),
                FirstName = "Marco",
                LastName = "Sportiello",
                Nationality = "Italy",
                Age = 31,
                BirthDate = DateTime.ParseExact("1992-05-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2023-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2027-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€1.50m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/199976-1661351013.jpg?lm=1",
                Number = 57,
                FootballClubId = 13
            };

            players.Add(sportiello);

            var mirante = new Player()
            {
                Id = Guid.Parse("CC48B43F-6548-4206-2A5D-08DB9A8B4C5F"),
                FirstName = "Antonio",
                LastName = "Mirante",
                Nationality = "Italy",
                Age = 40,
                BirthDate = DateTime.ParseExact("1983-07-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-10-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€100k",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/22141-1663574908.jpg?lm=1",
                Number = 83,
                FootballClubId = 13
            };

            players.Add(mirante);


            var tomori = new Player()
            {
                Id = Guid.Parse("F685EF79-54ED-46FC-2A5E-08DB9A8B4C5F"),
                FirstName = "Fikayo",
                LastName = "Tomori",
                Nationality = "England",
                Age = 25,
                BirthDate = DateTime.ParseExact("1997-12-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2027-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Centre-Back",
                MarketValue = "€40.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/303254-1684856117.jpg?lm=1",
                Number = 23,
                FootballClubId = 13
            };

            players.Add(tomori);

            var kalulu = new Player()
            {
                Id = Guid.Parse("6AE63522-B28A-4D13-2A5F-08DB9A8B4C5F"),
                FirstName = "Pierre",
                LastName = "Kalulu",
                Nationality = "France",
                Age = 23,
                BirthDate = DateTime.ParseExact("2000-06-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2020-09-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2027-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Centre-Back",
                MarketValue = "€30.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/585949-1684854558.jpg?lm=1",
                Number = 20,
                FootballClubId = 13
            };

            players.Add(kalulu);

            var carnesechi = new Player()
            {
                Id = Guid.Parse("06FB4D3A-ABB5-4D31-F3C8-08DBA009FD4D"),
                FirstName = "Marco",
                LastName = "Carnesecchi",
                Nationality = "Italy",
                Age = 23,
                BirthDate = DateTime.ParseExact("2000-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2019-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2026-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€13.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/459763-1598856203.jpg?lm=1",
                Number = 29,
                FootballClubId = 1
            };

            players.Add(carnesechi);

            var musso = new Player()
            {
                Id = Guid.Parse("AC095658-6604-45AA-0524-08DBA00B9152"),
                FirstName = "Juan",
                LastName = "Musso",
                Nationality = "Argentina",
                Age = 29,
                BirthDate = DateTime.ParseExact("1994-05-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€8.00m",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/242359-1663583047.jpg?lm=1",
                Number = 1,
                FootballClubId = 1
            };

            players.Add(musso);

            var rossi = new Player()
            {
                Id = Guid.Parse("45FEAFF7-EB35-4024-0525-08DBA00B9152"),
                FirstName = "Francesco",
                LastName = "Rossi",
                Nationality = "Italy",
                Age = 32,
                BirthDate = DateTime.ParseExact("1991-04-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2009-08-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Position = "Goalkeeper",
                MarketValue = "€100k",
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/126634-1644234341.jpg?lm=1",
                Number = 31,
                FootballClubId = 1
            };

            players.Add(rossi);

            var scalvini = new Player()
            {
                Id = Guid.Parse("A67F9FF1-8B2B-4240-0526-08DBA00B9152"),
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
                FootballClubId = 1
            };

            players.Add(scalvini);

            var djimsiti = new Player()
            {
                Id = Guid.Parse("056DC0DE-CC68-43A3-0528-08DBA00B9152"),
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
                FootballClubId = 1
            };

            players.Add(djimsiti);

            return players;
        }
    }
}
