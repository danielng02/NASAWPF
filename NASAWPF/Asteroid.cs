using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class Asteroid
    {
        private DateTime date;
        private string name;
        private string id;
        private string neoID;
        private string jplURL;
        private double absMagnitude;
        private double estDiameter;
        private bool isHazardous;
        private bool isSentry;

        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string NeoID { get => neoID; set => neoID = value; }
        public string JplURL { get => jplURL; set => jplURL = value; }
        public double AbsMagnitude { get => absMagnitude; set => absMagnitude = value; }
        public double EstDiameter { get => estDiameter; set => estDiameter = value; }
        public bool IsHazardous { get => isHazardous; set => isHazardous = value; }
        public bool IsSentry { get => isSentry; set => isSentry = value; }
    }
}
