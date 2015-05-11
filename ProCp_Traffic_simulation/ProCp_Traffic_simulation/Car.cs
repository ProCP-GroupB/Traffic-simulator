using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class Car
    {
        private Color color;
        private Lane onLane;
        private Point position;
        private int speed;
        private int height;
        private int width;
        /// <summary>
        /// Keeps track of all cars
        /// </summary>
        private static List<Car> carsInFront;
        private Direction direction;

        public Direction Direction
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
        /// Draws the car on the screen as rectangle
        /// </summary>
        public Graphics DrawCar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Moves the car along the lane and stops if neccesary
        /// </summary>
        public void Move()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Decreases the speed of the car to a complete stop
        /// </summary>
        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// To check the positions of the cars (not overlap)
        /// returns true if there is no car on the front position
        /// </summary>
        public bool CheckCars()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeDirection()
        {
            throw new System.NotImplementedException();
        }
    }
}
