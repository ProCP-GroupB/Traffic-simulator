using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class TrafficLight
    {
        private Point position;
        private LightColor color;
        private int greenTime;
        private Rectangle[] lights;

        public LightColor LightColor
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
        /// Changes the color of the light
        /// </summary>
        public void ChangeState()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Sets a new value to the 'greenTime'  variable
        /// </summary>
        public void ChangeGreenTime()
        {
            throw new System.NotImplementedException();
        }
    }
}
