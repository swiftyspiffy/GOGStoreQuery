using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class Price
    {
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; protected set; }
        [JsonProperty(PropertyName = "baseAmount")]
        public string BaseAmount { get; protected set; }
        [JsonProperty(PropertyName = "finalAmount")]
        public string FinalAmount { get; protected set; }
        [JsonProperty(PropertyName = "isDiscounted")]
        public bool IsDiscounted { get; protected set; }
        [JsonProperty(PropertyName = "discountPercentage")]
        public double DiscountPercentage { get; protected set; }
        [JsonProperty(PropertyName = "discountDifference")]
        public string DiscountDifference { get; protected set; }
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; protected set; }
        [JsonProperty(PropertyName = "isFree")]
        public bool IsFree { get; protected set; }
        [JsonProperty(PropertyName = "discount")]
        public double Discount { get; protected set; }
        [JsonProperty(PropertyName = "isBonusStoreCreditIncluded")]
        public bool IsBonusStoreCreditIncluded { get; protected set; }
        [JsonProperty(PropertyName = "bonusStoreCreditAmount")]
        public string BonusStoreCreditAmount { get; protected set; }
    }
}
