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
    internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(CreateManagers());
        }

        private List<Manager> CreateManagers()
        {
            var managers = new List<Manager>();

            var pioli = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Stefano",
                LastName = "Pioli",
                Nationality = "Italy",
                Age = 57,
                BirthDate = DateTime.ParseExact("1965-10-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2019-10-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 13,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/2135-1663977168.jpg?lm=1"
            };

            managers.Add(pioli);


            var calzona = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Francesco",
                LastName = "Calzona",
                Nationality = "Italy",
                Age = 55,
                BirthDate = DateTime.ParseExact("1968-10-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-02-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 15,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/33804-1697643746.jpg?lm=1"
            };

            managers.Add(calzona);


            var allegri = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Massimiliano",
                LastName = "Allegri",
                Nationality = "Italy",
                Age = 55,
                BirthDate = DateTime.ParseExact("1967-08-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-05-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 10,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/7671-1663973141.jpg?lm=1"
            };

            managers.Add(allegri);


            var inzaghi = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Simone",
                LastName = "Inzaghi",
                Nationality = "Italy",
                Age = 47,
                BirthDate = DateTime.ParseExact("1976-04-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-06-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 9,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/21624-1663979865.jpg?lm=1"
            };

            managers.Add(inzaghi);

            var gasperini = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Gian Piero",
                LastName = "Gasperini",
                Nationality = "Italy",
                Age = 65,
                BirthDate = DateTime.ParseExact("1958-01-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2016-06-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 1,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/3436-1663862210.jpg?lm=1"
            };

            managers.Add(gasperini);


            var derossi = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Daniele",
                LastName = "De Rossi",
                Nationality = "Italy",
                Age = 40,
                BirthDate = DateTime.ParseExact("1983-07-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-01-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 16,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/90748-1616069982.jpg?lm=1"
            };

            managers.Add(derossi);


            var italiano = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Vincenzo",
                LastName = "Italiano",
                Nationality = "Italy",
                Age = 45,
                BirthDate = DateTime.ParseExact("1977-12-10", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 5,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/47288-1663950225.jpg?lm=1"
            };

            managers.Add(italiano);


            var tudor = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Igor",
                LastName = "Tudor",
                Nationality = "Croatia",
                Age = 45,
                BirthDate = DateTime.ParseExact("1978-04-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-03-18", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 11,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/28632-1646406004.jpg?lm=1"
            };

            managers.Add(tudor);


            var ballardini = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Davide",
                LastName = "Ballardini",
                Nationality = "Italy",
                Age = 60,
                BirthDate = DateTime.ParseExact("1964-01-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-03-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 18,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/3793-1631177487.jpg?lm=1"
            };

            managers.Add(ballardini);


            var coffi = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Gabriele",
                LastName = "Cioffi",
                Nationality = "Italy",
                Age = 48,
                BirthDate = DateTime.ParseExact("1975-09-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2023-10-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 20,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/31903-1639297579.jpg?lm=1"
            };

            managers.Add(coffi);


            var motta = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Thiago",
                LastName = "Motta",
                Nationality = "Italy/Brazil",
                Age = 40,
                BirthDate = DateTime.ParseExact("1982-08-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2022-09-12", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 2,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/61868-1663936050.jpg?lm=1"
            };

            managers.Add(motta);


            var palladino = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Raffaele",
                LastName = "Palladino",
                Nationality = "Italy",
                Age = 39,
                BirthDate = DateTime.ParseExact("1984-04-17", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2022-09-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 14,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/95674-1663872108.jpg?lm=1"
            };

            managers.Add(palladino);


            var cuantuono = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Stefano",
                LastName = "Colantuono",
                Nationality = "Italy",
                Age = 61,
                BirthDate = DateTime.ParseExact("1962-10-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-03-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 17,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/2127-1634565915.jpg?lm=1"
            };

            managers.Add(cuantuono);


            var gilardino = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Alberto",
                LastName = "Gilardino",
                Nationality = "Italy",
                Age = 41,
                BirthDate = DateTime.ParseExact("1982-06-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2022-12-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 7,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/64045-1673622044.jpg?lm=1"
            };

            managers.Add(gilardino);


            var gotti = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Luca",
                LastName = "Gotti",
                Nationality = "Italy",
                Age = 56,
                BirthDate = DateTime.ParseExact("1967-09-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-03-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 12,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/7521-1663926746.jpg?lm=1"
            };

            managers.Add(gotti);

            var nicola = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Davide",
                LastName = "Nicola",
                Nationality = "Italy",
                Age = 51,
                BirthDate = DateTime.ParseExact("1973-03-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2024-01-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 4,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/14892-1644914474.png?lm=1"
            };

            managers.Add(nicola);


            var baroni = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Marco",
                LastName = "Baroni",
                Nationality = "Italy",
                Age = 59,
                BirthDate = DateTime.ParseExact("1963-09-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2023-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 8,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/12015-1649752265.jpg?lm=1"
            };

            managers.Add(baroni);


            var ranieri = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Claudio",
                LastName = "Ranieri",
                Nationality = "Italy",
                Age = 71,
                BirthDate = DateTime.ParseExact("1951-10-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2023-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2025-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 3,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/456-1521199129.jpg?lm=1"
            };

            managers.Add(ranieri);


            var difrancesco = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Eusebio",
                LastName = "Di Francesco",
                Nationality = "Italy",
                Age = 53,
                BirthDate = DateTime.ParseExact("1969-09-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2023-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 6,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/12924-1631177386.jpg?lm=1"
            };


            managers.Add(difrancesco);

            var juric = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ivan",
                LastName = "Juric",
                Nationality = "Croatia",
                Age = 47,
                BirthDate = DateTime.ParseExact("1975-08-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractSignedDate = DateTime.ParseExact("2021-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ContractExpiredDate = DateTime.ParseExact("2024-06-30", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                FootballClubId = 19,
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/16508-1594718677.jpg?lm=1"
            };

            managers.Add(juric);

            return managers;
        }
    }
}
