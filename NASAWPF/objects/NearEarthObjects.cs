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
        [JsonProperty("2021-05-08")]
        public List<Neo> neos01 = new List<Neo>();
        [JsonProperty("2021-05-09")]
        public List<Neo> neos02 = new List<Neo>();
    }
}
