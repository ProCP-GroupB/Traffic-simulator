using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Rectangle myRect;
        Car myCar;
        Thread carTest;
        Graphics gr;

        public Form1()
        {
            InitializeComponent();

            DrawArea = new Bitmap(pbTile1.Size.Width, pbTile1.Size.Height);
            pbTile1.Image = DrawArea;
            
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
                    break;
                case 2:
                    if (picture == 1) this.pbTile2.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile2.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 3:
                    if (picture == 1) this.pbTile3.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile3.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 4:
                    if (picture == 1) this.pbTile4.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile4.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 5:
                    if (picture == 1) this.pbTile5.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile5.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 6:
                    if (picture == 1) this.pbTile6.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile6.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 7:
                    if (picture == 1) this.pbTile7.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile7.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 8:
                    if (picture == 1) this.pbTile8.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile8.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 9:
                    if (picture == 1) this.pbTile9.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile9.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 10:
                    if (picture == 1) this.pbTile10.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile10.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 11:
                    if (picture == 1) this.pbTile11.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile11.ImageLocation = "Crossings/Crossing2.png";
                    break;
                case 12:
                    if (picture == 1) this.pbTile12.ImageLocation = "Crossings/Crossing1.png";
                    else this.pbTile12.ImageLocation = "Crossings/Crossing2.png";
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
            //foreach (var pictureBox in Controls.OfType<PictureBox>())
            //{
            //    if (pictureBox.Tag == null) // you can skip other pictureBoxes
            //        continue;
            //    List<Crossing> c = new List<Crossing>();// (pictureBox.Image);
            //    c.Add(pictureBox.Image);
            //    Simulation.AddCrossing(c);
             
            //}
            //if (Simulation.simulationRunning = false)
            //{
            //    Simulation.Start();
            //}
            //else
            //    MessageBox.Show("Simulation is running");


            //TESTING CAR MOVEMENT
            myRect = new Rectangle(8, 77, 8, 8);
            myCar = new Car(Direction.West, myRect);
            timerTest.Start();
            ThreadStart thRef = new ThreadStart(myCar.Move);
            carTest = new Thread(thRef);

            carTest.Start();
        }

        private void btnCrossings_Click(object sender, EventArgs e)
        {

        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (!myCar.toStop)
            {
                gr = Graphics.FromImage(DrawArea);
                gr.Clear(Color.Transparent);
                gr = Graphics.FromImage(DrawArea);
                //gr.DrawEllipse(Brushes.Black, );
                gr.FillEllipse(Brushes.Black, myCar.rect);

                pbTile1.Invalidate();
            }
        }


    }
}
