using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Api.Data;
using Pri.Oe.WebApi.Music.Api.Entities;
using Pri.Oe.WebApi.Music.Api.Repositories.Interfaces;
using System.Linq;

namespace Pri.Oe.WebApi.Music.Api.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistepository
    {
        public ArtistRepository(MusicDbContext dbContext) : base(dbContext)
        {

        }

        public override IQueryable<Artist> GetAll()
        {
            return _dbContext.Artists.Include(a => a.Albums).AsQueryable();
        }
    }
}
