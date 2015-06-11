using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

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
        // Critical section borders
        private int minXcs = 33;
        private int maxXcs = 108;
        private int minYcs = 32;
        private int maxYcs = 108;

        private Direction direction;
        private int carsInFront;
        public Rectangle rect;
        public bool toStop = false;

        public Direction Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

        public int nrCarsInFront { get { return carsInFront; } set { carsInFront = value; } }

        public Car(Direction direct, Rectangle rectangle)
        {
            Direction = direct;
            rect = rectangle;
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
            switch (direction.ToString().ToLower())
            {
                case "west":
                    while (rect.X <= minXcs)
                    {
                        rect.X += 1;
                        Thread.Sleep(51);
                       
                    }
                    toStop = true;
                    ChangeDirection();
                    break;
                case "east":
                    while (rect.X >= maxXcs)
                    {
                        rect.X -= 5;
                        Thread.Sleep(51);
                        
                    }
                    break;
                case "south":
                    while (rect.Y <= maxYcs)
                    {
                        rect.Y += 1;
                        Thread.Sleep(51);
                    }
                    break;
                case "north":
                    while (rect.Y <= minYcs)
                    {
                        rect.Y -= 5;
                        Thread.Sleep(51);
                    }
                    break;
            }
        }

        /// <summary>
        /// Decreases the speed of the car to a complete stop
        /// </summary>
        public void Stop()
        {
            switch (direction.ToString().ToLower())
            {
                case "west":
                    while ((rect.X <= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {


                        rect.X += 1;
                        Thread.Sleep(51);       // waiting for the timer
                    }
                    toStop = true;
                    break;
                case "east":
                    while ((rect.X >= onLane.StopPoint && onLane.isGreen) || rect.X < maxXcs)    // || onLane.isGreen
                    {
                        rect.X -= 1;
                        Thread.Sleep(51);       // waiting for the timer
                    }
                    break;
                case "north":
                    while ((rect.Y <= minYcs && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.Y += 1;
                        Thread.Sleep(51);
                    }
                    break;
                case "south":
                    switch (nrCarsInFront)
                    {
                        case 0:
                            while (rect.Y <= onLane.StopPoint)
                            {
                                rect.Y -= 1;
                                Thread.Sleep(51);
                            }
                            break;
                        case 1:
                            while (rect.Y <= onLane.StopPoint - 5)
                            {
                                rect.Y -= 1;
                                Thread.Sleep(51);
                            }
                            break;
                        case 2:
                            while (rect.Y <= onLane.StopPoint - 10)
                            {
                                rect.Y -= 1;
                                Thread.Sleep(51);
                            }
                            break;
                    }
                    break;
            }
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
            toStop = false;
            direction = Direction.South;
            rect = new Rectangle(55,77,8,8);
            Move();
          
        }
    }
}
