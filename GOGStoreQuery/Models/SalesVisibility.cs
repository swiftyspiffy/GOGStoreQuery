using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class SalesVisibility
    {
        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; protected set; }
        [JsonProperty(PropertyName = "fromObject")]
        public DateData FromObject { get; protected set; }
        [JsonProperty(PropertyName = "from")]
        public long From { get; protected set; }
        [JsonProperty(PropertyName = "toObject")]
        public DateData ToObject { get; protected set; }
        [JsonProperty(PropertyName = "to")]
        public long To { get; protected set; }
    }
}
