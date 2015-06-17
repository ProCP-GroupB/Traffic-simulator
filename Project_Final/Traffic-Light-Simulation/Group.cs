using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Traffic_Light_Simulation
{
    class Group
    {
        public string name;
        //   List<Lane> listOfLanes;
       public Lane[] listOfLanes;
       public Timer timer= new Timer();

        /// <summary>
        /// create a lane with a given position and assigns name and default timer 20sec for the group
        /// </summary>
        /// <param name="nameofgroup"></param>
        /// <param name="pos">the position of the lane</param>
        public Group(string nameofgroup, params Lane[] laneInGroup)
        {
            this.name = nameofgroup;
            listOfLanes=new Lane[laneInGroup.Length];
            for(int i=0;i<laneInGroup.Length;i++)
            {
                listOfLanes[i]=laneInGroup[i];
            }
            timer.Interval = 5000;
        }

        /// <summary>
        /// changes the color of light of lights in the group to green and Red according to timer
        /// </summary>
        /// <returns>it retuns true if all are changed to red</returns>
        public bool changecolor()
       {
           return true;
           
       }

        /// <summary>
        /// sets the time length of each light in the group
        /// </summary>
        public void setTime(int len)
        {
            this.timer.Interval = len;
        }

        public int getinterval()
        {
            return this.timer.Interval;
        }      
        
    }
}
