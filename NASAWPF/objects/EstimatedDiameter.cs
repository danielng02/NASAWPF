using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class EstimatedDiameter
    {
        public Kilometers kilometers = new Kilometers();
        public Meters meters = new Meters();
        public Miles miles= new Miles();
        public Feet feet = new Feet();
    }
    public class Kilometers
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }

    public class Meters
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }
    public class Miles
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }
    public class Feet
    {
        public double estimated_diameter_min { get; set; }
        public double estimated_diameter_max { get; set; }
    }
}
