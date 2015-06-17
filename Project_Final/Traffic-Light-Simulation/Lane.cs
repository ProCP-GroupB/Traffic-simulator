using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;


namespace Traffic_Light_Simulation
{
    class Lane
    {
        public Traffic_light tl;
        List<Point> pts; //every lane has start position, stop position, turning position and end position
        List<Car> listOfCars= new List<Car>(); //no of objects coming in the lane
        int NoOfcarForTrafficJam; //no of cars exceeding capacity
        int maximumcapacity;
        Point startPoint;
        Point turning;
        Point endPoint;
        Point stopPoint;
        int myNumber;
        string direction;
        Point post;
        const int baseNumber=1;
        const int n = 1;
        const  int speed =n*baseNumber ;
        private Graphics graphics;
        bool check = true;


        public Lane(int laneNumber, Point startPoint, Point turning, Point endPoint, Point stopPoint, int capacity, string direction,Point pos)
        {
            this.startPoint = startPoint;
            this.turning = turning;
            this.endPoint = endPoint;
            this.stopPoint = stopPoint;
            myNumber = laneNumber;
            this.direction = direction;
            this.post = pos;
            this.maximumcapacity = capacity;

            createTrafficLight();
            createCarObject();   
        }


        /// <summary>
        /// creates a trafic light for each lane
        /// </summary>
        private void createTrafficLight()
        {

          
            if (direction == "north-left")
            {
                tl = new Traffic_light(post.X + 9, post.Y + 10, 11, 10);
            }
            else if (direction == "north-center")
            {
                tl = new Traffic_light(post.X + 22, post.Y + 10, 11, 10);
            }
            else if (direction == "north-right")
            {
                tl = new Traffic_light(post.X + 35, post.Y + 10, 11, 10);
            }
            else if (direction == "east-top")
            {
                tl = new Traffic_light(post.X + 179, post.Y + 8, 11, 10);
            }
            else if (direction == "east-center")
            {
                tl = new Traffic_light(post.X + 179, post.Y + 23, 11, 10);
            }
            else if (direction == "east-bottom")
            {
                tl = new Traffic_light(post.X + 179, post.Y + 35, 11, 10);
            }
            else if (direction == "west-top")
            {
                tl = new Traffic_light(post.X + 9, post.Y + 155, 11, 10);
            }
            else if (direction == "west-center")
            {
                tl = new Traffic_light(post.X + 9, post.Y + 168, 11, 10);
            }
            else if (direction == "west-bottom")
            {
                tl = new Traffic_light(post.X + 9, post.Y + 182, 11, 10);
            }
            else if (direction == "south-left")
            {
                tl = new Traffic_light(post.X + 155, post.Y + 180, 11, 10);
            }
            else if (direction == "south-center")
            {
                tl = new Traffic_light(post.X + 169, post.Y + 180, 11, 10);
            }
            else if (direction == "south-right")
            {
                tl = new Traffic_light(post.X + 182, post.Y + 180, 11, 10);
            }
      // for pedestrians

                
            else if (direction == "withpedestrian-north")
            {
                tl = new Traffic_light(post.X + 36, post.Y + 37, 11, 10);
            }
            else if (direction == "withpedestrian-east")
            {
                tl = new Traffic_light(post.X + 152, post.Y + 37, 11, 10);
            }
            else if (direction == "withpedestrian-west")
            {
                tl = new Traffic_light(post.X + 36, post.Y + 153, 11, 10);
            }
            else if (direction == "withpedestrian-south")
            {
                tl = new Traffic_light(post.X + 153, post.Y + 153, 11, 10);
            }
        }

