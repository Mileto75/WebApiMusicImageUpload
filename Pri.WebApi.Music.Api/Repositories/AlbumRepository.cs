﻿using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Api.Data;
using Pri.Oe.WebApi.Music.Api.Entities;
using Pri.Oe.WebApi.Music.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Repositories
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Album>> GetAlbumsFromArtistId(Guid id)
        {
            return await GetAll().Where(a => a.ArtistId.Equals(id)).ToListAsync();
        }

        public override IQueryable<Album> GetAll()
        {
            return _dbContext.Albums.Include(a => a.Artist).AsQueryable();
        }
    }
}
