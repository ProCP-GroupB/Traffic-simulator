using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Traffic_Light_Simulation
{
    class Crossing_withoutPedestarian : Crossing
    {
        public Crossing_withoutPedestarian(Rectangle r, Image im,string type)
            : base(r, im,type)
        {

        }
    }
}
