using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class Neo
    {
        public NeoLink neoLink = new NeoLink();
        public string id { get; set; }
        public string neoID { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public double absMag { get; set; }
        public bool isHazardous { get; set; }
        public bool isSentry { get; set; }
        public EstDiameter diameter = new EstDiameter();
        public List<Approach> approach = new List<Approach>();


    }
}
