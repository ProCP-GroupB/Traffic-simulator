using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class Lane
    {
        private int laneID;

        // According to the direction of the lane, the traffic light will be put at certain position
        private Direction direction;

        // Where lane starts
        private Point startPoint;

        // Where the lane ends
        private int endPoint;

        // Where the cars have to stop
        private int stopPoint;
        private int speed;
        public List<Car> listOfCars;
        /// <summary>
        /// If true let's cars move
        /// </summary>
        public bool isGreen;
        /// <summary>
        /// Whether this lane consumes or creates cars
        /// </summary>
        public bool isFeeder;

        public event LaneHandler toChangeLane;
        public delegate void LaneHandler(Lane lane, Car car);

        /// <summary>
        /// Returns the endPoint of a Lane
        /// </summary>
        public int EndPoint
        {
            get { return endPoint; }
        }

        public int StopPoint
        {
            get { return stopPoint; }
        }

        public Point StartPoint
        {
            get { return startPoint; }
        }

        /// <summary>
        /// Returns the direction
        /// </summary>
        public Direction getDirection
        {
            get { return direction; }
        }

        private int carsAdded;

        public Lane(int laneID, Direction direction, bool isLaneFeeder)
        {
            this.laneID = laneID;
            this.direction = direction;
            this.isFeeder = isLaneFeeder;
            this.listOfCars = new List<Car>();
            //this.carsAdded = -1;
            if (isFeeder)
            {
                switch (direction.ToString().ToLower())
                {
                    case "west":
                        stopPoint = 33;
                        endPoint = stopPoint;
                        startPoint = new Point(0,77);
                        break;
                    case "east":
                        stopPoint = 108;
                        endPoint = stopPoint;
                        startPoint = new Point(150,68);
                        break;
                    case "north":
                        stopPoint = 32;
                        endPoint = stopPoint;
                        startPoint = new Point(0,66);
                        break;
                    case "south":
                        stopPoint = 108;
                        endPoint = stopPoint;
                        startPoint = new Point(76,150);
                        break;
                    case "westsouth":
                        stopPoint = 33;
                        endPoint = stopPoint;
                        startPoint = new Point(0,85);
                        break;
                    case "eastnorth":
                        stopPoint = 108;
                        endPoint = stopPoint;
                        startPoint = new Point(150,58);
                        break;
                    case "northwest":
                        stopPoint = 32;
                        endPoint = stopPoint;
                        startPoint = new Point(0,56);
                        break;
                    case "southeast":
                        stopPoint = 108;
                        endPoint = stopPoint;
                        startPoint = new Point(150,86);
                        break;
                }
            }
            else if (!isFeeder)
            {
                switch (direction.ToString().ToLower())
                {
                    case "west":
                        stopPoint = 150;
                        endPoint = stopPoint;
                        startPoint = new Point(86, 85);
                        break;
                    case "south":
                        stopPoint = 0;
                        endPoint = stopPoint;
                        startPoint = new Point(86, 61);
                        break;
                    case "east":
                        stopPoint = 0;
                        endPoint = stopPoint;
                        startPoint = new Point(59, 61);
                        break;
                    case "north":
                        stopPoint = 150;
                        endPoint = stopPoint;
                        startPoint = new Point(59, 85);
                        break;
                }
            }
        }

        public Car Car
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
        /// Adds a new car to the lane and sets the cars in front of this car;
        /// </summary>
        public void AddCar(Car car)
        {
            car.carsInFront = listOfCars;
            car.toChangeDirection += new Car.DirectionHandler(onChangeDirection);
            listOfCars.Add(car);
        }

        public void onChangeDirection(Car car, Direction dir)
        {
            listOfCars.Remove(car);
            car.Direction = dir;
            car.toChangeDirection -= new Car.DirectionHandler(onChangeDirection);
            toChangeLane(this, car);
        }

        /// <summary>
        /// Adds an existing car comming from a neighbouring lane
        /// </summary>
        public void IncomingCar()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a traffic light for the lane
        /// </summary>
        public void createTrafficLight()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the car from the lane (list as well)
        /// </summary>
        public void RemoveCar(Car car)
        {
            if (!isFeeder)
                listOfCars.Remove(car);
        }

        /// <summary>
        /// If this is not a feeder lane then cars have to be destroyed
        /// after leaving the lane (set the car object = null)
        /// </summary>
        public void DestroyCar()
        {
            throw new System.NotImplementedException();
        }
    }
}