        public void createCarObject()
        {
            Point carPosition = new Point();
            int i = 0;
            while (i < 4)
            {

                switch (myNumber)
                {
                    case 1:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y - 4);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y - 8;
                            Car tempo = new Car(carPosition, myNumber);
                            
                            listOfCars.Add(tempo);                            
                        }
                        break;
                    case 2: 
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y - 4);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y - 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 3:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y - 4);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y - 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 4:                        
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 4, stopPoint.Y - 2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X - 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 5:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 4, stopPoint.Y - 2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X - 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 6:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 4, stopPoint.Y - 2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X - 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 7:
                        
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 8:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 9:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 10:                        
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X, stopPoint.Y-2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 11:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X, stopPoint.Y - 2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                    case 12:
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X, stopPoint.Y - 2);
                            listOfCars.Add(new Car(carPosition, myNumber));
                        }
                        else
                        {
                            carPosition.X = carPosition.X + 8;
                            Car tempo = new Car(carPosition, myNumber);

                            listOfCars.Add(tempo);
                        }
                        break;
                }
                  i++;
        }
        }

        /// <summary>
        /// This method paints the Lane object on a graphics 
        /// </summary>
        /// <param name="gr">The graphics that the lane should be painted on</param>
        public void paintSelf(Graphics gr)   
        {
            graphics = gr;
            tl.paintItself(gr); 
            
            for (int x = 0; x < listOfCars.Count; x++)
            {
                listOfCars[x].paintSelf(gr);
                
            }          
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Point> atPosition()
        {
            return pts;
        }

        /// <summary>
        /// This method is used to add a car to a lane by user
        /// </summary>
        /// <param name="numberofcars">The new number of cars of the lane</param>
        /// <returns>Returns true if the car object is successfully added</returns>
        public void AddCar(int numberofcars)
        {
            Car car = new Car(startPoint, myNumber);
            for(int x=0; x<numberofcars; x++)
            {
                listOfCars.Add(car);
            }
        }
        /// <summary>
        /// This method is used to add a car to a lane coming from a neghibour
        /// </summary>
        /// <param name="numberofcars">The new number of cars of the lane</param>
        /// <returns>Returns true if the car object is successfully added</returns>
        public void AddIncomingCar(int numberofcars)
        {
            if(check)
            {
                Car car = new Car(startPoint, myNumber);
                for (int x = 0; x < numberofcars; x++)
                {
                    listOfCars.Add(car);
                }
                check = false;
            }
        }

        /// <summary>
        /// This method removes a car from a lane when it reaches the end of the lane and there is no connection
        /// </summary>
        /// <param name="car">The car that is to be removed</param>
        /// <returns>Returns true if the car is successfully removed and false otherwise</returns>
        public bool RemoveCar(Car car)
        {
           //List<Car> tempolist = new List<Car>(listOfCars);
           //tempolist.Remove(car);
           //listOfCars = tempolist.ToArray();
           listOfCars.Remove(car);

           return true;
        }

        /// <summary>
        /// This method checks the traffic to see if there is a jam or not by calculating noOfcarsFor
        /// </summary>
        /// <param name="l">The lane that is to be checked </param>
        /// <returns>Returns true if there's a traffic jam and false otherwise</returns>
        public bool CheckTrafficJam(Lane l)
        {
            return true;
        }

        /// <summary>
        /// this method will set car position according go the dircetion of lane and removes car if out of lane
        /// </summary>
        public void move()
        {
            if (myNumber==1)
            {
                for (int i = 0; i < listOfCars.Count; i++)
                {
                    if (listOfCars[i].pos.Y <= this.turning.Y)
                        listOfCars[i].pos.Y += speed;
                    else
                        listOfCars[i].pos.X -= speed;

                    //to remove the car at end line
                    if (listOfCars[i].pos.X < this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[i]);
                        listOfCars[i].setPosition(this.startPoint);
                    }                    
                }                    
            }
            else if (myNumber == 2)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y <= this.turning.Y)
                    {
                        listOfCars[x].pos.Y += speed;
                   }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                       // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                    
                }               
            }
            else if (myNumber == 3)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y <= this.turning.Y)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    else if (listOfCars[x].pos.Y > this.turning.Y)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }               
            }
            else if (myNumber == 4)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    else if (listOfCars[x].pos.X > this.turning.X)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 5)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                       // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                        //AddCar(1);
                    } 
                }
            }
            else if (myNumber == 6)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    else if (listOfCars[x].pos.X > this.turning.X)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                       // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }                
            }
            else if (myNumber == 7)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    else if (listOfCars[x].pos.Y < this.turning.Y)
                    {
                        listOfCars[x].pos.X -= speed;
                    }

                    if (listOfCars[x].pos.X < this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }              
            }
            else if (myNumber == 8)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }                    
                }
            }
            else if (myNumber == 9)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    else if (listOfCars[x].pos.Y < this.turning.Y)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }               

            }
            else if (myNumber == 10)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    else if (listOfCars[x].pos.X < this.turning.X)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                       // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);

                    }
                }               

            }
             else if (myNumber == 11)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    if (listOfCars[x].pos.X < this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);

                    }
                    
                }               

            }
            else  // lane num 12
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    else if (listOfCars[x].pos.X < this.turning.X)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }               
            }
        }


        public void keepmoving()
        {
            Point carPosition = new Point();
            if (myNumber == 1)
            {
                //to keep it moving
                for (int i = 0; i < listOfCars.Count; i++)
                {
                    if (listOfCars[i].pos.Y > this.stopPoint.Y)
                    {
                        if (listOfCars[i].pos.Y <= this.turning.Y)
                            listOfCars[i].pos.Y += speed;
                        else
                            listOfCars[i].pos.X -= speed;
                    }
                }
                for (int i = 0; i < listOfCars.Count; i++)
                {
                    //to remove the car at end line and put it back at starting point
                    if (listOfCars[i].pos.X < this.endPoint.X)
                    {
                        if (i == 0)
                        {
                            carPosition = new Point(stopPoint.X - 2, stopPoint.Y - 4);
                           // listOfCars.Add(new Car(carPosition, myNumber));
                            listOfCars[i].pos = carPosition;
                            //Car car = new Car(carPosition);
                        }
                        else
                        {
                            carPosition.Y = carPosition.Y - 8;
                            //Car tempo = new Car(carPosition, myNumber);

                            listOfCars[i].pos = carPosition;                            
                        }                        
                    } 
                }

            }
            else if (myNumber == 2)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y <= this.turning.Y)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                        // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 3)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y <= this.turning.Y)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    else if (listOfCars[x].pos.Y > this.turning.Y)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }

            }
            else if (myNumber == 4)
            {

                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X > this.stopPoint.X)
                   {
                    
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    else if (listOfCars[x].pos.X > this.turning.X)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.stopPoint);
                    }
                   }
                }
            }
            else if (myNumber == 5)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                        // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 6)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X <= this.turning.X)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    else if (listOfCars[x].pos.X > this.turning.X)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                        // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 7)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    else if (listOfCars[x].pos.Y < this.turning.Y)
                    {
                        listOfCars[x].pos.X -= speed;
                    }

                    if (listOfCars[x].pos.X < this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 8)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 9)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.Y >= this.turning.Y)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    else if (listOfCars[x].pos.Y < this.turning.Y)
                    {
                        listOfCars[x].pos.X += speed;
                    }
                    if (listOfCars[x].pos.X > this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 10)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    else if (listOfCars[x].pos.X < this.turning.X)
                    {
                        listOfCars[x].pos.Y -= speed;
                    }
                    if (listOfCars[x].pos.Y < this.endPoint.Y)
                    {
                        // RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else if (myNumber == 11)
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    if (listOfCars[x].pos.X < this.endPoint.X)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }
            else  // lane num 12
            {
                for (int x = 0; x < listOfCars.Count; x++)
                {
                    if (listOfCars[x].pos.X >= this.turning.X)
                    {
                        listOfCars[x].pos.X -= speed;
                    }
                    else if (listOfCars[x].pos.X < this.turning.X)
                    {
                        listOfCars[x].pos.Y += speed;
                    }
                    if (listOfCars[x].pos.Y > this.endPoint.Y)
                    {
                        //RemoveCar(listOfCars[x]);
                        listOfCars[x].setPosition(this.startPoint);
                    }
                }
            }            

        }        
    }
}
