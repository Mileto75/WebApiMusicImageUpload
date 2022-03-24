using Microsoft.AspNetCore.Http;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using Pri.Oe.WebApi.Music.Api.Dtos.Artists;
using Pri.Oe.WebApi.Music.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pri.Oe.WebApi.Music.Api.Helpers.Mappers
{
    public static class DtoMapper
    {
        public static IEnumerable<ArtistResponseDto> MapToDto(this IEnumerable<Artist> artistEntities)
        {
            return artistEntities.Select(ae => ae.MapToDto());
        }

        public static ArtistResponseDto MapToDto(this Artist artistEntity)
        {
            return new ArtistResponseDto
            {
                Id = artistEntity.Id,
                Name = artistEntity.Name,
                Popularity = artistEntity.Popularity,
                Followers = artistEntity.Followers,
                Image = GetFullImageUrl(artistEntity.Image)
            };
        }

        public static IEnumerable<AlbumResponseDto> MapToDto(this IEnumerable<Album> albumEntities)
        {
            return albumEntities.Select(ae => ae.MapToDto());
        }

        public static AlbumResponseDto MapToDto(this Album albumEntity)
        {
            return new AlbumResponseDto
            {
                Id = albumEntity.Id,
                Name = albumEntity.Name,
                Image = GetFullImageUrl(albumEntity.Image),
                ArtistId = albumEntity.ArtistId,
                ArtistName = albumEntity.Artist.Name,
                ReleaseYear = albumEntity.ReleaseDate.Year.ToString()
            };
        }

        private static string GetFullImageUrl(string image)
        {
            if (string.IsNullOrEmpty(image))
            {
                return null;
            }

            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();

            var scheme = httpContextAccessor.HttpContext.Request.Scheme; // example: https or http
            var url = httpContextAccessor.HttpContext.Request.Host.Value; // example: localhost:5001, howest.be, steam.com, localhost:44785, ...

            var fullImageUrl = $"{scheme}://{url}/{image.Replace("\\","/")}";

            return fullImageUrl;
        }
    }
}
