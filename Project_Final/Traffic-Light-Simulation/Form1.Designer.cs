namespace Traffic_Light_Simulation
{
    partial class TrafficSimulation_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficSimulation_GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabpages = new System.Windows.Forms.TabControl();
            this.tab_Toolbox = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.withPedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutPedestrianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label_Remove = new System.Windows.Forms.ToolStripLabel();
            this.btn_remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Maximize_Tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Start_Simulation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Stop_simulation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.Show_statistics = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_maximize = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.zoomPB = new System.Windows.Forms.PictureBox();
            this.OurTrafficPBox = new System.Windows.Forms.PictureBox();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCrossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.type2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OurtrafficImages = new System.Windows.Forms.ImageList(this.components);
            this.labelShow = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timertraffic = new System.Windows.Forms.Timer(this.components);
            this.GroupTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpages.SuspendLayout();
            this.tab_Toolbox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_maximize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OurTrafficPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Visible = false;
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.tabpages);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tabpages
            // 
            this.tabpages.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabpages.Controls.Add(this.tab_Toolbox);
            this.tabpages.Location = new System.Drawing.Point(9, 19);
            this.tabpages.Multiline = true;
            this.tabpages.Name = "tabpages";
            this.tabpages.SelectedIndex = 0;
            this.tabpages.Size = new System.Drawing.Size(1153, 78);
            this.tabpages.TabIndex = 0;
            // 
            // tab_Toolbox
            // 
            this.tab_Toolbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_Toolbox.Controls.Add(this.toolStrip1);
            this.tab_Toolbox.Location = new System.Drawing.Point(4, 25);
            this.tab_Toolbox.Name = "tab_Toolbox";
            this.tab_Toolbox.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Toolbox.Size = new System.Drawing.Size(1145, 49);
            this.tab_Toolbox.TabIndex = 0;
            this.tab_Toolbox.Text = "ToolBox";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.label_Remove,
            this.btn_remove,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.btn_Maximize_Tool,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.btn_Start_Simulation,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.btn_Stop_simulation,
            this.toolStripSeparator5,
            this.toolStripLabel6,
            this.Show_statistics,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1139, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(155, 30);
            this.toolStripLabel1.Text = "      Add Crossing           ";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withPedesToolStripMenuItem,
            this.withoutPedestrianToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 30);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // withPedesToolStripMenuItem
            // 
            this.withPedesToolStripMenuItem.Name = "withPedesToolStripMenuItem";
            this.withPedesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.withPedesToolStripMenuItem.Text = "With Pedestrian";
            this.withPedesToolStripMenuItem.Click += new System.EventHandler(this.withPedesToolStripMenuItem_Click);
            // 
            // withoutPedestrianToolStripMenuItem
            // 
            this.withoutPedestrianToolStripMenuItem.Name = "withoutPedestrianToolStripMenuItem";
            this.withoutPedestrianToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.withoutPedestrianToolStripMenuItem.Text = "Without Pedestrian";
            this.withoutPedestrianToolStripMenuItem.Click += new System.EventHandler(this.withoutPedestrianToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // label_Remove
            // 
            this.label_Remove.Enabled = false;
            this.label_Remove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Remove.Name = "label_Remove";
            this.label_Remove.Size = new System.Drawing.Size(110, 30);
            this.label_Remove.Text = "Remove Crossing";
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSize = false;
            this.btn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 30);
            this.btn_remove.Text = "Remove crossing";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Enabled = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(57, 30);
            this.toolStripLabel3.Text = "Maximize";
            // 
            // btn_Maximize_Tool
            // 
            this.btn_Maximize_Tool.AutoSize = false;
            this.btn_Maximize_Tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Maximize_Tool.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximize_Tool.Image")));
            this.btn_Maximize_Tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Maximize_Tool.Name = "btn_Maximize_Tool";
            this.btn_Maximize_Tool.Size = new System.Drawing.Size(100, 30);
            this.btn_Maximize_Tool.Text = "toolStripButton1";
            this.btn_Maximize_Tool.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Enabled = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(91, 30);
            this.toolStripLabel4.Text = "Start Simulation";
            // 
            // btn_Start_Simulation
            // 
            this.btn_Start_Simulation.AutoSize = false;
            this.btn_Start_Simulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Start_Simulation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start_Simulation.Image")));
            this.btn_Start_Simulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Start_Simulation.Name = "btn_Start_Simulation";
            this.btn_Start_Simulation.Size = new System.Drawing.Size(100, 30);
            this.btn_Start_Simulation.Text = "toolStripButton2";
            this.btn_Start_Simulation.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Enabled = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(90, 30);
            this.toolStripLabel5.Text = "Stop simulation";
            // 
            // btn_Stop_simulation
            // 
            this.btn_Stop_simulation.AutoSize = false;
            this.btn_Stop_simulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Stop_simulation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop_simulation.Image")));
            this.btn_Stop_simulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Stop_simulation.Name = "btn_Stop_simulation";
            this.btn_Stop_simulation.Size = new System.Drawing.Size(100, 30);
            this.btn_Stop_simulation.Text = "toolStripButton3";
            this.btn_Stop_simulation.Click += new System.EventHandler(this.btn_Stop_simulation_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Enabled = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(80, 15);
            this.toolStripLabel6.Text = "Show Statistic";
            // 
            // Show_statistics
            // 
            this.Show_statistics.AutoSize = false;
            this.Show_statistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Show_statistics.Image = ((System.Drawing.Image)(resources.GetObject("Show_statistics.Image")));
            this.Show_statistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Show_statistics.Name = "Show_statistics";
            this.Show_statistics.Size = new System.Drawing.Size(100, 30);
            this.Show_statistics.Text = "toolStripButton4";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.labelShow);
            this.groupBox2.Controls.Add(this.panel_maximize);
            this.groupBox2.Controls.Add(this.OurTrafficPBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 562);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traffic simulation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel_maximize
            // 
            this.panel_maximize.Controls.Add(this.button1);
            this.panel_maximize.Controls.Add(this.zoomPB);
            this.panel_maximize.Location = new System.Drawing.Point(818, 111);
            this.panel_maximize.Name = "panel_maximize";
            this.panel_maximize.Padding = new System.Windows.Forms.Padding(5);
            this.panel_maximize.Size = new System.Drawing.Size(384, 322);
            this.panel_maximize.TabIndex = 2;
            this.panel_maximize.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // zoomPB
            // 
            this.zoomPB.BackColor = System.Drawing.Color.Transparent;
            this.zoomPB.Location = new System.Drawing.Point(27, 27);
            this.zoomPB.Name = "zoomPB";
            this.zoomPB.Size = new System.Drawing.Size(885, 496);
            this.zoomPB.TabIndex = 1;
            this.zoomPB.TabStop = false;
            this.zoomPB.Paint += new System.Windows.Forms.PaintEventHandler(this.zoomPB_Paint);
            // 
            // OurTrafficPBox
            // 
            this.OurTrafficPBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OurTrafficPBox.Location = new System.Drawing.Point(13, 19);
            this.OurTrafficPBox.Name = "OurTrafficPBox";
            this.OurTrafficPBox.Size = new System.Drawing.Size(885, 531);
            this.OurTrafficPBox.TabIndex = 0;
            this.OurTrafficPBox.TabStop = false;
            this.OurTrafficPBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.OurTrafficPBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.OurTrafficPBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OurTrafficPBox_MouseClick);
            this.OurTrafficPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurTrafficPBox_MouseMove);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New ";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem1.Text = "Save As";
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem2.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // showStatisticToolStripMenuItem
            // 
            this.showStatisticToolStripMenuItem.Name = "showStatisticToolStripMenuItem";
            this.showStatisticToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showStatisticToolStripMenuItem.Text = "Toolbox";
            // 
            // customzeToolStripMenuItem
            // 
            this.customzeToolStripMenuItem.Name = "customzeToolStripMenuItem";
            this.customzeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customzeToolStripMenuItem.Text = "Customze";
            // 
            // addCrossingToolStripMenuItem
            // 
            this.addCrossingToolStripMenuItem.Name = "addCrossingToolStripMenuItem";
            this.addCrossingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addCrossingToolStripMenuItem.Text = "Add Crossing";
            // 
            // type1ToolStripMenuItem
            // 
            this.type1ToolStripMenuItem.Name = "type1ToolStripMenuItem";
            this.type1ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.type1ToolStripMenuItem.Text = "Type 1";
            // 
            // type2ToolStripMenuItem
            // 
            this.type2ToolStripMenuItem.Name = "type2ToolStripMenuItem";
            this.type2ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.type2ToolStripMenuItem.Text = "Type 2";
            // 
            // starSimulationToolStripMenuItem
            // 
            this.starSimulationToolStripMenuItem.Name = "starSimulationToolStripMenuItem";
            this.starSimulationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.starSimulationToolStripMenuItem.Text = "Delete Crossing";
            // 
            // OurtrafficImages
            // 
            this.OurtrafficImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OurtrafficImages.ImageStream")));
            this.OurtrafficImages.TransparentColor = System.Drawing.Color.Transparent;
            this.OurtrafficImages.Images.SetKeyName(0, "zoomType1.fw.png");
            this.OurtrafficImages.Images.SetKeyName(1, "RoadType2.fw.png");
            this.OurtrafficImages.Images.SetKeyName(2, "zoomType1.fw.png");
            this.OurtrafficImages.Images.SetKeyName(3, "zoomType2.fw.png");
            this.OurtrafficImages.Images.SetKeyName(4, "RoadType1.fw.png");
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(914, 31);
            this.labelShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 13);
            this.labelShow.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timertraffic
            // 
            this.timertraffic.Interval = 10;
            this.timertraffic.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GroupTimer
            // 
            this.GroupTimer.Interval = 5000;
            this.GroupTimer.Tick += new System.EventHandler(this.GroupTimer_Tick_1);
            // 
            // TrafficSimulation_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1214, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrafficSimulation_GUI";
            this.Text = "Traffic Simulation";
            this.Load += new System.EventHandler(this.TrafficSimulation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabpages.ResumeLayout(false);
            this.tab_Toolbox.ResumeLayout(false);
            this.tab_Toolbox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_maximize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OurTrafficPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabpages;
        private System.Windows.Forms.TabPage tab_Toolbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox OurTrafficPBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem withPedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem withoutPedestrianToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_remove;
        private System.Windows.Forms.ToolStripLabel label_Remove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btn_Maximize_Tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_Start_Simulation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btn_Stop_simulation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton Show_statistics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCrossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem type2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starSimulationToolStripMenuItem;
        private System.Windows.Forms.ImageList OurtrafficImages;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timertraffic;
        private System.Windows.Forms.Timer GroupTimer;
        private System.Windows.Forms.Panel panel_maximize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox zoomPB;
    }
}

