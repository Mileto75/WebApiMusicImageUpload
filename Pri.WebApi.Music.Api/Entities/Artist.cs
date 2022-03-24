using Pri.Oe.WebApi.Music.Api.Entities.Base;
using System;
using System.Collections.Generic;

namespace Pri.Oe.WebApi.Music.Api.Entities
{
    public class Artist : BaseEntity
    {

        public string Name { get; set; }
        public int Followers { get; set; }
        public int Popularity { get; set; }
        public ICollection<Album> Albums { get; set; }
        public string Image { get; set; }
    }
}
