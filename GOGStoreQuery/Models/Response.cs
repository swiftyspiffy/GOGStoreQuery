using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class Response
    {
        [JsonProperty(PropertyName = "products")]
        public Product[] Products { get; protected set; }
        [JsonProperty(PropertyName = "page")]
        public int Page { get; protected set; }
        [JsonProperty(PropertyName = "totalPages")]
        public int TotalPages { get; protected set; }
        [JsonProperty(PropertyName = "totalResults")]
        public string TotalResults { get; protected set; }
        [JsonProperty(PropertyName = "totalGamesFound")]
        public int TotalGamesFound { get; protected set; }
        [JsonProperty(PropertyName = "totalMoviesFound")]
        public int TotalMoviesFound { get; protected set; }
    }
}
