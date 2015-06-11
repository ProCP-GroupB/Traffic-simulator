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
        private int startPoint;

        // Where the lane ends
        private int endPoint;

        // Where the cars have to stop
        private int stopPoint;
        private int speed;
        private List<Car> listOfCars;
        /// <summary>
        /// If true let's cars move
        /// </summary>
        public bool isGreen;
        /// <summary>
        /// Whether this lane consumes or creates cars
        /// </summary>
        public bool isFeeder;

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

        public int StartPoint
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

        public Lane(int laneID, Direction direction, int startPoint, int endPoint, int stopPoint, int speed)
        {
            this.laneID = laneID;
            this.direction = direction;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.stopPoint = stopPoint;
            this.speed = speed;
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
        /// Adds and creates a new car to the lane
        /// </summary>
        public void AddCar()
        {

             
            {
                //Car car = new Car();
                //listOfCars.Add(car);
            }

            listOfCars.Add(Car);


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
