using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOGStoreQuery.Models
{
    public class WorksOn
    {
        [JsonProperty(PropertyName = "Windows")]
        public bool Windows { get; protected set; }
        [JsonProperty(PropertyName = "Mac")]
        public bool Mac { get; protected set; }
        [JsonProperty(PropertyName = "Linux")]
        public bool Linux { get; protected set; }
    }
}
