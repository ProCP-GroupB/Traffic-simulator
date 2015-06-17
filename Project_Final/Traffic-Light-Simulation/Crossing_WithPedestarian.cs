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
     
            
     
       /* public override void paintSelf(System.Drawing.Graphics gr)
        {
            throw new NotImplementedException();
        }*/
        /// <summary>
        /// creates 5 groups of lanes
        /// </summary>
        public void createGroup(Point pos)
        {
            /*  if()//  
              {

              }*/

        }
    }
}
