namespace Interactive_Hexabitz_Modules_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testBTN = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.blueTB = new MetroFramework.Controls.MetroTrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.greenTB = new MetroFramework.Controls.MetroTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.redTB = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.intensityTB = new MetroFramework.Controls.MetroTrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ledToggle = new MetroFramework.Controls.MetroToggle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.timeoutTB = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.relayToggle = new MetroFramework.Controls.MetroToggle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.destinationID_N = new System.Windows.Forms.NumericUpDown();
            this.sourceID_N = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.baudRateCB = new MetroFramework.Controls.MetroComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationID_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceID_N)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 730);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Powerd by ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "COM";
            // 
            // COM
            // 
            this.COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.COM.Location = new System.Drawing.Point(96, 688);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(60, 36);
            this.COM.TabIndex = 50;
            this.COM.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Interactive_Hexabitz_Modules_GUI.Properties.Resources.colored_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(762, 713);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // testBTN
            // 
            this.testBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testBTN.Location = new System.Drawing.Point(16, 730);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(140, 28);
            this.testBTN.Style = MetroFramework.MetroColorStyle.Yellow;
            this.testBTN.TabIndex = 64;
            this.testBTN.Text = "Test Connection";
            this.testBTN.UseSelectable = true;
            this.testBTN.UseStyleColors = true;
            this.testBTN.Click += new System.EventHandler(this.TestBTN_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(41, 88);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(770, 552);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 79;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.label8);
            this.metroTabPage1.Controls.Add(this.blueTB);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.greenTB);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.redTB);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.intensityTB);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.ledToggle);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(762, 510);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "RGB LED";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(345, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 25);
            this.metroLabel2.TabIndex = 92;
            this.metroLabel2.Text = "H01R00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(273, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 29);
            this.label8.TabIndex = 89;
            this.label8.Text = "Blue:";
            // 
            // blueTB
            // 
            this.blueTB.BackColor = System.Drawing.Color.Transparent;
            this.blueTB.Location = new System.Drawing.Point(378, 412);
            this.blueTB.Name = "blueTB";
            this.blueTB.Size = new System.Drawing.Size(140, 23);
            this.blueTB.SmallChange = 10;
            this.blueTB.TabIndex = 88;
            this.blueTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueTB_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(273, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 29);
            this.label7.TabIndex = 87;
            this.label7.Text = "Green:";
            // 
            // greenTB
            // 
            this.greenTB.BackColor = System.Drawing.Color.Transparent;
            this.greenTB.Location = new System.Drawing.Point(378, 375);
            this.greenTB.Name = "greenTB";
            this.greenTB.Size = new System.Drawing.Size(140, 23);
            this.greenTB.SmallChange = 10;
            this.greenTB.TabIndex = 86;
            this.greenTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenTB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(273, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "Red:";
            // 
            // redTB
            // 
            this.redTB.BackColor = System.Drawing.Color.Transparent;
            this.redTB.Location = new System.Drawing.Point(378, 337);
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(140, 23);
            this.redTB.SmallChange = 10;
            this.redTB.TabIndex = 84;
            this.redTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedTB_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(273, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = "Intensity:";
            // 
            // intensityTB
            // 
            this.intensityTB.BackColor = System.Drawing.Color.Transparent;
            this.intensityTB.Location = new System.Drawing.Point(378, 452);
            this.intensityTB.Name = "intensityTB";
            this.intensityTB.Size = new System.Drawing.Size(140, 23);
            this.intensityTB.SmallChange = 10;
            this.intensityTB.TabIndex = 82;
            this.intensityTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IntensityTB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(314, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 81;
            this.label6.Text = "LED:";
            // 
            // ledToggle
            // 
            this.ledToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ledToggle.Location = new System.Drawing.Point(403, 254);
            this.ledToggle.Name = "ledToggle";
            this.ledToggle.Size = new System.Drawing.Size(92, 34);
            this.ledToggle.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ledToggle.TabIndex = 80;
            this.ledToggle.Text = "Off";
            this.ledToggle.UseSelectable = true;
            this.ledToggle.CheckedChanged += new System.EventHandler(this.LedToggle_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Interactive_Hexabitz_Modules_GUI.Properties.Resources.h01r00_photo_top;
            this.pictureBox2.Location = new System.Drawing.Point(281, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.label11);
            this.metroTabPage2.Controls.Add(this.timeoutTB);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.relayToggle);
            this.metroTabPage2.Controls.Add(this.pictureBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(762, 510);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Solid State Relay";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(348, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 25);
            this.metroLabel1.TabIndex = 93;
            this.metroLabel1.Text = "H0FR6X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(248, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 29);
            this.label11.TabIndex = 83;
            this.label11.Text = "Timeout(ms):";
            // 
            // timeoutTB
            // 
            // 
            // 
            // 
            this.timeoutTB.CustomButton.Image = null;
            this.timeoutTB.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.timeoutTB.CustomButton.Name = "";
            this.timeoutTB.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.timeoutTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeoutTB.CustomButton.TabIndex = 1;
            this.timeoutTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeoutTB.CustomButton.UseSelectable = true;
            this.timeoutTB.CustomButton.Visible = false;
            this.timeoutTB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.timeoutTB.Lines = new string[] {
        "5000"};
            this.timeoutTB.Location = new System.Drawing.Point(410, 335);
            this.timeoutTB.MaxLength = 32767;
            this.timeoutTB.Multiline = true;
            this.timeoutTB.Name = "timeoutTB";
            this.timeoutTB.PasswordChar = '\0';
            this.timeoutTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeoutTB.SelectedText = "";
            this.timeoutTB.SelectionLength = 0;
            this.timeoutTB.SelectionStart = 0;
            this.timeoutTB.ShortcutsEnabled = true;
            this.timeoutTB.Size = new System.Drawing.Size(104, 33);
            this.timeoutTB.TabIndex = 82;
            this.timeoutTB.Text = "5000";
            this.timeoutTB.UseSelectable = true;
            this.timeoutTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeoutTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(297, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 80;
            this.label1.Text = "Relay:";
            // 
            // relayToggle
            // 
            this.relayToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.relayToggle.Location = new System.Drawing.Point(382, 263);
            this.relayToggle.Name = "relayToggle";
            this.relayToggle.Size = new System.Drawing.Size(92, 34);
            this.relayToggle.Style = MetroFramework.MetroColorStyle.Yellow;
            this.relayToggle.TabIndex = 79;
            this.relayToggle.Text = "Off";
            this.relayToggle.UseSelectable = true;
            this.relayToggle.CheckedChanged += new System.EventHandler(this.RelayToggle_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Interactive_Hexabitz_Modules_GUI.Properties.Resources.h09r00_photo_top;
            this.pictureBox3.Location = new System.Drawing.Point(281, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(351, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 29);
            this.label9.TabIndex = 95;
            this.label9.Text = "Destination Module ID:";
            // 
            // destinationID_N
            // 
            this.destinationID_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.destinationID_N.Location = new System.Drawing.Point(612, 668);
            this.destinationID_N.Name = "destinationID_N";
            this.destinationID_N.Size = new System.Drawing.Size(60, 36);
            this.destinationID_N.TabIndex = 96;
            this.destinationID_N.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.destinationID_N.ValueChanged += new System.EventHandler(this.DestinationID_ValueChanged);
            // 
            // sourceID_N
            // 
            this.sourceID_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sourceID_N.Location = new System.Drawing.Point(612, 716);
            this.sourceID_N.Name = "sourceID_N";
            this.sourceID_N.Size = new System.Drawing.Size(60, 36);
            this.sourceID_N.TabIndex = 98;
            this.sourceID_N.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sourceID_N.ValueChanged += new System.EventHandler(this.SourceID_N_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(351, 719);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 29);
            this.label10.TabIndex = 97;
            this.label10.Text = "Source Module ID:";
            // 
            // baudRateCB
            // 
            this.baudRateCB.FormattingEnabled = true;
            this.baudRateCB.ItemHeight = 24;
            this.baudRateCB.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.baudRateCB.Location = new System.Drawing.Point(183, 726);
            this.baudRateCB.Name = "baudRateCB";
            this.baudRateCB.Size = new System.Drawing.Size(122, 30);
            this.baudRateCB.TabIndex = 100;
            this.baudRateCB.UseSelectable = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(178, 691);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 29);
            this.label12.TabIndex = 99;
            this.label12.Text = "Baud Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 775);
            this.Controls.Add(this.baudRateCB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sourceID_N);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.destinationID_N);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.testBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Interactive Hexabitz Modules GUI";
            ((System.ComponentModel.ISupportInitialize)(this.COM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationID_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceID_N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown COM;
        private MetroFramework.Controls.MetroButton testBTN;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTrackBar blueTB;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTrackBar greenTB;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTrackBar redTB;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTrackBar intensityTB;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroToggle ledToggle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox timeoutTB;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroToggle relayToggle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown destinationID_N;
        private System.Windows.Forms.NumericUpDown sourceID_N;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroComboBox baudRateCB;
        private System.Windows.Forms.Label label12;
    }
}

