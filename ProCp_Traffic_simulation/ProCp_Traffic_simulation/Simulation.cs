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
        public bool isRunning = false;

        /// <summary>
        /// Starts the simulation
        /// </summary>
        public void Start()
        {
            if (crossings.Count > 0)
                isRunning = true;
            else
                throw new Exception("You cannot start the simulation without adding any Crossing! Please first add at least one!");
        }

        /// <summary>
        /// Stops the simulation
        /// </summary>
        public void Stop()
        {
            isRunning = false;
        }

        public void AddCrossing(Crossing c)
        {
            crossings.Add(c);
        }

        public void RemoveCrossing(Crossing c)
        {
            crossings.Remove(c);
        }
    }
}
