using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class Approach
    {
        public string approachDate { get; set; }
        public string dateFull { get; set; }
        public int epochDate { get; set; }
        public string orbitBody { get; set; }
        public Velocity velocity = new Velocity();
        public MissDistance distance = new MissDistance();
    }
}
