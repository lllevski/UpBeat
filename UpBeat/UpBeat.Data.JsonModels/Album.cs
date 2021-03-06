﻿using System.Collections.Generic;
using Newtonsoft.Json;
using UpBeat.Common.Mappings;

namespace UpBeat.Data.JsonModels
{
    public class Album : IMapFrom<Data.Models.Album>
    {
        //[JsonProperty("id")]
        //public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> Artists { get; set; }

        [JsonProperty("images")]
        public IList<Image> Images { get; set; }

        [JsonProperty("tracks")]
        public IList<Track> Tracks { get; set; }
    }
}
