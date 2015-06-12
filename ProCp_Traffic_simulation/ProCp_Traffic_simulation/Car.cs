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
        public List<Car> carsInFront;
        private Direction direction;
        //private int carsInFront;
        public Rectangle rect;
        public bool toStop = false;

        public event EventHandler toChangeDirection;

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

        //public int nrCarsInFront { get { return carsInFront; } set { carsInFront = value; } }

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
                    while ((rect.X <= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.X += 1;
                        Thread.Sleep(51);
                       
                    }
                    
                    break;
                case "east":
                    while ((rect.X >= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.X -= 1;
                        Thread.Sleep(51);
                        
                    }
                    break;
                case "south":
                    while ((rect.Y >= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.Y -= 1;
                        Thread.Sleep(51);
                    }
                    break;
                case "north":
                    while ((rect.Y <= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.Y += 1;
                        Thread.Sleep(51);
                    }
                    break;
                case "westsouth":
                    while ((rect.X <= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.X += 1;
                        Thread.Sleep(51);

                    }
                    if (rect.X >= onLane.StopPoint && onLane.isGreen)
                        //toChangeDirection;

                    break;
                case "southeast":
                    while ((rect.Y >= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.Y -= 1;
                        Thread.Sleep(51);
                    }
                    break;
                case "eastnorth":
                    while ((rect.X >= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.X -= 1;
                        Thread.Sleep(51);

                    }
                    break;
                case "northwest":
                    while ((rect.Y <= onLane.StopPoint && onLane.isGreen) || onLane.isFeeder == false)
                    {
                        rect.Y += 1;
                        Thread.Sleep(51);
                    }
                    break;
            }
            Stop();
        }

        /// <summary>
        /// Decreases the speed of the car to a complete stop
        /// </summary>
        public void Stop()
        {
            if (carsInFront != null) // if there are cars in the front -> stop behind them
            {
                Car lastCar = carsInFront.ElementAt(carsInFront.Count - 1);

                switch (direction.ToString().ToLower())
                {
                    case "west":
                        while (rect.X <= lastCar.rect.X - 10)
                        {
                            rect.X += 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "east":
                        while (rect.X >= lastCar.rect.X + 10)
                        {
                            rect.X -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "south":
                        while (rect.Y >= lastCar.rect.Y - 10)
                        {
                            rect.Y -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "north":
                        while (rect.Y <= lastCar.rect.Y + 10)
                        {
                            rect.Y += 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "westsouth":
                        while (rect.X <= lastCar.rect.X - 10)
                        {
                            rect.X += 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "eastnorth":
                        while (rect.X >= lastCar.rect.X + 10)
                        {
                            rect.X -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "southeast":
                        while (rect.Y >= lastCar.rect.Y - 10)
                        {
                            rect.Y -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "northwest":
                        while (rect.Y <= lastCar.rect.Y + 10)
                        {
                            rect.Y += 1;
                            Thread.Sleep(51);
                        }
                        break;
                }
            }

            else                                      // if there are no cars in front -> stop on the stop point
            {
                switch (direction.ToString().ToLower())
                {
                    case "west":
                        while (rect.X <= onLane.StopPoint)
                        {
                            rect.X += 1;
                            Thread.Sleep(51);

                        }
                        toStop = true;

                        break;
                    case "east":
                        while (rect.X >= onLane.StopPoint)
                        {
                            rect.X -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "south":
                        while (rect.Y >= onLane.StopPoint)
                        {
                            rect.Y -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "north":
                        while (rect.Y <= onLane.StopPoint)
                        {
                            rect.Y += 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "westsouth":
                        while (rect.X <= onLane.StopPoint)
                        {
                            rect.X += 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "southeast":
                        while (rect.Y >= onLane.StopPoint)
                        {
                            rect.Y -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "eastnorth":
                        while (rect.X >= onLane.StopPoint)
                        {
                            rect.X -= 1;
                            Thread.Sleep(51);
                        }
                        break;
                    case "northwest":
                        while (rect.Y <= onLane.StopPoint)
                        {
                            rect.Y += 1;
                            Thread.Sleep(51);
                        }
                        break;
                }
            }
            //switch (direction.ToString().ToLower())
            //{
            //    case "west":
            //        switch (nrCarsInFront)
            //        {
            //            case 0:
            //                while (rect.X <= onLane.StopPoint)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 1:
            //                while (rect.X <= onLane.StopPoint - 5)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 2:
            //                while (rect.X <= onLane.StopPoint - 10)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 3:
            //                while (rect.X <= onLane.StopPoint - 15)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 4:
            //                while (rect.X <= onLane.StopPoint - 20)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 5:
            //                while (rect.X <= onLane.StopPoint - 25)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 6:
            //                while (rect.X <= onLane.StopPoint - 30)
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            default:
            //                while (rect.X <= onLane.StopPoint - (nrCarsInFront * 5))
            //                {
            //                    rect.X += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //        }
            //        break;
            //    case "east":
            //        switch (nrCarsInFront)
            //        {
            //            case 0:
            //                while (rect.X <= onLane.StopPoint)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 1:
            //                while (rect.X <= onLane.StopPoint - 5)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 2:
            //                while (rect.X <= onLane.StopPoint - 10)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 3:
            //                while (rect.X <= onLane.StopPoint - 15)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 4:
            //                while (rect.X <= onLane.StopPoint - 20)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 5:
            //                while (rect.X <= onLane.StopPoint - 25)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 6:
            //                while (rect.X <= onLane.StopPoint - 30)
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            default:
            //                while (rect.X <= onLane.StopPoint - (nrCarsInFront * 5))
            //                {
            //                    rect.X -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //        }
            //        break;
            //    case "north":
            //        switch (nrCarsInFront)
            //        {
            //            case 0:
            //                while (rect.Y <= onLane.StopPoint)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 1:
            //                while (rect.Y <= onLane.StopPoint - 5)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 2:
            //                while (rect.Y <= onLane.StopPoint - 10)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 3:
            //                while (rect.Y <= onLane.StopPoint - 15)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 4:
            //                while (rect.Y <= onLane.StopPoint - 20)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 5:
            //                while (rect.Y <= onLane.StopPoint - 25)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 6:
            //                while (rect.Y <= onLane.StopPoint - 30)
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            default:
            //                while (rect.Y <= onLane.StopPoint - (nrCarsInFront * 5))
            //                {
            //                    rect.Y += 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //        }
            //        break;
            //    case "south":
            //        switch (nrCarsInFront)
            //        {
            //            case 0:
            //                while (rect.Y <= onLane.StopPoint)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 1:
            //                while (rect.Y <= onLane.StopPoint - 5)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 2:
            //                while (rect.Y <= onLane.StopPoint - 10)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 3:
            //                while (rect.Y <= onLane.StopPoint - 15)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 4:
            //                while (rect.Y <= onLane.StopPoint - 20)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 5:
            //                while (rect.Y <= onLane.StopPoint - 25)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            case 6:
            //                while (rect.Y <= onLane.StopPoint - 30)
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //            default:
            //                while (rect.Y <= onLane.StopPoint - (nrCarsInFront * 5))
            //                {
            //                    rect.Y -= 1;
            //                    Thread.Sleep(51);
            //                }
            //                break;
            //        }
            //        break;
            //}
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
