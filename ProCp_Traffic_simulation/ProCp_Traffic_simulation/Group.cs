using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class Group
    {
        private string name;
        private List<Lane> listOfLanes;
        private List<TrafficLight> listOfLights;
        private Rectangle[] rectangle = new Rectangle[2];
        bool toGreen = true;

        /// <summary>
        /// Stops the cars and changes the state of the Traffic Lights
        /// </summary>
        //public event EventHandler ChangeLight;
         public void ChangeLight()
        {
            
            foreach (TrafficLight temp in listOfLights)
            {
                if (temp.light == LightColor.Red)
                {
                    temp.paintgreen();
                }
                else if (temp.light == LightColor.Green)
                {
                    toGreen = false;
                    temp.painttoRed();
                }
            }
            
            foreach (Lane temp in listOfLanes)
            {
                if (temp.isGreen && !toGreen)
                    temp.isGreen = false;
                else if(!temp.isGreen && toGreen)
                    temp.isGreen = true;
            }
        }

        /// <summary>
        /// Triggered when CarsToTurn() is called and calls the Turn() for each car object
        /// </summary>
        public event EventHandler onChangeDirection;

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

        // Lanes will be created in the contrusctor according to the Name(e.g. South,East,NorthWest, East+West)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="rect"></param>
        /// <remarks>Name = WestEast/NorthSouth</remarks>
        public Group(string Name, Rectangle[] rect)
        {
            this.name = Name;
            listOfLanes = new List<Lane>();
            listOfLights = new List<TrafficLight>();
            this.rectangle = rect;

            switch (name.ToLower())
            {
                case "westeast":
                    listOfLanes.Add(new Lane(1,Direction.West,true));
                    listOfLanes.Add(new Lane(2, Direction.WestSouth, true));
                    listOfLanes.Add(new Lane(3, Direction.East, true));
                    listOfLanes.Add(new Lane(4, Direction.EastNorth, true));

                    listOfLanes.Add(new Lane(5, Direction.West, false));
                    listOfLanes.Add(new Lane(6, Direction.South, false)); // non-feeder Lane for the turning cars ( south because it increases Y coord.)
                    listOfLanes.Add(new Lane(7, Direction.East, false));
                    listOfLanes.Add(new Lane(8, Direction.North, false));
                    break;
                case "northsouth":
                    listOfLanes.Add(new Lane(1, Direction.North, true));
                    listOfLanes.Add(new Lane(2, Direction.NorthWest, true));
                    listOfLanes.Add(new Lane(3, Direction.South, true));
                    listOfLanes.Add(new Lane(4, Direction.SouthEast, true));

                    listOfLanes.Add(new Lane(5, Direction.North, false));
                    listOfLanes.Add(new Lane(6, Direction.West, false));
                    listOfLanes.Add(new Lane(7, Direction.South, false));
                    listOfLanes.Add(new Lane(8, Direction.East, false));
                    break;
            }

            foreach (Lane temp in listOfLanes)
            {
                temp.toChangeLane += new Lane.LaneHandler(onChangeLane);
            }
        }

        public void onChangeLane(Lane lane, ref Car car)
        {
            foreach (Lane temp in listOfLanes)
            {
                if (temp.getDirection == car.Direction && temp.isFeeder == false)
                {
                    temp.AddCar(car);
                    car.ChangeDirection(car.Direction);
                }
            }
        }

        /// <summary>
        /// Adds the passed lane to the list
        /// </summary>
        public List<TrafficLight> GetListOfLights()
        {
            return this.listOfLights;
        }

        /// <summary>
        /// Adds the passed traffic light to the list
        /// </summary>
        public void AddTrafficLight()
        {
            //Making two trafic lights for the 2 sides of the crossroad
            TrafficLight light = new TrafficLight(rectangle[0].X, rectangle[0].Y, 15, 15, 5);
            TrafficLight lightOpposite = new TrafficLight(rectangle[1].X, rectangle[1].Y, 15, 15, 5);

            listOfLights.Add(light);
            listOfLights.Add(lightOpposite);

        }

        /// <summary>
        /// Adds cars to each lane
        /// </summary>
        public void AddTraffic()
        {
            foreach (Lane temp in listOfLanes)
            {
                if(temp.isFeeder)
                {
                    switch (temp.getDirection.ToString().ToLower())
                    {
                        case "west":
                            temp.AddCar(new Car(Direction.West, new Rectangle(0, 77, 8, 8)));
                            break;
                        case "westsouth":
                            temp.AddCar(new Car(Direction.WestSouth, new Rectangle(0, 85, 8, 8)));
                            break;
                        case "east":
                            temp.AddCar(new Car(Direction.East, new Rectangle(150, 68, 8, 8)));
                            break;
                        case "eastnorth":
                            temp.AddCar(new Car(Direction.EastNorth, new Rectangle(150, 58, 8, 8)));
                            break;
                        case "north":
                            temp.AddCar(new Car(Direction.North, new Rectangle(66, 0, 8, 8)));
                            break;
                        case "northwest":
                            temp.AddCar(new Car(Direction.NorthWest, new Rectangle(56, 0, 8, 8)));
                            break;
                        case "south":
                            temp.AddCar(new Car(Direction.South, new Rectangle(76, 150, 8, 8)));
                            break;
                        case "southeast":
                            temp.AddCar(new Car(Direction.SouthEast, new Rectangle(86, 150, 8, 8)));
                            break;
                    }
                }
            }
            
        }
    }
}
