using Pri.Oe.WebApi.Music.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Repositories.Interfaces
{
    public interface IAlbumRepository : IBaseRepository<Album>
    {
        Task<IEnumerable<Album>> GetAlbumsFromArtistId(Guid id);
    }
}
