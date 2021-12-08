using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class EstDiameter
    {
        public Kilometers kilometers = new Kilometers();
        public Meters meters = new Meters();
        public Miles miles= new Miles();
        public Feet feet = new Feet();
    }
    public class Kilometers
    {
        public decimal estMin { get; set; }
        public decimal estMax { get; set; }
    }

    public class Meters
    {
        public decimal estMin { get; set; }
        public decimal estMax { get; set; }
    }
    public class Miles
    {
        public decimal estMin { get; set; }
        public decimal estMax { get; set; }
    }
    public class Feet
    {
        public decimal estMin { get; set; }
        public decimal estMax { get; set; }
    }
}
