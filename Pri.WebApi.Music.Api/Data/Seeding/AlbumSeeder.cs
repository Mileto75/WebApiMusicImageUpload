using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Api.Entities;
using System;

namespace Pri.Oe.WebApi.Music.Api.Data.Seeding
{
    public class AlbumSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                // Metallica
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "...And Justice for All",
                    ReleaseDate = DateTime.Parse("7/09/1988 0:00:00"),
                    Image = "images/album/andjusticeforall.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Metallica",
                    ReleaseDate = DateTime.Parse("12/08/1991 0:00:00"),
                    Image = "images/album/metallica.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Master of Puppets",
                    ReleaseDate = DateTime.Parse("3/03/1986 0:00:00"),
                    Image = "images/album/masterofpuppets.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Hardwired...To Self-Destruct",
                    ReleaseDate = DateTime.Parse("18/11/2016 0:00:00"),
                    Image = "images/album/hardwired.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },

                // Guns 'n Roses
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Appetite For Destruction",
                    ReleaseDate = DateTime.Parse("21/07/1987 0:00:00"),
                    Image = "images/album/appetitefordestruction.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Use Your Illusion I",
                    ReleaseDate = DateTime.Parse("17/09/1991 0:00:00"),
                    Image = "images/album/useyourillusion1.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Use Your Illusion II",
                    ReleaseDate = DateTime.Parse("17/09/1991 0:00:00"),
                    Image = "images/album/useyourillusion2.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },

                // Nirvana
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "MTV Unplugged In New York",
                    ReleaseDate = DateTime.Parse("1/11/1994 0:00:00"),
                    Image = "images/album/mtvunpluggedinnewyork.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Live at Reading",
                    ReleaseDate = DateTime.Parse("1/01/2009 0:00:00"),
                    Image = "images/album/liveatreading.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Nevermind",
                    ReleaseDate = DateTime.Parse("26/09/1991 0:00:00"),
                    Image = "images/album/nevermind.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },

                // Pearl Jam
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Ten",
                    ReleaseDate = DateTime.Parse("27/08/1991 0:00:00"),
                    Image = "images/album/ten.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Spin The Black Circle Live In Seattle '95",
                    ReleaseDate = DateTime.Parse("1/01/1995 0:00:00"),
                    Image = "images/album/spintheblackcirclelive.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },

                // Channel Zero
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Live @ The Ancienne Belgique",
                    ReleaseDate = DateTime.Parse("30/04/2010 0:00:00"),
                    Image = "images/album/livetheanciennebelgique.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Black Fuel",
                    ReleaseDate = DateTime.Parse("27/01/1997 0:00:00"),
                    Image = "images/album/blackfuel.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },

                // Rage against The Machine
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    Name = "Rage Against The Machine",
                    ReleaseDate = DateTime.Parse("03/11/1992 0:00:00"),
                    Image = "images/album/rageagainstthemachine.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new Album
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Name = "Evil Empire",
                    ReleaseDate = DateTime.Parse("16/04/1996 0:00:00"),
                    Image = "images/album/evilempire.jpg",
                    ArtistId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                }
                );
        }
    }
}
