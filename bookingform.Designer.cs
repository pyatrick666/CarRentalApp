namespace WindowsFormsApp1
{
    partial class bookingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.ageinput = new System.Windows.Forms.NumericUpDown();
            this.fueltype = new System.Windows.Forms.ComboBox();
            this.cartype = new System.Windows.Forms.ComboBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.verifylicense = new System.Windows.Forms.CheckBox();
            this.backbutton2 = new System.Windows.Forms.Button();
            this.optional = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.breakdown = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(873, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number Of Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(911, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fuel Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(875, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Unlimited Milage\r\n";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(341, 121);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 32);
            this.fname.TabIndex = 8;
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(341, 227);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 32);
            this.lname.TabIndex = 9;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(341, 327);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 32);
            this.Address.TabIndex = 10;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(1030, 118);
            this.duration.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(120, 22);
            this.duration.TabIndex = 11;
            this.duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ageinput
            // 
            this.ageinput.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageinput.Location = new System.Drawing.Point(341, 410);
            this.ageinput.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageinput.Name = "ageinput";
            this.ageinput.Size = new System.Drawing.Size(120, 32);
            this.ageinput.TabIndex = 12;
            this.ageinput.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // fueltype
            // 
            this.fueltype.FormattingEnabled = true;
            this.fueltype.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Full electric"});
            this.fueltype.Location = new System.Drawing.Point(1030, 323);
            this.fueltype.Name = "fueltype";
            this.fueltype.Size = new System.Drawing.Size(121, 24);
            this.fueltype.TabIndex = 13;
            // 
            // cartype
            // 
            this.cartype.FormattingEnabled = true;
            this.cartype.Items.AddRange(new object[] {
            "City car",
            "Family car",
            "Sports car",
            "SUV "});
            this.cartype.Location = new System.Drawing.Point(1030, 222);
            this.cartype.Name = "cartype";
            this.cartype.Size = new System.Drawing.Size(121, 24);
            this.cartype.TabIndex = 15;
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.Lime;
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbutton.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.Location = new System.Drawing.Point(1001, 583);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(149, 52);
            this.submitbutton.TabIndex = 16;
            this.submitbutton.Text = " Submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Driving License";
            // 
            // verifylicense
            // 
            this.verifylicense.AutoSize = true;
            this.verifylicense.BackColor = System.Drawing.Color.Transparent;
            this.verifylicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifylicense.Location = new System.Drawing.Point(408, 526);
            this.verifylicense.Name = "verifylicense";
            this.verifylicense.Size = new System.Drawing.Size(71, 29);
            this.verifylicense.TabIndex = 23;
            this.verifylicense.Text = "Yes";
            this.verifylicense.UseVisualStyleBackColor = false;
            // 
            // backbutton2
            // 
            this.backbutton2.BackColor = System.Drawing.Color.Red;
            this.backbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton2.Location = new System.Drawing.Point(312, 583);
            this.backbutton2.Name = "backbutton2";
            this.backbutton2.Size = new System.Drawing.Size(149, 52);
            this.backbutton2.TabIndex = 24;
            this.backbutton2.Text = "Go Back";
            this.backbutton2.UseVisualStyleBackColor = false;
            this.backbutton2.Click += new System.EventHandler(this.backbutton2_Click);
            // 
            // optional
            // 
            this.optional.AutoSize = true;
            this.optional.BackColor = System.Drawing.Color.Transparent;
            this.optional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optional.Location = new System.Drawing.Point(1098, 408);
            this.optional.Name = "optional";
            this.optional.Size = new System.Drawing.Size(71, 29);
            this.optional.TabIndex = 25;
            this.optional.Text = "Yes";
            this.optional.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(840, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Breakdown Coverage";
            // 
            // breakdown
            // 
            this.breakdown.AutoSize = true;
            this.breakdown.BackColor = System.Drawing.Color.Transparent;
            this.breakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown.Location = new System.Drawing.Point(1098, 526);
            this.breakdown.Name = "breakdown";
            this.breakdown.Size = new System.Drawing.Size(71, 29);
            this.breakdown.TabIndex = 27;
            this.breakdown.Text = "Yes";
            this.breakdown.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // bookingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 849);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.breakdown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.optional);
            this.Controls.Add(this.backbutton2);
            this.Controls.Add(this.verifylicense);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.cartype);
            this.Controls.Add(this.fueltype);
            this.Controls.Add(this.ageinput);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookingform";
            this.Text = "Book Your Seat";
            this.Load += new System.EventHandler(this.bookingform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.NumericUpDown ageinput;
        private System.Windows.Forms.ComboBox fueltype;
        private System.Windows.Forms.ComboBox cartype;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox verifylicense;
        private System.Windows.Forms.Button backbutton2;
        private System.Windows.Forms.CheckBox optional;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox breakdown;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}