using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Data.Seeding
{
    public class ArtistSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Name = "Metallica", Followers = 15044763, Popularity = 85, Image = "images/artist/metallica.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), },
                new Artist { Name = "Guns N' Roses", Followers = 17664350, Popularity = 82,  Image = "images/artist/gunsnroses.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), },
                new Artist { Name = "Nirvana", Followers = 11175759, Popularity = 82, Image = "images/artist/nirvana.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), },
                new Artist { Name = "Pearl Jam", Followers = 5980792, Popularity = 79,  Image = "images/artist/pearljam.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), },
                new Artist { Name = "Channel Zero", Followers = 9637, Popularity = 30, Image = "images/artist/channelzero.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), },
                new Artist { Name = "Therapy?", Followers = 78309, Popularity = 44, Image = "images/artist/therapy.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), },
                new Artist { Name = "Rage Against The Machine", Followers = 4468769, Popularity = 73, Image = "images/artist/rageagainstthemachine.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new Artist { Name = "King Hiss", Followers = 2141, Popularity = 15, Image = "images/artist/kinghiss.jpg", Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), }
            );
        }
    }
}
