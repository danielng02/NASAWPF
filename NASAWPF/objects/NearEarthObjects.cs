using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NASAWPF
{
    public class NearEarthObjects
    {
        [JsonProperty("dateSpotted")]
        public Neo[] neos01 { get; set; }

        [JsonProperty("dateSpotted")]
        public Neo[] neos02 { get; set; }
    }
}
