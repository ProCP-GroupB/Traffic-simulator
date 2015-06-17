using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Traffic_Light_Simulation
{
    class Simulation
    {
        public List<Crossing> traficsrossings = new List<Crossing>();
        public Rectangle[] myrectangles = new Rectangle [12];
        String name;
        Timer timer = new Timer();
          
        
        /// <summary>
        /// This is the constructor of the traffic class
        /// </summary>
        /// <param name="crossings">This is the list of crossings contained in a traffic simulation</param>
        public Simulation(String nm)
        {
            this.name = nm;
            int initialX = 5;
            int initialY = 5;
            int width = 200;
            int height = 200;
            Size s = new Size(width, height);
            int i = 0; //number of rectangles
            for(int y=0; y<3; y++)
            {
                for (int x = 0; x<4; x++)
                {
                    Point pt = new Point(initialX, initialY);
                    myrectangles[i] = new Rectangle(pt, s);
                    i++;
                    initialX += 200;
                }
                initialY += 200;
                initialX = 5;
                
            }
        }
        

        /// <summary>
        /// This method will be called to add a crossing to the traffic system
        /// </summary>
        /// <param name="position">The position of the crossing tht the user wants to place the crossing</param>
        /// <returns>returns true if the crossing is successfully added and false otherwise</returns>
        
        
        public bool addCrossing(Crossing crossing, Point pt)
        {
            if (traficsrossings.Count == 0)
            {
                traficsrossings.Add(crossing);
               
                return true;
            }
            else
            {
                int size=traficsrossings.Count;
                for (int x = 0; x < size; x++)
                {
                    if (pt == traficsrossings[x].GetRectangle().Location)
                    {
                       // MessageBox.Show("the selected area have crossing, please select other place");
                       return false;
                    }
                }

               traficsrossings.Add(crossing);
               findNeighbour(crossing);
               return true;
            }
        }

        /// <summary>
        /// This method removes a crossing from the traffic system 
        /// </summary>
        /// <param name="position">The position where the crossing that shouldbe removed is</param>
        /// <returns>returns true if the crossing is successfully removed and false otherwise</returns>
        public bool removeCrossing(Point position)
        {
           // calculatePosition(position);
            bool removed = false;
            for (int x = 0; x < traficsrossings.Count; x++ )
            {
              if(position==traficsrossings[x].crossingrect.Location)
              {
                  traficsrossings.Remove(traficsrossings[x]);
                  removed= true;
              }
              
            }
            return removed;
            
        }
        /// <summary>
        /// This method is called to start the simulation i.e,the cars start moving,the traffic lights start controlling..etc 
        /// </summary>
        public void startSimulation(int index)
        {
            for (int x = 0; x < traficsrossings.Count; x++)
            {
                traficsrossings[x].BeGreen(index);
            }
        }
        /// <summary>
        /// This method will be called to stop a simulation that is running
        /// </summary> 
        public void stopSimulation()
        {            
        }
         
        /// <summary>
        /// This method saves the statistics about a specific simulation,the statistics will be saved in notepad
        /// </summary>
        /// <returns>The method returns true if the statistics were succesfully saved and false otherwise</returns>
        public bool saveStatistics()
        {
            return true;
        }

        /// <summary>
        /// This method is called to show the statistics that had initially been saved
        /// </summary>
        public void showStatistics()
        {
        }

        /// <summary>
        /// This method will be used to adjust the time for a particular traffic light
        /// </summary>
        /// <param name="point">This is the position of the traffic light that the user wants to adjust</param>
        /// <param name="value">This is the length of green time </param>
        /// <param name="group">This is the name of the group which the time is to be set</param>
       
        public void  adjustCrossingLight(Point position, int value, string group)
        {
            //listOfCrossings[position].AdjustTime(group, value);
        }

        /// <summary>
        /// This method will be used to adjust the car for a particular lane
        /// </summary>
        /// <param name="point">This is the position of the traffic light that the user wants to adjust</param>
        /// <param name="value">This is the number of cars on the lane </param>
        /// <param name="point">This is the position of the lane in the list where cars is to be set</param>
        public void adjustCrossingCar(Point position, int value, int lane)
        {
            // listOfCrossings[position].AdjustNrOfCars(Lane tobeedited, value);
        }

        /// <summary>
        /// This method will be used to increase the size of the objects in a simulation
        /// </summary>
        /// <param name="point">The position provided by the user of the objects that should be increased</param>
        public void maximize(Point point)
        {
            calculatePosition(point);
        } 

        /// <summary>
        /// This method will be used to find the position of a point(that the user provides) on the grid 
        /// </summary>
        /// <param name="point">The point selected by the user</param>
        /// <returns>The calculated position (start point of a cell) on the grid is retuned </returns>
        public Point calculatePosition(Point point)
        {
            Point calculatedPoint=point;
            return point;
        }

        public bool checkOverlap(Point point)
        {
            calculatePosition(point);
            return false;
        }

        public void highlightSelectedCell(Point point)
        {
            calculatePosition(point);
        }

        /// <summary>
        /// This method paints the list of crossings
        /// </summary>
        /// <param name="gr">The graphics on which the crossings will be painted</param>
        public void paintAllCrossing(Graphics gr)
        {
            for (int x = 0; x < traficsrossings.Count; x++)
            {
                traficsrossings[x].paintSelf(gr);
            }
          
        }

        /// <summary>
        /// a method which checks the neighbours of a given crossing corresponding to their direction
        /// </summary>
        /// <param name="currentCrossing"> the crossing which its neighbours are to be found</param>
        /// <returns>a number of crossing which are neighbours to the parameter crossing</returns>
        public void findNeighbour(Crossing currentCrossing)
        {
            
            for (int x = 0; x < traficsrossings.Count; x++ )
            {
                //adding north
                if (currentCrossing.position.Y - currentCrossing.crossingrect.Height == traficsrossings[x].position.Y && currentCrossing.position.X == traficsrossings[x].position.X)
                {
                    currentCrossing.myneighbours.Insert(0, traficsrossings[x]);
                    // to add for the other existing neghbour
                   traficsrossings[x].myneighbours.Insert(2, currentCrossing);           
                   
                }
                //adding east
                else if (currentCrossing.position.X + currentCrossing.crossingrect.Width == traficsrossings[x].position.X && currentCrossing.position.Y == traficsrossings[x].position.Y)
                {
                    currentCrossing.myneighbours.Insert(1, traficsrossings[x]);
                   
                   traficsrossings[x].myneighbours.Insert(3, currentCrossing);
                }
                // adding south
                else if (currentCrossing.position.Y + currentCrossing.crossingrect.Height == traficsrossings[x].position.Y && currentCrossing.position.X == traficsrossings[x].position.X)
                {
                    currentCrossing.myneighbours.Insert(2, traficsrossings[x]);
                   
                    traficsrossings[x].myneighbours.Insert(0, currentCrossing);
                }
                  //  adding west
                else if (currentCrossing.position.X - currentCrossing.crossingrect.Width == traficsrossings[x].position.X && currentCrossing.position.Y == traficsrossings[x].position.Y)   
                {
                    currentCrossing.myneighbours.Insert(3, traficsrossings[x]);
                   
                   traficsrossings[x].myneighbours.Insert(1, currentCrossing);
                }
                
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentcrossing"></param>
        public void incomingAndOutgoingcar(Crossing currentcrossing)
        {
            // findNeighbour(current);
        }

        /// <summary>
        /// get the rectamgle which has same pointer with rh paramter
        /// </summary>
        /// <param name="pt">pointer</param>
        /// <returns>cell</returns>
        public Rectangle getRectangle(Point pt)
        {
            Rectangle temporect = new Rectangle();

            for (int i = 0; i < myrectangles.Length; i++)
            {
                if (myrectangles[i].Location == pt)
                {
                    return myrectangles[i];
                }

            }
            return temporect;
        }

        public void drawZoom(Graphics g, Point p, float scale)
        {
            g.ScaleTransform(scale, scale);
            
            foreach (Crossing c in traficsrossings)
            {
                if (c.position == p)
                {
                    c.paintSelf(g);
                }
            }
        }


    }
}
