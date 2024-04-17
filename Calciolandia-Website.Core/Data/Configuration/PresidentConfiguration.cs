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
    internal class PresidentConfiguration : IEntityTypeConfiguration<President>
    {
        public void Configure(EntityTypeBuilder<President> builder)
        {
            builder.HasData(CreatePresidents());
        }


        private List<President> CreatePresidents()
        {
            var presidents = new List<President>();

            var scaroni = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Paolo",
                LastName = "Scaroni",
                Nationality = "Italy",
                Age = 76,
                BirthDate = DateTime.ParseExact("1946-11-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/61951-1663977917.jpg?lm=1",
                FootballClubId = 13
            };

            presidents.Add(scaroni);


            var laurentis = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Aurelio",
                LastName = "de Laurentis",
                Nationality = "Italy",
                Age = 74,
                BirthDate = DateTime.ParseExact("1949-05-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/12590-1663975832.jpg?lm=1",
                FootballClubId = 15
            };

            presidents.Add(laurentis);

            var ferrero = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Gianluca",
                LastName = "Ferrero",
                Nationality = "Italy",
                Age = 59,
                BirthDate = DateTime.ParseExact("1963-12-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/112227-1675245583.jpg?lm=1",
                FootballClubId = 10
            };

            presidents.Add(ferrero);


            var friedkin = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Dan",
                LastName = "Friedkin",
                Nationality = "USA",
                Age = 58,
                BirthDate = DateTime.ParseExact("1965-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/header/default.jpg?lm=1",
                FootballClubId = 16
            };

            presidents.Add(friedkin);


            var zhang = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Steven",
                LastName = "Zhang",
                Nationality = "China",
                Age = 31,
                BirthDate = DateTime.ParseExact("1991-12-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/50590-1663979396.jpg?lm=1",
                FootballClubId = 9
            };


            presidents.Add(zhang);

            var percassi = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Antonio",
                LastName = "Percassi",
                Nationality = "Italy",
                Age = 70,
                BirthDate = DateTime.ParseExact("1953-06-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/13226-1554472586.jpg?lm=1",
                FootballClubId = 1
            };

            presidents.Add(percassi);


            var commiso = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Rocco",
                LastName = "Commisso",
                Nationality = "USA",
                Age = 73,
                BirthDate = DateTime.ParseExact("1949-11-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/70038-1586856311.jpg?lm=1",
                FootballClubId = 5
            };


            presidents.Add(commiso);


            var lotito = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Claudio",
                LastName = "Lotito",
                Nationality = "Italy",
                Age = 66,
                BirthDate = DateTime.ParseExact("1957-05-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/8685-1584712373.jpg?lm=1",
                FootballClubId = 11
            };

            presidents.Add(lotito);


            var cairo = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Urbano",
                LastName = "Cairo",
                Nationality = "Italy",
                Age = 66,
                BirthDate = DateTime.ParseExact("1957-04-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/13945-1663947949.jpg?lm=1",
                FootballClubId = 19
            };

            presidents.Add(cairo);

            var rossi = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Carlo",
                LastName = "Rossi",
                Nationality = "Italy",
                Age = 72,
                BirthDate = DateTime.ParseExact("1951-08-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/16896-1663947412.jpg?lm=1",
                FootballClubId = 18
            };

            presidents.Add(rossi);

            var pozzo = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Giampaolo",
                LastName = "Pozzo",
                Nationality = "Italy",
                Age = 82,
                BirthDate = DateTime.ParseExact("1941-05-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/_1366357924.jpg?lm=1",
                FootballClubId = 20
            };

            presidents.Add(pozzo);

            var saputo = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Joey",
                LastName = "Saputo",
                Nationality = "Canada",
                Age = 58,
                BirthDate = DateTime.ParseExact("1964-09-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/43324-1663930539.jpg?lm=1",
                FootballClubId = 2
            };

            presidents.Add(saputo);


            var berlusconi = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Paolo",
                LastName = "Berlusconi",
                Nationality = "Italy",
                Age = 73,
                BirthDate = DateTime.ParseExact("1949-12-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/13647-1553874773.jpg?lm=1",
                FootballClubId = 14
            };

            presidents.Add(berlusconi);


            var iervolino = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Danilo",
                LastName = "Iervolino",
                Nationality = "Italy",
                Age = 45,
                BirthDate = DateTime.ParseExact("1978-04-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/104555-1663926110.jpg?lm=1",
                FootballClubId = 17
            };

            presidents.Add(iervolino);


            var zangrillo = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Alberto",
                LastName = "Zangrillo",
                Nationality = "Italy",
                Age = 65,
                BirthDate = DateTime.ParseExact("1958-04-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/98501-1637592266.jpg?lm=1",
                FootballClubId = 7
            };

            presidents.Add(zangrillo);


            var damiani = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Saverio",
                LastName = "Sticchi Damiani",
                Nationality = "Italy",
                Age = 48,
                BirthDate = DateTime.ParseExact("1975-05-11", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/78495-1586856165.jpg?lm=1",
                FootballClubId = 12
            };

            presidents.Add(damiani);


            var corsi = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Fabrizio",
                LastName = "Corsi",
                Nationality = "Italy",
                Age = 62,
                BirthDate = DateTime.ParseExact("1960-08-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/16891-1663929957.jpg?lm=1",
                FootballClubId = 4
            };

            presidents.Add(corsi);

            var setti = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Maurizio",
                LastName = "Setti",
                Nationality = "Italy",
                Age = 60,
                BirthDate = DateTime.ParseExact("1963-06-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/31168-1663949590.jpg?lm=1",
                FootballClubId = 8
            };

            presidents.Add(setti);


            var guillini = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Tommaso",
                LastName = "Giulini",
                Nationality = "Italy",
                Age = 46,
                BirthDate = DateTime.ParseExact("1977-06-18", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/35327-1419868018.jpg?lm=1",
                FootballClubId = 3
            };

            presidents.Add(guillini);

            var stirpe = new President()
            {
                Id = Guid.NewGuid(),
                FirstName = "Maurizio",
                LastName = "Stirpe",
                Nationality = "Italy",
                Age = 65,
                BirthDate = DateTime.ParseExact("1958-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ImageUrl = "https://img.a.transfermarkt.technology/portrait/big/16894-1454497522.jpg?lm=1",
                FootballClubId = 6
            };

            presidents.Add(stirpe);


            return presidents;
        }
    }
}
