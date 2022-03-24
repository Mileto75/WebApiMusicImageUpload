using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
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
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumRepository _albumRepository;
        private readonly IArtistepository _artistRepository;
        private readonly IImageService _imageService;

        public AlbumsController(IAlbumRepository albumRepository,
            IArtistepository artistepository,
            IImageService imageService)
        {
            _albumRepository = albumRepository;
            _artistRepository = artistepository;
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var albums = await _albumRepository.ListAllAsync();

            var albumDtos = albums.MapToDto();

            return Ok(albumDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var albumEntity = await _albumRepository.GetByIdAsync(id);

            var albumDto = albumEntity.MapToDto();

            return Ok(albumDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AlbumRequestDto albumRequestDto)
        {
            var albumEntity = new Album
            {
                Name = albumRequestDto.Name
            };

            await _albumRepository.AddAsync(albumEntity);

            var albumResponseDto = albumEntity.MapToDto();

            return Ok(albumResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(AlbumRequestDto albumRequestDto)
        {
            var albumEntity = await _albumRepository.GetByIdAsync(albumRequestDto.Id);

            if (albumEntity == null)
            {
                return BadRequest("Album doesn't exists!");
            }

            var artistEntity = await _artistRepository.GetByIdAsync(albumRequestDto.ArtistId);

            if (artistEntity == null)
            {
                return BadRequest("Artist doesn't exists!");
            }

            albumEntity.Name = albumRequestDto.Name;
            albumEntity.ReleaseDate = albumRequestDto.ReleaseDate;
            albumEntity.ArtistId = albumRequestDto.ArtistId;


            await _albumRepository.UpdateAsync(albumEntity);

            var albumResponseDto = albumEntity.MapToDto();

            return Ok(albumResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var albumEntity = await _albumRepository.GetByIdAsync(id);

            if (albumEntity == null)
            {
                return BadRequest("Album doesn't exists!");
            }

            await _albumRepository.DeleteAsync(albumEntity);

            return Ok();
        }

        [HttpPost("{id}/image")]
        public async Task<IActionResult> AddOrUpdateImage(Guid id, IFormFile image)
        {
            var albumEntity = await _albumRepository.GetByIdAsync(id);

            if (albumEntity == null)
            {
                return BadRequest("Album doesn't exists!");
            }

            albumEntity.Image = await _imageService.AddOrUpdateImageAsync<Album>(id, image);

            await _albumRepository.UpdateAsync(albumEntity);

            var albumDto = albumEntity.MapToDto();

            return Ok(albumDto);
        }
    }
}
