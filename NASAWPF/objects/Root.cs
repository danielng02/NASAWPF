using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class Root
    {
        public Links links { get; set; }
        public int element_count { get; set; }
        public NearEarthObjects near_earth_objects { get; set; }
    }
}
