using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Traffic_Light_Simulation
{
    class Traffic_light
    {
        Color[] color;
       
        Point position; //x and y axisposition
        private int greenlength;
        int x, y, width, height;
        SolidBrush b;
        Rectangle tl;
        /// <summary>
        /// creates a light object
        /// </summary>
        /// <param name="pos">position of light on lane</param>
        public Traffic_light(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            b = new SolidBrush(Color.Red);
            tl = new Rectangle(x, y, width, height);
        }

        /// <summary>
        /// paints the color green in the top of the light
        /// </summary>
        public void paintgreen()
        {
            this.b = new SolidBrush(Color.Green);

        }
        /// <summary>
        /// paintsthe color yellow in the middle of light
        /// </summary>
        public void painttoYellow()
        {
            //checks the timer 
            //paints yellow color
        }
        /// <summary>
        /// paints red in the bottom of light
        /// </summary>
        public void painttoRed()
        {
            b = new SolidBrush(Color.Red);
        }
        /// <summary>
        /// calls all paint methods in step first green, yellow, then red
        /// </summary>
        /// <param name="gr"></param>
        public void paintItself(Graphics gr)
        {
            Pen p = new Pen(Brushes.Black);
            

            //gr.DrawRectangle(p, tl);
            gr.FillEllipse(b, tl); 
        }
        /// <summary>
        /// this the length of green paint other than yellow
        /// </summary>
        /// <param name="len"></param>
        public void SetGreenLength(int len)
        {
            //set length value
        }

    }
}
