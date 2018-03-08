using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class Product
    {
        [JsonProperty(PropertyName = "developer")]
        public string Developer { get; protected set; }
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; protected set; }
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; protected set; }
        [JsonProperty(PropertyName = "isDiscounted")]
        public bool IsDiscounted { get; protected set; }
        [JsonProperty(PropertyName = "isInDevelopment")]
        public bool IsInDevelopment { get; protected set; }
        [JsonProperty(PropertyName = "id")]
        public long Id { get; protected set; }
        [JsonProperty(PropertyName = "releaseDate")]
        public long ReleaseDate { get; protected set; }
        [JsonProperty(PropertyName = "availability")]
        public Availability Availability { get; protected set; }
        [JsonProperty(PropertyName = "salesVisibility")]
        public SalesVisibility SalesVisibility { get; protected set; }
        [JsonProperty(PropertyName = "buyable")]
        public bool Buyable { get; protected set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "image")]
        public string Image { get; protected set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; protected set; }
        [JsonProperty(PropertyName = "supportUrl")]
        public string SupportUrl { get; protected set; }
        [JsonProperty(PropertyName = "forumUrl")]
        public string ForumUrl { get; protected set; }
        [JsonProperty(PropertyName = "worksOn")]
        public WorksOn WorksOn { get; protected set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; protected set; }
        [JsonProperty(PropertyName = "originalCategory")]
        public string OriginalCategory { get; protected set; }
        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; protected set; }
        [JsonProperty(PropertyName = "type")]
        public int Type { get; protected set; }
        [JsonProperty(PropertyName = "isComingSoon")]
        public bool IsComingSoon { get; protected set; }
        [JsonProperty(PropertyName = "isPriceVisible")]
        public bool IsPriceVisible { get; protected set; }
        [JsonProperty(PropertyName = "isMovie")]
        public bool IsMovie { get; protected set; }
        [JsonProperty(PropertyName = "isGame")]
        public bool IsGame { get; protected set; }
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; protected set; }
        [JsonProperty(PropertyName = "isWishlistable")]
        public bool IsWishlistable { get; protected set; }
    }
}
