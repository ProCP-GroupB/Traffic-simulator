using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCp_Traffic_simulation
{
    public class Crossing
    {
        private Image image;
        private Point[] turningPoints;
        private int nrOfCars;
        
        public Image Image{get;set;}
        public Point[] Turningpoints{get;set;}
        public int NrOfCars{get;set;}

        /// <summary>
        /// Deconstructor will be used when RemoveCrossing()[Simulation] to set Group,Lanes and etc. objects to null
        /// </summary>
        /// 

        public Crossing(Image image, Point[] point)
        {
            Image = image;
            Turningpoints = point;
            nrOfCars = 0;
        }
        ~Crossing()
        {
            throw new System.NotImplementedException();
        }
    
        public Group Groups
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Triggers the event to change the traffic light
        /// </summary>
        public void ChangeTrafficLight(EventArgs e)
        {       
        }

        /// <summary>
        /// Sets a new value to the 'nrOfCars' variable
        /// </summary>
        public void ChangeNrOfCars(int nrofcars)
        {
            if (nrofcars>20 || nrofcars<0)
            {
                MessageBox.Show("There can not be more than 20 cars! Or less than 0 obviously.");
            }

            else
            {
                nrOfCars = nrofcars;
            }

        }

        /// <summary>
        /// Passes a list of cars the will make a turn
        /// </summary>
        public void CarsToTurn()
        {
            throw new System.NotImplementedException();
        }
    }
}
