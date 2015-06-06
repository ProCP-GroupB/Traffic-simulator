using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace ProCp_Traffic_simulation
{
    public class TrafficLight
    {
        //private Point position;
        private int greenTime;
        public int x, y, width, height;
        Rectangle[] rectangles = new Rectangle[1];
        private Rectangle lights;
        public SolidBrush b;
        LightColor light;
        Graphics gr;
        Bitmap DrawArea = new Bitmap(150, 150);
        
        public TrafficLight(int x, int y, int width, int height, int GreenTime)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.greenTime = GreenTime;
            b = new SolidBrush(Color.Red);
            this.lights = new Rectangle(x, y, width, height);
        }
        /// <summary>
        /// Changes the color of the light
        /// </summary>
        public void painttoRed()
        {
            this.b = new SolidBrush(Color.Red);
            light=LightColor.Red;
        }
        
        public void paintgreen()
        {
            this.b = new SolidBrush(Color.Green);
            light = LightColor.Green;
        }


        /// <summary>
        /// Sets a new value to the 'greenTime'  variable
        /// </summary>
        public void ChangeGreenTime( int GreenTime)
        {
            this.greenTime = GreenTime;
        }
    }
}
