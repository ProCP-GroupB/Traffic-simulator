﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;

namespace Traffic_Light_Simulation
{
    class Car
    {
        public Point pos;
        private int speed;
        private Color color;
        private Rectangle myrectangle = new Rectangle();
        int laneNumber;
        
        private delegate void UpdatePictureBoxCallback(Point p);
        /// <summary>
        /// This is the constuctor of the class MovingObject
        /// </summary>
        public Car(Point p, int lanenum)
        {
           this.color = Color.Green;
           this.laneNumber = lanenum;
            pos = p;
          
        }

        /// <summary>
        /// This method is responsible for moving the car objects
        /// </summary>
        /// <param name="postToDrawObject">The initial position of the object before it is moved</param>
        /// <param name="speed">The speed at which the object should be moved</param>
        public void move(Point pos)   //int speed
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method paints the moving objects on a graphics
        /// </summary>
        /// <param name="gr">The graphics on which the objects should be painted</param>
        public void paintSelf(Graphics gr)
        {
            int width = 8;
            int height = 8;
            Size s = new Size(width, height);
            
            myrectangle = new Rectangle(pos, s);
                
            gr.FillEllipse(Brushes.Black, myrectangle);
   
        }

        /// <summary>
        /// Sets the new position of the car
        /// </summary>
        /// <param name="newp"></param>
        public void setPosition(Point newp)
        {
            this.pos = newp;
        }

        /// <summary>
        /// This method stops a moving Car
        /// </summary>
        public void stop()
        {
            throw new NotImplementedException();
        }

    }
}
