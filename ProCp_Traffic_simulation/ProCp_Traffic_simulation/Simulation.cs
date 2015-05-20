using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProCp_Traffic_simulation
{
    public class Simulation
    {
        public bool simulationRunning;
        private Timer timer;
        private PictureBox[] grid;
        List<Crossing> crossings = new List<Crossing>();

        /// <summary>
        /// Starts the simulation
        /// </summary>
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Stops the simulation
        /// </summary>
        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void AddCrossing(Crossing c)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCrossing()
        {
            throw new System.NotImplementedException();
        }
    }
}
