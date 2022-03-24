using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using Pri.Oe.WebApi.Music.Api.Dtos.Artists;
using Pri.Oe.WebApi.Music.Api.Entities;
using Pri.Oe.WebApi.Music.Api.Helpers.Mappers;
using Pri.Oe.WebApi.Music.Api.Repositories.Interfaces;
using Pri.Oe.WebApi.Music.Api.Services.Images;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistepository _artistRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IImageService _imageService;

        public ArtistsController(IArtistepository artistRepository,
            IAlbumRepository albumRepository,
            IImageService imageService)
        {
            _artistRepository = artistRepository;
            _albumRepository = albumRepository;
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var artists = await _artistRepository.ListAllAsync();

            var artistDtos = artists.MapToDto();

            return Ok(artistDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var artistEntity = await _artistRepository.GetByIdAsync(id);

            var artistDto = artistEntity.MapToDto();

            return Ok(artistDto);
        }

        [HttpGet("{id}/albums")]
        public async Task<IActionResult> GetAlbumsFromArtist(Guid id)
        {
            var albumEntities = await _albumRepository.GetAlbumsFromArtistId(id);

            var albumDto = albumEntities.MapToDto();

            return Ok(albumDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArtistRequestDto artistRequestDto)
        {
            var artistEntity = new Artist
            {
                Name = artistRequestDto.Name
            };

            await _artistRepository.AddAsync(artistEntity);

            var artistResponseDto = artistEntity.MapToDto();

            return Ok(artistResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ArtistUpdateRequestDto artistUpdateRequestDto)
        {
            var artistEntity = await _artistRepository.GetByIdAsync(artistUpdateRequestDto.Id);

            if (artistEntity == null)
            {
                return BadRequest("Artist doesn't exists!");
            }

            artistEntity.Name = artistUpdateRequestDto.Name;
            artistEntity.Popularity = artistUpdateRequestDto.Popularity;


            await _artistRepository.UpdateAsync(artistEntity);

            var artistResponseDto = artistEntity.MapToDto();

            return Ok(artistResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artistEntity = await _artistRepository.GetByIdAsync(id);

            if (artistEntity == null)
            {
                return BadRequest("Artist doesn't exists!");
            }

            await _artistRepository.DeleteAsync(artistEntity);

            return Ok();
        }

        [HttpPost("{id}/image")]
        public async Task<IActionResult> AddOrUpdateImage(Guid id, IFormFile image)
        {
            var artistEntity = await _artistRepository.GetByIdAsync(id);

            if (artistEntity == null)
            {
                return BadRequest("Artist doesn't exists!");
            }

            artistEntity.Image = await _imageService.AddOrUpdateImageAsync<Artist>(id, image);

            await _artistRepository.UpdateAsync(artistEntity);

            var artistDto = artistEntity.MapToDto();

            return Ok(artistDto);
        }
    }
}
