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
        Traffic ourtraffic;
        
        Point ptclicked; //to select a point clicked
        Point pointselected;
        Rectangle workingrect;
        bool rectangleisselected = false;  // for painting purpose
        bool simulationRunning = false;  //to know either simulation is running or not

        int index = 0;

        float scaleFactor = 1.5f;       // Scale factor for the zooming.

       //private PictureBox[] pb = new PictureBox[1];

                               
        public TrafficSimulation_GUI()
        {
            InitializeComponent();
            ourtraffic = new Traffic("CSharp City");

            // Calculate size of zoom box.
            this.zoomPB.Height = (int)(this.OurTrafficPBox.Height * scaleFactor);
            this.zoomPB.Width = (int)(this.OurTrafficPBox.Width * scaleFactor);
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
            //must select the grid and then when condition is fullfilled
            panel_maximize.Visible = true;

            //must do the painting  X3
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel_maximize.Visible = false;
            
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
            //PictureBox[] pba = new PictureBox[10];
            string mm = "(" + e.X.ToString() + "," + e.Y.ToString() + ")";
            this.labelShow.Text = mm;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           ourtraffic.startSimulation(index);
            

            OurTrafficPBox.Invalidate();
            zoomPB.Invalidate();

            
           

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
            // Grab teh graphicz.
            Graphics ourzoomgr = e.Graphics;
            
            // Draw teh traffic light at scalez.
            ourtraffic.drawZoom(ourzoomgr, this.pointselected, scaleFactor);


            // Reposition teh box to show teh traffic light.
            this.zoomPB.Location = new Point((int)(-this.pointselected.X * scaleFactor), (int)(-this.pointselected.Y * scaleFactor));
        
            // Dehbugz
            this.Text = this.pointselected.ToString();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
