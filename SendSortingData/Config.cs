using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SendSortingData
{
    public class Config
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

    }
}
