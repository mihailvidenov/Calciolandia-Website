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
    internal class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            builder.HasData(CreateStadiums());
        }


        private List<Stadium> CreateStadiums()
        {
            var stadiums = new List<Stadium>();

            var meazza = new Stadium()
            {
                Id = 1,
                Name = "Giuseppe Meazza",
                Capacity = 80018,
                ImageUrl = "https://img.legaseriea.it/vimages/632b5612/775454473ML003_FC_Internazi.JPG?webp&q=70&size=999x-",
                Address = "Piazzale Angelo Moratti, 20151 Milan MI",
                City = "Milan"
            };

            stadiums.Add(meazza);

            var olimpico = new Stadium()
            {
                Id = 2,
                Name = "Olimpico",
                Capacity = 73261,
                ImageUrl = "https://img.legaseriea.it/vimages/635a8731/stadio-olimpico-roma.png?webp&q=70&size=999x-",
                Address = "Viale dei Gladiatori, 00135 Roma RM",
                City = "Rome"
            };

            stadiums.Add(olimpico);

            var gewiss = new Stadium()
            {
                Id = 3,
                Name = "Gewiss Stadium",
                Capacity = 19768,
                ImageUrl = "https://img.legaseriea.it/vimages/62cef799/7%20(1).jpg?webp&q=70&size=999x-",
                Address = "Viale Giulio Cesare, 18, 24124 Bergamo BG",
                City = "Bergamo"
            };

            stadiums.Add(gewiss);

            var dallara = new Stadium()
            {
                Id = 4,
                Name = "Renato Dall' Ara",
                Capacity = 38279,
                ImageUrl = "https://img.legaseriea.it/vimages/62d9651c/dallara_bologna.png?webp&q=70&size=999x-",
                Address = "Via Andrea Costa, 174, 40134 Bologna BO",
                City = "Bologna"
            };

            stadiums.Add(dallara);


            var unipol = new Stadium()
            {
                Id = 5,
                Name = "Unipol Domus",
                Capacity = 16416,
                ImageUrl = "https://img.legaseriea.it/vimages/649d9299/unipol%20domus%203.jpg?webp&q=70&size=999x-",
                Address = "Via Raimondo Carta Raspi, 09126 Cagliari CA",
                City = "Cagliari"
            };

            stadiums.Add(unipol);



            var castellani = new Stadium()
            {
                Id = 6,
                Name = "Castellani Computer Gross Arena",
                Capacity = 19847,
                ImageUrl = "https://img.legaseriea.it/vimages/6346b2cf/EMPOLISITO.png?webp&q=70&size=999x-",
                Address = "Via delle Olimpiadi, 50053 Empoli FI",
                City = "Empoli"
            };

            stadiums.Add(castellani);


            var franchi = new Stadium()
            {
                Id = 7,
                Name = "Artemio Franchi",
                Capacity = 47282,
                ImageUrl = "https://img.legaseriea.it/vimages/632865d1/208879_0001_3764373.png?webp&q=70&size=999x-",
                Address = "Viale Manfredo Fanti, 4, 50137 Firenze FI",
                City = "Florence"
            };

            stadiums.Add(franchi);


            var stirpe = new Stadium()
            {
                Id = 8,
                Name = "Benito Stirpe",
                Capacity = 16227,
                ImageUrl = "https://img.legaseriea.it/vimages/649d7c5a/stadio-benito-stirpe.png?webp&q=70&size=999x-",
                Address = "Viale Olimpia, 03100 Frosinone FR",
                City = "Frozinone"
            };

            stadiums.Add(stirpe);


            var ferraris = new Stadium()
            {
                Id = 9,
                Name = "Luigi Ferraris",
                Capacity = 36348,
                ImageUrl = "https://img.legaseriea.it/vimages/64a2c8bb/IMG_3486.jpg?webp&q=70&size=999x-",
                Address = "Via Giovanni de Prà, 1, 16139",
                City = "Genoa"
            };

            stadiums.Add(ferraris);


            var bentegodi = new Stadium()
            {
                Id = 10,
                Name = "Marcantonio Bentegodi",
                Capacity = 39211,
                ImageUrl = "https://img.legaseriea.it/vimages/62d9745c/stadio_03verona.jpg?webp&q=70&size=999x-",
                Address = "Piazzale Olimpia,2,37138 Verona VR",
                City = "Verona"
            };

            stadiums.Add(bentegodi);


            var alianz = new Stadium()
            {
                Id = 11,
                Name = "Allianz Stadium",
                Capacity = 41507,
                ImageUrl = "https://img.legaseriea.it/vimages/62d965db/allianz-stadium.jpg?webp&q=70&size=999x-",
                Address = "Corso Gaetano Scirea, 50, 10151 Torino TO",
                City = "Turin"
            };

            stadiums.Add(alianz);


            var viadelmare = new Stadium()
            {
                Id = 12,
                Name = "Ettore Giardiniero - Via Del Mare",
                Capacity = 31559,
                ImageUrl = "https://img.legaseriea.it/vimages/63564923/STADIO-LECCE.png?webp&q=70&size=999x-",
                Address = "Viale Stadio, 73024 Lecce LE",
                City = "Lecce"
            };

            stadiums.Add(viadelmare);


            var upower = new Stadium()
            {
                Id = 13,
                Name = "U-Power Stadium",
                Capacity = 15039,
                ImageUrl = "https://img.legaseriea.it/vimages/635647a2/STADIO-MONZA.png?webp&q=70&size=999x-",
                Address = "Via Franco Tognini, 4, 20900 Monza MB",
                City = "Monza"
            };

            stadiums.Add(upower);


            var maradona = new Stadium()
            {
                Id = 14,
                Name = "Diego Armando Maradona",
                Capacity = 54726,
                ImageUrl = "https://img.legaseriea.it/vimages/62da938f/stadio-maradona%20dettaglio-curva.jpg?webp&q=70&size=999x-",
                Address = "Piazzale Vincenzo Tecchio, 80125 Napoli NA",
                City = "Naples"
            };

            stadiums.Add(maradona);


            var arechi = new Stadium()
            {
                Id = 15,
                Name = "Arechi",
                Capacity = 30739,
                ImageUrl = "https://img.legaseriea.it/vimages/63564996/STADIO-ARECHI.png?webp&q=70&size=999x-",
                Address = "Via Salvador Allende, 84131 Salerno SA",
                City = "Salerno"
            };

            stadiums.Add(arechi);


            var mapei = new Stadium()
            {
                Id = 16,
                Name = "Mapei Stadium - Citta Del Tricolore",
                Capacity = 21584,
                ImageUrl = "https://img.legaseriea.it/vimages/635648b4/STADIO-MAPEI.png?webp&q=70&size=999x-",
                Address = "Piazzale Atleti Azzurri D`Italia, 1, 42122 Reggio Emilia RE",
                City = "Reggio Emilia"
            };

            stadiums.Add(mapei);

            var torino = new Stadium()
            {
                Id = 17,
                Name = "Olimpico Grande Torino",
                Capacity = 27994,
                ImageUrl = "https://img.legaseriea.it/vimages/6346b263/TORINOSITO.png?webp&q=70&size=999x-",
                Address = "Via Filadelfia, 96/b, 10134 Torino TO",
                City = "Turin"
            };

            stadiums.Add(torino);


            var udinese = new Stadium()
            {
                Id = 18,
                Name = "Udinese Arena",
                Capacity = 25144,
                ImageUrl = "https://img.legaseriea.it/vimages/64a7e2b8/udinese-stadio.png?webp&q=70&size=999x-",
                Address = "Viale Agostino ed Angelo Candolini, 2 , 33100 Udine UD",
                City = "Udine"
            };

            stadiums.Add(udinese);


            return stadiums;
        }
    }
}
