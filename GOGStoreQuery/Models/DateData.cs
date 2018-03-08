using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class DateData
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; protected set; }
        [JsonProperty(PropertyName = "timezone_type")]
        public int TimezoneType { get; protected set; }
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; protected set; }
    }
}
