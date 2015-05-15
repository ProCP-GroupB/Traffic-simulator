namespace ProCp_Traffic_simulation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCrossing1 = new System.Windows.Forms.PictureBox();
            this.pbCrossing2 = new System.Windows.Forms.PictureBox();
            this.labelselectCrossing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossing2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCrossing1
            // 
            this.pbCrossing1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCrossing1.Image = global::ProCp_Traffic_simulation.Properties.Resources.Crossing1;
            this.pbCrossing1.Location = new System.Drawing.Point(26, 70);
            this.pbCrossing1.Name = "pbCrossing1";
            this.pbCrossing1.Size = new System.Drawing.Size(163, 127);
            this.pbCrossing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrossing1.TabIndex = 0;
            this.pbCrossing1.TabStop = false;
            this.pbCrossing1.Click += new System.EventHandler(this.pbCrossing1_Click);
            // 
            // pbCrossing2
            // 
            this.pbCrossing2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbCrossing2.Image = global::ProCp_Traffic_simulation.Properties.Resources.Crossing2;
            this.pbCrossing2.Location = new System.Drawing.Point(264, 70);
            this.pbCrossing2.Name = "pbCrossing2";
            this.pbCrossing2.Size = new System.Drawing.Size(163, 127);
            this.pbCrossing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrossing2.TabIndex = 1;
            this.pbCrossing2.TabStop = false;
            this.pbCrossing2.Click += new System.EventHandler(this.pbCrossing2_Click);
            // 
            // labelselectCrossing
            // 
            this.labelselectCrossing.AutoSize = true;
            this.labelselectCrossing.Location = new System.Drawing.Point(135, 9);
            this.labelselectCrossing.Name = "labelselectCrossing";
            this.labelselectCrossing.Size = new System.Drawing.Size(185, 13);
            this.labelselectCrossing.TabIndex = 2;
            this.labelselectCrossing.Text = "Select one of the following crossings :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 226);
            this.Controls.Add(this.labelselectCrossing);
            this.Controls.Add(this.pbCrossing2);
            this.Controls.Add(this.pbCrossing1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossing2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCrossing1;
        private System.Windows.Forms.PictureBox pbCrossing2;
        private System.Windows.Forms.Label labelselectCrossing;
    }
}