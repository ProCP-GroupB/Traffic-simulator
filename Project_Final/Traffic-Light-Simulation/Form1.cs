using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Traffic_Light_Simulation
{
   
    public partial class TrafficSimulation_GUI : Form
    {
        Graphics ourgr;
        Simulation ourtraffic;
        
        Point ptclicked; //to select a point clicked
        Point pointselected;
        Rectangle workingrect;
        bool rectangleisselected = false;  // for painting purpose
        bool simulationRunning = false;  //to know either simulation is running or not
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        int index = 0;

        float scaleFactor = 1.5f;       // Scale factor for the zooming.

       //private PictureBox[] pb = new PictureBox[1];
                               
        public TrafficSimulation_GUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            ourtraffic = new Simulation("CSharp City");
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(button1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void combo_TrafficLight_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (combo_TrafficLight.Text == "TL_P")
                txt_Yellow.Enabled = false;
            else txt_Yellow.Enabled = true;*/
        }

        private void combo_TrafficLight_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_TrafficLight_DropDown(object sender, EventArgs e)
        {

           // combo_TrafficLight.Items.Clear();
           /* if (combo_CrossingType.Text == "Type Of Crossing")
            {
                combo_TrafficLight.Items.Clear();

                combo_TrafficLight.Text = "Traffic Light";
            }
            else
            {
                combo_TrafficLight.Items.Add("TL_1");
                combo_TrafficLight.Items.Add("TL_2");
                combo_TrafficLight.Items.Add("TL_3");
                combo_TrafficLight.Items.Add("TL_4");
                if (combo_CrossingType.Text == "With Pedestrians")
                {
                    combo_TrafficLight.Items.Add("TL_P");
                }
            }
            */
        }

        private void tab_Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void tab_Edit_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Radio_Custom_CheckedChanged(object sender, EventArgs e)
        {
            /*if (Radio_Custom.Checked)
            {
                group_Edit.Visible = true;
            }
            else
                group_Edit.Visible = false;*/
        }

        private void withPedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!simulationRunning)
            {
                if (rectangleisselected == true)
                {
                    Crossing mycrossing = new Crossing_WithPedestarian(workingrect, OurtrafficImages.Images[1],"with-pedestrian");

                    if (ourtraffic.addCrossing(mycrossing, pointselected))

                        OurTrafficPBox.Invalidate();
                    else
                        MessageBox.Show("the selected area have crossing, please select other place");
                    // OurTrafficPBox.Refresh();
                }
                else
                    MessageBox.Show("select a place first");
            }

            else
            {
                MessageBox.Show("Simulation is Running,Stop it First");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            simulationRunning = true;
            timertraffic.Enabled = true;
            GroupTimer.Enabled = true;         

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {     
            ourgr = e.Graphics;
            Pen myblackpen = new Pen(Color.Black);
            myblackpen.Width = 3;
            
            for (int x = 0; x < ourtraffic.myrectangles.Length; x++)
            {               
                ourgr.DrawRectangles(myblackpen,ourtraffic.myrectangles);              
            }

            //to paint the seletion
            if(rectangleisselected==true)
            {
                Pen myselctionpen = new Pen(Color.Aqua);
                myselctionpen.Width = 3;
                ourgr.DrawRectangle(myselctionpen, workingrect);
            }
            
            // to paint the crossing
             ourtraffic.paintAllCrossing(ourgr);
            //ourgr.DrawImage(OurtrafficImages.Images[0], workingrect.Location);            
           
        }

        private void TrafficSimulation_Load(object sender, EventArgs e)
        {

        }
        
        public void save() { }
        public void open() { }
        public void New() {}

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void OurTrafficPBox_MouseClick(object sender, MouseEventArgs e)
        {
            ptclicked.X = e.X;
            ptclicked.Y = e.Y;
            pointselected = Findpos();
            workingrect = ourtraffic.getRectangle(pointselected);
            rectangleisselected = true;

            OurTrafficPBox.Invalidate();
           // OurTrafficPBox.Refresh();

        }

        /// <summary>
        /// return the rectangle position
        /// </summary>
        /// <returns>pointer</returns>
        public Point Findpos()
        {
            Point pt = new Point();
            pt.X = ((ptclicked.X / 200) * 200)+5;
            pt.Y = ((ptclicked.Y / 200) * 200)+5;
            return pt;

        }

        private void withoutPedestrianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!simulationRunning)
            {
                if (rectangleisselected == true)
                {
                    Crossing mycrossing = new Crossing_withoutPedestarian(workingrect, OurtrafficImages.Images[0],"without-pedestrian");

                    if (ourtraffic.addCrossing(mycrossing, pointselected))

                        OurTrafficPBox.Invalidate();
                    else
                        MessageBox.Show("the selected area have crossing, please select other place");
                    // OurTrafficPBox.Refresh();

                }

                else
                    MessageBox.Show("select a place first");

            }
            else
            {
                MessageBox.Show("Simulation is Running,Stop it First");
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (!simulationRunning)
            {
                if (rectangleisselected == true)
                {
                    for (int x = 0; x < ourtraffic.traficsrossings.Count; x++)
                    {
                        if (ourtraffic.removeCrossing(workingrect.Location))
                        {

                            OurTrafficPBox.Invalidate();
                        }
                        else
                            MessageBox.Show("there is no crossing in this area!");
                    }
                }
                else
                    MessageBox.Show("select a crossing first!!");

            }
            else
            {
                MessageBox.Show("Simulation is Running,Stop it First");
        }
        
       }

        private void btn_Stop_simulation_Click(object sender, EventArgs e)
        {
            simulationRunning = false;
            timertraffic.Enabled = false;
        }

        private void OurTrafficPBox_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
           ourtraffic.startSimulation(index);           

           OurTrafficPBox.Invalidate();
                     
           

        }

        private void Grouptimer_Tick(object sender, EventArgs e)
        {
           
        
        }

        private void GroupTimer_Tick_1(object sender, EventArgs e)
        {

            for (int x = 0; x < ourtraffic.traficsrossings.Count; x++)
            {
                if (index + 1 <= ourtraffic.traficsrossings[x].myGroup.Count)
                {
                  GroupTimer.Interval = ourtraffic.traficsrossings[x].myGroup[index].getinterval();
                }

            }
            index = (++index) % 5;
        }

        private void zoomPB_Paint(object sender, PaintEventArgs e)
        {
            // Grab the graphicz.
            Graphics ourzoomgr = e.Graphics;
            
            // Draw the traffic light at scalez.
            ourtraffic.drawZoom(ourzoomgr, this.pointselected, scaleFactor);
        
            this.Text = this.pointselected.ToString();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
        //Window Movement Events------------------------------------------------------------------------------------------
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_Move(object sender, EventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
