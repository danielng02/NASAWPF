using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class Asteroid
    {
        [JsonProperty("near_earth_objects")]
        public DateTime Date { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
       
        [JsonProperty("neo_reference_id")]
        public string NeoID { get; set; }
        
        [JsonProperty("nasa_jpl_url")]
        public string JplURL { get; set; }
        
        [JsonProperty("absolute_magnitude_h")]
        public double AbsMagnitude { get; set; }
       
        [JsonProperty("estimated_diameter")]
        public double EstDiameter { get; set; }
        
        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsHazardous { get; set; }
       
        [JsonProperty("is_sentry_object")]
        public bool IsSentry { get; set; }


        public override string ToString()
        {
            return $"{Name}:{Id}:{NeoID}:{JplURL}:{AbsMagnitude}:{EstDiameter}:{IsHazardous}:{IsSentry}";
        }
    }
}
