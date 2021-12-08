using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAWPF
{
    public class NeoRoot
    {
        public Links links = new Links();
        public int element_count { get; set; }
        public NeoCollection neoCollection = new NeoCollection();
    }
}
