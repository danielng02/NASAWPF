using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class AsteroidCollection
    {
        private List<Asteroid> asteroids;

        public List<Asteroid> Asteroids { get => asteroids; set => asteroids = value; }
    }
}
