using Calciolandia_Website.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class FootballClubConfiguration : IEntityTypeConfiguration<FootballClub>
    {
        public void Configure(EntityTypeBuilder<FootballClub> builder)
        {
            builder.HasData(CreateFootballClubs());
        }

        private List<FootballClub> CreateFootballClubs()
        {
            var footballClubs = new List<FootballClub>();

            var atalanta = new FootballClub()
            {
                Id = 1,
                Name = "Atalanta BC",
                Nickname = "La Dea",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cfd69d/atalanta.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Bergamo",
                Address = "Zingonia - Corso Europa 20040 Bergamo Italy",
                LeagueId = 1,
                StadiumId = 3,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(atalanta);

            var bologna = new FootballClub()
            {
                Id = 2,
                Name = "Bologna FC 1909",
                Nickname = "Rossoblù",
                Trophies = 7,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef3f6/bologna.png?webp&q=70&size=300x-",
                FoundedYear = 1909,
                City = "Bologna",
                Address = "Via Casteldebole 10 40132 Bologna Italy",
                LeagueId = 1,
                StadiumId = 4,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(bologna);


            var cagliari = new FootballClub()
            {
                Id = 3,
                Name = "Cagliari Calcio",
                Nickname = "Rossoblù",
                Trophies = 1,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cfd202/cagliari.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Cagliari",
                Address = "Via Mameli 106 09123 Cagliari Italy",
                LeagueId = 1,
                StadiumId = 5,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(cagliari);


            var empoli = new FootballClub()
            {
                Id = 4,
                Name = "FC Empoli",
                Nickname = "Azzurri",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef42e/empoli.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Empoli",
                Address = "Via di Pianezzoli 50053 Empoli Italy",
                LeagueId = 1,
                StadiumId = 6,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(empoli);


            var fiorentina = new FootballClub()
            {
                Id = 5,
                Name = "ACF Fiorentina",
                Nickname = "Viola",
                Trophies = 2,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef452/fiorentina.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Florence",
                Address = " Viale Manfredo Fanti, 4 50137 Firenze Italy",
                LeagueId = 1,
                StadiumId = 7,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(fiorentina);


            var frosinone = new FootballClub()
            {
                Id = 6,
                Name = "Frosinone Calcio",
                Nickname = "Giallazzurri",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cfdfec/frosinone.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Frosinone",
                Address = "Viale Olimpia 03100 Frosinone Italy",
                LeagueId = 1,
                StadiumId = 8,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(frosinone);


            var genoa = new FootballClub()
            {
                Id = 7,
                Name = "Genoa CFC",
                Nickname = "Grifone",
                Trophies = 9,
                LogoImageUrl = "https://img.legaseriea.it/vimages/649e8a06/GENOA-1.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Genoa",
                Address = "Via Ronchi 67 16155 Genova Italy",
                LeagueId = 1,
                StadiumId = 9,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(genoa);


            var verona = new FootballClub()
            {
                Id = 8,
                Name = "Hellas Verona FC",
                Nickname = "Gialloblu",
                Trophies = 1,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef475/colore=YELLOW.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Verona",
                Address = "Via Torricelli 37 37136 Verona Italy",
                LeagueId = 1,
                StadiumId = 10,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(verona);


            var inter = new FootballClub()
            {
                Id = 9,
                Name = "Inter Milan",
                Nickname = "Nerazzurri",
                Trophies = 19,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef496/inter.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Milan",
                Address = "Viale della Liberazione Milano Italy",
                LeagueId = 1,
                StadiumId = 1,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(inter);



            var juventus = new FootballClub()
            {
                Id = 10,
                Name = "Juventus FC",
                Nickname = "Bianconeri",
                Trophies = 36,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef4b7/colore=WHITE.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Turin",
                Address = "Via Druento, 175 10151 Torino Italy",
                LeagueId = 1,
                StadiumId = 11,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(juventus);


            var lazio = new FootballClub()
            {
                Id = 11,
                Name = "SS Lazio",
                Nickname = "Biancocelesti",
                Trophies = 2,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef4d5/lazio.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Rome",
                Address = "Via di Santa Cornelia 1000 00060 Roma Italy",
                LeagueId = 1,
                StadiumId = 2,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(lazio);


            var lecce = new FootballClub()
            {
                Id = 12,
                Name = "US Lecce",
                Nickname = "Giallorossi",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef4f6/lecce.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Lecce",
                Address = "Colonello Archimede Costadura 3 73100 Lecce Italy",
                LeagueId = 1,
                StadiumId = 12,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(lecce);


            var milan = new FootballClub()
            {
                Id = 13,
                Name = "AC Milan",
                Nickname = "Rossoneri",
                Trophies = 19,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef513/milan.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Milan",
                Address = "Via Aldo Rossi 8 20149 Milano Italy",
                LeagueId = 1,
                StadiumId = 1,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(milan);


            var monza = new FootballClub()
            {
                Id = 14,
                Name = "AC Monza",
                Nickname = "Biancorossi",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62c6acbd/monza.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Monza",
                Address = "Via Ragazzi del '99, 14 20900 Monza Italy",
                LeagueId = 1,
                StadiumId = 13,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(monza);



            var napoli = new FootballClub()
            {
                Id = 15,
                Name = "SSC Napoli",
                Nickname = "Partenopei",
                Trophies = 3,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef532/napoli.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Naples",
                Address = "Via del Maio di Porto 9 80133 Napoli Italy",
                LeagueId = 1,
                StadiumId = 14,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(napoli);


            var roma = new FootballClub()
            {
                Id = 16,
                Name = "AS Roma",
                Nickname = "Giallorossi",
                Trophies = 3,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cfd5ce/roma.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Rome",
                Address = "Piazzale Dino Viola 1 00128 Roma Italy",
                LeagueId = 1,
                StadiumId = 2,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(roma);


            var salernitana = new FootballClub()
            {
                Id = 17,
                Name = "US Salernitana 1919",
                Nickname = "Granata",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef553/salernitana.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Salerno",
                Address = "Via Salvador Allende 84131 Salerno Italy",
                LeagueId = 1,
                StadiumId = 15,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(salernitana);


            var sassuolo = new FootballClub()
            {
                Id = 18,
                Name = "US Sassuolo Calcio",
                Nickname = "Neroverdi",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef590/sassuolo.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Sassuolo",
                Address = "Piazza Risorgimento 47 41049 Sassuolo Italy",
                LeagueId = 1,
                StadiumId = 16,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(sassuolo);



            var torino = new FootballClub()
            {
                Id = 19,
                Name = "Torino FC",
                Nickname = "Toro",
                Trophies = 7,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef5cb/torino.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Turin",
                Address = "Via Arcivescovado 1 10121 Torino Italy",
                LeagueId = 1,
                StadiumId = 17,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(torino);


            var udinese = new FootballClub()
            {
                Id = 20,
                Name = "Udinese Calcio",
                Nickname = "Friulani",
                Trophies = 0,
                LogoImageUrl = "https://img.legaseriea.it/vimages/62cef5e9/udinese.png?webp&q=70&size=300x-",
                FoundedYear = 1907,
                City = "Udine",
                Address = "Via A. e A. Candolini 2 33100 Udine Italy",
                LeagueId = 1,
                StadiumId = 18,
                ManagerId = Guid.Parse(""),
                PresidentId = Guid.Parse("")

            };

            footballClubs.Add(udinese);


            return footballClubs;
        }
    }
}
