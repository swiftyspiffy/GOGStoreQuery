using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class Availability
    {
        [JsonProperty(PropertyName = "isAvailable")]
        public bool IsAvailable { get; protected set; }
        [JsonProperty(PropertyName = "isAvailableInAccount")]
        public bool IsAvailableInAccount { get; protected set; }
    }
}
