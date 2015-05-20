using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProCp_Traffic_simulation
{
    public class Group
    {
        private string name;
        private List<Lane> listOfLanes;
        private List<TrafficLight> listOfLights;

        /// <summary>
        /// Stops the cars and changes the state of the Traffic Lights
        /// </summary>
        public event EventHandler ChangeLight;
         protected virtual void onChangeLight(EventArgs e)
        {

            EventHandler handler = ChangeLight;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Triggered when CarsToTurn() is called and calls the Turn() for each car object
        /// </summary>
        public event EventHandler onChangeDirection;

        public TrafficLight TrafficLight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Lane Lane
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Group(string Name)
        {
            this.name = Name;
            listOfLanes = new List<Lane>();
            listOfLights = new List<TrafficLight>();
        }

        /// <summary>
        /// Adds the passed lane to the list
        /// </summary>
        public void t()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Adds the passed traffic light to the list
        /// </summary>
        public void AddTrafficLight()
        {
            throw new System.NotImplementedException();
        }
    }
}
