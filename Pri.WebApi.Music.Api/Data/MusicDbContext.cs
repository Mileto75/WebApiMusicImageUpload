using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Api.Data.Seeding;
using Pri.Oe.WebApi.Music.Api.Entities;

namespace Pri.Oe.WebApi.Music.Api.Data
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public MusicDbContext(DbContextOptions<MusicDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ArtistSeeder.Seed(modelBuilder);
            AlbumSeeder.Seed(modelBuilder);
        }
    }
}
