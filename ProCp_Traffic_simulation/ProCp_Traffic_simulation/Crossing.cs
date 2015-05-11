using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class Crossing
    {
        private Image image;
        private Point[] turningPoints;
        private int nrOfCars;

        /// <summary>
        /// Deconstructor will be used when RemoveCrossing()[Simulation] to set Group,Lanes and etc. objects to null
        /// </summary>
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
        public void ChangeTrafficLight()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets a new value to the 'nrOfCars' variable
        /// </summary>
        public void ChangeNrOfCars()
        {
            throw new System.NotImplementedException();
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
