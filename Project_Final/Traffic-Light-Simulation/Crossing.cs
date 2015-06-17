
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace Traffic_Light_Simulation
{
   abstract class Crossing
    {

      
       List<Lane> listOfLanes = new List<Lane>();
      
      public List<Group> myGroup = new List<Group>();
       public List<Crossing> myneighbours = new List<Crossing>(4);
       

       Timer timer = new Timer();
       string type;
       Group greenGroups;
        public Point position;
        public Rectangle crossingrect;
        bool light1IsRed;
        bool light2Isred;
        int shifts;
        Point[] startPoint = new Point[12];
       
        Point[] turning = new Point[12];
        // List<Point> endPoint = new List<Point>();
        Point[] endPoint = new Point[12];
        Point[] stopPoint = new Point[12];
       
        
        int cap = 8;


        
       
       public  Image crossingimg;

       //public List(IEnumerable<T> collection)
       
       /// <summary>
       /// This is the constructor of the crossing class
       /// </summary>
       /// <param name="type">This is the type of crossing</param>
        public Crossing(Rectangle rect, Image img,string type)
        {

            position = rect.Location;
            crossingrect = rect;
            crossingimg = img;
            this.type = type;
            createGroup();
             
            for (int x = 0; x < 4; x++)
            {
                myneighbours.Add(null);
            }
            

            

            

            //
           
        }

        public void createGroup()
        {
            //***********************************************************************************
            //startPoint[0].X = position.X;
            

            startPoint[0] = new Point(position.X + 59, position.Y);
            endPoint[0] = new Point(position.X, position.Y + 72+2);
            turning[0] = new Point(startPoint[0].X, endPoint[0].Y);
            stopPoint[0] = new Point(position.X + 59, position.Y + 35);
            //Lane lane1 = new Lane(startPoint[0], turning[0],endPoint[0], cap);
            //**********************************************************************************

            startPoint[1] = new Point(position.X + 78, position.Y);
            endPoint[1] = new Point(position.X + 78, position.Y + 200);//
            turning[1] = new Point(startPoint[1].X, endPoint[1].Y);
            stopPoint[1] = new Point(position.X + 78, position.Y + 35);
            //Lane lane2 = new Lane(startPoint[1], turning[1], endPoint[1], cap);

            //************************************************************************************

            startPoint[2] = new Point(position.X + 97, position.Y);
            endPoint[2] = new Point(position.X+200, position.Y + 128-9);
            turning[2] = new Point(startPoint[2].X, endPoint[2].Y);
            stopPoint[2] = new Point(position.X + 97, position.Y + 35);
            // Lane lane3 = new Lane(startPoint[2], turning[2], endPoint[2], cap);
            //************************************************************************************

            startPoint[3] = new Point(position.X, position.Y + 103);
            endPoint[3] = new Point(position.X + 128-9, position.Y);
            turning[3] = new Point(endPoint[3].X, startPoint[3].Y);
            stopPoint[3] = new Point(position.X + 35, position.Y + 103);
            // Lane lane4 = new Lane(startPoint[3], turning[3], endPoint[3], cap);
            //**********************************************************************************
            startPoint[4] = new Point(position.X, position.Y + 122);
            endPoint[4] = new Point(position.X + 200, position.Y + 122);//
            turning[4] = new Point(endPoint[4].X, startPoint[4].Y);
            stopPoint[4] = new Point(position.X + 35, position.Y + 122);
            // Lane lane5 = new Lane(startPoint[4], turning[4], endPoint[4], cap);
            //************************************************************************************
            startPoint[5] = new Point(position.X, position.Y + 141);
            endPoint[5] = new Point(position.X + 74, position.Y + 200);
            turning[5] = new Point(endPoint[5].X, startPoint[5].Y);
            stopPoint[5] = new Point(position.X + 35, position.Y + 141);
            // Lane lane6 = new Lane(startPoint[5], turning[5], endPoint[5], cap);
            //*****************************************************************lljhgffdhasf
            startPoint[6] = new Point(position.X + 103, position.Y + 200);
            endPoint[6] = new Point(position.X, position.Y + 72+5);
            turning[6] = new Point(startPoint[6].X, endPoint[6].Y);
            stopPoint[6] = new Point(position.X + 103, position.Y + 165);
            // Lane lane7 = new Lane(startPoint[6], turning[6], endPoint[6], cap);
            //***************************************************************************
            startPoint[7] = new Point(position.X + 122, position.Y + 200);
            endPoint[7] = new Point(position.X + 122, position.Y);//
            turning[7] = new Point(startPoint[7].X, endPoint[7].Y);
            stopPoint[7] = new Point(position.X + 122, position.Y + 165);
            //Lane lane8 = new Lane(startPoint[7], turning[7], endPoint[7], cap);
            //*********************************************************************************
            startPoint[8] = new Point(position.X + 141, position.Y + 200);
            endPoint[8] = new Point(position.X + 200, position.Y + 128-6);
            turning[8] = new Point(startPoint[8].X, endPoint[8].Y);
            stopPoint[8] = new Point(position.X + 141, position.Y + 165);
            // Lane lane9 = new Lane(startPoint[8], turning[8], endPoint[8], cap);
            //********************************************************************************
            startPoint[9] = new Point(position.X + 200, position.Y + 59);
            endPoint[9] = new Point(position.X + 128-6, position.Y);
            turning[9] = new Point(endPoint[9].X, startPoint[9].Y);
            stopPoint[9] = new Point(position.X + 165, position.Y + 59);
            // Lane lane10 = new Lane(startPoint[9], turning[9], endPoint[9], cap);
            //******************************************************************************
            startPoint[10] = new Point(position.X + 200, position.Y + 78);
            endPoint[10] = new Point(position.X, position.Y + 78);
            turning[10] = new Point(endPoint[10].X, startPoint[10].Y);
            stopPoint[10] = new Point(position.X + 165, position.Y + 78);
            // Lane lane11 = new Lane(startPoint[10], turning[10], endPoint[10], cap);
            //******************************************************************************
            startPoint[11] = new Point(position.X + 200, position.Y + 97);
            endPoint[11] = new Point(position.X + 72+5, position.Y + 200);
            turning[11] = new Point(endPoint[11].X, startPoint[11].Y);
            stopPoint[11] = new Point(position.X + 165, position.Y + 97);
            //Lane lane12 = new Lane(startPoint[11], turning[11], endPoint[11], cap);
            //******************************************************************************************
           // for (int i = 0; i < 12; i++)
           // {
                //listOfLanes[i] = new Lane(i + 1, startPoint[i], turning[i], endPoint[i], stopPoint[i], cap, "", endPoint[i]);
            //}
           // .....
           //List<Lane> listOfLanes = new List<Lane>();
            Point tempocrossingrect = new Point(crossingrect.X, crossingrect.Y);
            


                
                Lane a = new Lane(1, startPoint[0], turning[0], endPoint[0], stopPoint[0], cap, "north-left", tempocrossingrect);
                Lane b = new Lane(2, startPoint[1], turning[1], endPoint[1], stopPoint[1], cap, "north-center", tempocrossingrect);
                Lane c = new Lane(3, startPoint[2], turning[2], endPoint[2], stopPoint[2], cap, "north-right", tempocrossingrect);
                Lane d = new Lane(4, startPoint[3], turning[3], endPoint[3], stopPoint[3], cap, "west-top", tempocrossingrect);
                Lane e = new Lane(5, startPoint[4], turning[4], endPoint[4], stopPoint[4], cap, "west-center", tempocrossingrect);
                Lane f = new Lane(6, startPoint[5], turning[5], endPoint[5], stopPoint[5], cap, "west-bottom", tempocrossingrect);
                Lane g = new Lane(7, startPoint[6], turning[6], endPoint[6], stopPoint[6], cap, "south-left", tempocrossingrect);
                Lane h = new Lane(8, startPoint[7], turning[7], endPoint[7], stopPoint[7], cap, "south-center", tempocrossingrect);
                Lane j = new Lane(9, startPoint[8], turning[8], endPoint[8], stopPoint[8], cap, "south-right", tempocrossingrect);
                Lane k = new Lane(10, startPoint[9], turning[9], endPoint[9], stopPoint[9], cap, "east-top", tempocrossingrect);
                Lane l = new Lane(11, startPoint[10], turning[10], endPoint[10], stopPoint[10], cap, "east-center", tempocrossingrect);
                Lane m = new Lane(12, startPoint[11], turning[11], endPoint[11], stopPoint[11], cap, "east-bottom", tempocrossingrect);
             

                listOfLanes.Add(a);
                listOfLanes.Add(b);
                listOfLanes.Add(c);
                listOfLanes.Add(d);
                listOfLanes.Add(e);
                listOfLanes.Add(f);
                listOfLanes.Add(g);
                listOfLanes.Add(h);
                listOfLanes.Add(j);
                listOfLanes.Add(k);
                listOfLanes.Add(l);
                listOfLanes.Add(m);
            myGroup.Add(new Group("Group1", listOfLanes[0], listOfLanes[1], listOfLanes[7], listOfLanes[8]));

            myGroup.Add(new Group("Group2", listOfLanes[4], listOfLanes[5], listOfLanes[9], listOfLanes[10]));
            myGroup.Add(new Group("Group3", listOfLanes[3], listOfLanes[0], listOfLanes[11]));
            myGroup.Add(new Group("Group4", listOfLanes[2], listOfLanes[6], listOfLanes[5])); 
          
             if(this.type=="with-pedestrian")
             {
                Point pt12 = new Point(0, 0);
                  Lane n = new Lane(13, pt12, pt12, pt12, pt12, cap, "withpedestrian-north", tempocrossingrect);
                Lane o = new Lane(14, pt12, pt12, pt12, pt12, cap, "withpedestrian-south", tempocrossingrect);
                Lane p = new Lane(15, pt12, pt12, pt12, pt12, cap, "withpedestrian-east", tempocrossingrect);
                Lane q = new Lane(16, pt12, pt12, pt12, pt12, cap, "withpedestrian-west", tempocrossingrect);

                
                listOfLanes.Add(n);
                listOfLanes.Add(o);
                listOfLanes.Add(p);
                listOfLanes.Add(q);
                myGroup.Add(new Group("Group5", listOfLanes[4], listOfLanes[10], listOfLanes[12], listOfLanes[13], listOfLanes[14], listOfLanes[15]));

             
            }

           // listOfLanes = tempolistOfLanes.ToArray();

            // Group
             
   

        }
        /// <summary>
        /// This methods is will be used to edit the crossing 
        /// </summary>
        /// <param name="post">The position provided by the user </param>
        /// <returns>Returns true if the eiditing is successful</returns>
        public bool edit(Point post)
        {
            return true;
        }
       /// <summary>
       /// This method will be called to tell a group to change to green in sequence of group list
       /// </summary>
        public bool BeGreen(int Groupindex)
        {
            
          
            for (int x = 0; x < myGroup.Count; x++ )
            {

                if (Groupindex != x)
                {
                    for (int y = 0; y < myGroup[x].listOfLanes.Length; y++)
                    {
                        myGroup[x].listOfLanes[y].tl.painttoRed();
                       




                    }
                }
            }
            for (int x = 0; x < myGroup.Count; x++)
            {
                if (Groupindex == x)
                {
                    

                    for (int y = 0; y < myGroup[x].listOfLanes.Length; y++)
                    {
                        myGroup[x].listOfLanes[y].tl.paintgreen();
                        myGroup[x].listOfLanes[y].move();
                        

                    }
                    NoOfOutgoingCar(myGroup[x].name);

                    // for cars which are already in the middle of the road
                    int checkinvalue = Groupindex - 1;
                    if (Groupindex == 0 && type == "with-pedestrian")
                    {
                        checkinvalue = 4;
                    }
                    else if (Groupindex == 0 && type == "without-pedestrian")
                    {
                        checkinvalue = 3;
                    }
                    for (int y = 0; y < myGroup[checkinvalue].listOfLanes.Length; y++)
                    {
                        
                        myGroup[checkinvalue].listOfLanes[y].keepmoving();


                    }


                }
                

            
          }
           
            return true;
        }
        
        
       /// <summary>
       /// This method will be used to adjust the time of the green light 
       /// </summary>
       /// <param name="group">The name of the group</param>
       /// <param name="time">The time it is being adjusted to</param>
        public void AdjustTime(string group,int time)
        {
           // find the  group and set the time length
        }
       /// <summary>
        /// This method will be used to adjust the number of cars in a lane 
       /// </summary>
       /// <param name="laneNo">The position of lane in the list whose number of cars is being adjusted</param>
       /// <param name="car">The number of cars the lane is being adjusted to</param>
        public void AdjustNrOfCars(int laneNo, int car)
        {
            //finds the lane from list and set number of cars
        }
       /// <summary>
       /// This method removes a car from a given lane
       /// </summary>
       /// <param name="l">The lane with the car that is to be removed</param>
        public void removeCar(Lane l)
        {
            
        }
       /// <summary>
       /// This method paints a crossing object
       /// </summary>
       /// <param name="gr">The graphics to that the crossing should be painted on</param>
        public void paintSelf(Graphics gr)
        {

            gr.DrawImage(crossingimg, crossingrect);
            for (int i = 0; i < listOfLanes.Count; i++)
            {

                listOfLanes[i].paintSelf(gr);

               
            }
           
        }
       /// <summary>
       /// This method paint a crossing on separate graphics than the traffic
       /// </summary>
        /// <param name="gr">The graphics to that the crossing should be painted on</param>
       /// <param name="x"> the size that every parameter of the objects should change</param>
        public void paintBigger(Graphics gr, int x)
        {
            //........
        }
        /// <summary>
        /// creates 4 groups of lanes, and if type2 it adds one more
        /// </summary>
        public virtual void createGroup(Point pos)
        {
            

        }      
       /// <summary>
       /// this methods calculates the number of cars coming in from other neighbour
       /// </summary>
       /// <returns>list of cars going out in four direction</returns>
        public void NoOfOutgoingCar(string groupName)
        {
           // List<int> myincomicars = new List<int>();
           // first check if there are neighbours, then their positions
            if(groupName=="Group1" || groupName=="Group2")
            {
                if (myneighbours[3] != null)
                {
                myneighbours[3].listOfLanes[9].AddIncomingCar(1);
                myneighbours[3].listOfLanes[10].AddIncomingCar(1);
                myneighbours[3].listOfLanes[11].AddIncomingCar(1);
                }
                if(myneighbours[2]!=null)
                {
                myneighbours[2].listOfLanes[0].AddIncomingCar(1);
                myneighbours[2].listOfLanes[1].AddIncomingCar(1);
                myneighbours[2].listOfLanes[2].AddIncomingCar(1);
                }
                if(myneighbours[0]!=null)
                {
                myneighbours[0].listOfLanes[6].AddIncomingCar(1);
                myneighbours[0].listOfLanes[7].AddIncomingCar(1);
                myneighbours[0].listOfLanes[8].AddIncomingCar(1);
                }
                if (myneighbours[1] != null)
                {
                myneighbours[1].listOfLanes[3].AddIncomingCar(1);
                myneighbours[1].listOfLanes[4].AddIncomingCar(1);
                myneighbours[1].listOfLanes[5].AddIncomingCar(1);
                }
            }
            if (groupName == "Group3")
            {
                if (myneighbours[3] != null)
                {
                    myneighbours[3].listOfLanes[9].AddIncomingCar(1);
                    myneighbours[3].listOfLanes[10].AddIncomingCar(1);
                    myneighbours[3].listOfLanes[11].AddIncomingCar(1);
                }
                if (myneighbours[2] != null)
                {
                    myneighbours[2].listOfLanes[0].AddIncomingCar(1);
                    myneighbours[2].listOfLanes[1].AddIncomingCar(1);
                    myneighbours[2].listOfLanes[2].AddIncomingCar(1);
                }
                if (myneighbours[0] != null)
                {
                    myneighbours[0].listOfLanes[6].AddIncomingCar(1);
                    myneighbours[0].listOfLanes[7].AddIncomingCar(1);
                    myneighbours[0].listOfLanes[8].AddIncomingCar(1);
                }
                
            }
            if (groupName == "Group4")
            {
                if (myneighbours[3] != null)
                {
                    myneighbours[3].listOfLanes[9].AddIncomingCar(1);
                    myneighbours[3].listOfLanes[10].AddIncomingCar(1);
                    myneighbours[3].listOfLanes[11].AddIncomingCar(1);
                }
                if (myneighbours[2] != null)
                {
                    myneighbours[2].listOfLanes[0].AddIncomingCar(1);
                    myneighbours[2].listOfLanes[1].AddIncomingCar(1);
                    myneighbours[2].listOfLanes[2].AddIncomingCar(1);
                }
                if (myneighbours[1] != null)
                {
                    myneighbours[1].listOfLanes[3].AddIncomingCar(1);
                    myneighbours[1].listOfLanes[4].AddIncomingCar(1);
                    myneighbours[1].listOfLanes[5].AddIncomingCar(1);
                }
            }





            
        }
        /// <summary>
        /// it divides the in coming cars according to ratio of 1:2 for 1st and 2nd lane, and the remaing  to 3rd lane
        /// </summary>
        /// <param name="incomingcars"> number of coming in to to the road</param>
        /// <param name="direction">the direction of the road</param>
       public void divideincomingCarsInRatio(int incomingcars, string direction)
       {
        //calculates where each lane are and add cars according to ratio
       }
       /// <summary>
       /// returns the rectangle where the crossing is found
       /// </summary>
       /// <returns>rectangle</returns>

       public Rectangle GetRectangle()
       {
           return this.crossingrect;
       }
    }
}
