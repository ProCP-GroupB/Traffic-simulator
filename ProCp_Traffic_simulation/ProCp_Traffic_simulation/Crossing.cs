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
      //  private int crossingNumber = 0;
        private Image image;
        private Point[] turningPoints;
        private int nrOfCars;
        List<Group> groups;
        LightColor light;
        TrafficLight trafficlight;

        private List<Car> carsturning = new List<Car>();
        
        public Image Image{get;set;}
        public Point[] Turningpoints{get;set;}
        public int NrOfCars{get;set;}


        public Crossing(Image image, int numOfCars)
        {
           // this.crossingNumber = CrossingNumber;
            Image = image;

            //Turningpoints = point;
            NrOfCars = numOfCars;

        }


        public void setCrossing()
        {

        }

        public List<Group> Groups
        {
            get
            {
                return groups;
            }
            set
            {
                groups = value;
            }
        }

        /// <summary>
        /// Triggers the event to change the traffic light
        /// </summary>
        public void ChangeTrafficLight(EventArgs e)
        {
            LightColor value = LightColor.Red;
            if (value == LightColor.Red)
            {

                trafficlight.paintgreen();

            }
            else
            {
                trafficlight.painttoRed();
            }


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
            foreach (Car car in carsturning)
            {
                
            }
        }

    }
}
