using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCp_Traffic_simulation
{
    public partial class Form2 : Form
    {
        public Form1 OriginalForm { get; set; }
        public int pbNumber;

        public Form2()
        {
            InitializeComponent();
            pbCrossing1.ImageLocation = "Crossings/Crossing1.png";
            pbCrossing2.ImageLocation = "Crossings/Crossing2.png";
        }
      
        private void pbCrossing1_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
                OriginalForm.SetPictureBoxPicture(1, pbNumber);
            this.Close();
        }

        private void pbCrossing2_Click(object sender, EventArgs e)
        {
            if (OriginalForm != null)
                OriginalForm.SetPictureBoxPicture(2, pbNumber);
            this.Close();
        }
    }
}
