using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Traffic_Light_Simulation
{
    class Crossing_WithPedestarian : Crossing
    {
         Group laneGroup;
         string type;
        
         public Crossing_WithPedestarian(Rectangle r, Image im,string type)
            : base(r, im,type)
        {

        }     

    }
}
