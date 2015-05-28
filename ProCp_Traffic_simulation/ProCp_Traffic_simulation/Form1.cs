using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProCp_Traffic_simulation
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        List<Bitmap> drawArea = new List<Bitmap>();
        Rectangle myRect;
        Car myCar;
        Thread carTest;
        
        Graphics gr;
        List<PictureBox> activatedpb;
        Simulation simulation;
        Stopwatch stopWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            DrawArea = new Bitmap(pbTile1.Size.Width, pbTile1.Size.Height);
           // pbTile1.Image = DrawArea;
            activatedpb = new List<PictureBox>();
        }

        public FileHelper FileHelper
        { 
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Simulation Simulation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SetPictureBoxPicture(int picture, int pbNumber)
        { //Sets the desired picture to the desired pbox
            switch (pbNumber)
            {
                case 1:
                    if(picture == 1) this.pbTile1.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile1.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile1);
                    break;
                case 2:
                    if (picture == 1) this.pbTile2.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    else this.pbTile2.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile2);
                    break;
                case 3:
                    if (picture == 1) this.pbTile3.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile3.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile3);
                    break;
                case 4:
                    if (picture == 1) this.pbTile4.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile4.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile4);
                    break;
                case 5:
                    if (picture == 1) this.pbTile5.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile5.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile5);
                    break;
                case 6:
                    if (picture == 1) this.pbTile6.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile6.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile6);
                    break;
                case 7:
                    if (picture == 1) this.pbTile7.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile7.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile7);
                    break;
                case 8:
                    if (picture == 1) this.pbTile8.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile8.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile8);
                    break;
                case 9:
                    if (picture == 1) this.pbTile9.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile9.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile9);
                    break;
                case 10:
                    if (picture == 1) this.pbTile10.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile10.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile10);
                    break;
                case 11:
                    if (picture == 1) this.pbTile11.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile11.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile11);
                    break;
                case 12:
                    if (picture == 1) this.pbTile12.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing1;
                    else this.pbTile12.BackgroundImage = ProCp_Traffic_simulation.Properties.Resources.Crossing2;
                    activatedpb.Add(pbTile12);
                    break;
                default:
                    MessageBox.Show("Something went wrong");
                    break;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        //----------------------------------Pressing the pictureBoxes---------------------------------------------------------
        private void pbTile1_Click(object sender, EventArgs e)
        {//Send activation and the same instance of Form1 to Form2 
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 1;
            frm.Show();
        }
        private void pbTile2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 2;
            frm.Show();
        }
        private void pbTile3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 3;
            frm.Show();
        }
        private void pbTile4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 4;
            frm.Show();
        }
        private void pbTile5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 5;
            frm.Show();
        }
        private void pbTile6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 6;
            frm.Show();
        }
        private void pbTile7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 7;
            frm.Show();
        }
        private void pbTile8_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 8;
            frm.Show();
        }
        private void pbTile9_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 9;
            frm.Show();
        }
        private void pbTile10_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 10;
            frm.Show();
        }
        private void pbTile11_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 11;
            frm.Show();
        }
        private void pbTile12_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.OriginalForm = this;
            frm.pbNumber = 12;
            frm.Show();
        }

        private void tbTraffic_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)

        {
            stopWatch.Start();
            
            foreach (PictureBox p in activatedpb)
            {
                p.Image = DrawArea;
                //DrawArea = new Bitmap(p.Size.Width, p.Size.Height);
                //drawArea.Add(DrawArea);

                simulation = new Simulation();
                Crossing crossing = new Crossing(p.BackgroundImage);
                simulation.AddCrossing(crossing);
                myRect = new Rectangle(8, 77, 8, 8);
                myCar = new Car(Direction.West, myRect);
                timerTest.Start();
                ThreadStart thRef = new ThreadStart(myCar.Move);
                carTest = new Thread(thRef);

                carTest.Start();
            }
            if (simulation.simulationRunning == false)
            {
                simulation.Start();
            }
            else
                MessageBox.Show("Simulation is running");

            //TESTING CAR MOVEMENT          
        }

        private void btnCrossings_Click(object sender, EventArgs e)
        {

        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (!myCar.toStop)
            {
                label1.Text = "" + stopWatch.Elapsed;
                gr = Graphics.FromImage(DrawArea);
                gr.Clear(Color.Transparent);
                gr = Graphics.FromImage(DrawArea);
                //gr.DrawEllipse(Brushes.Black, );
                gr.FillEllipse(Brushes.Black, myCar.rect);

                foreach (PictureBox p in activatedpb)
                {
                    p.Invalidate();
                }
            }
            else
            {
             stopWatch.Stop();
             stopWatch.Reset();
            }             
        }


    }
}
