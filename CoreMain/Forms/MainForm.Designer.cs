namespace CoreMain
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBuild = new System.Windows.Forms.Label();
            this.AddBuild1 = new System.Windows.Forms.Label();
            this.siticoneRoundedTextBox1 = new ns1.SiticoneRoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPicture1 = new RoundedPicture();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.siticoneButton3);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Location = new System.Drawing.Point(-17, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Core Launcher | Beta 0.7";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.Black;
            this.siticoneButton3.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(676, 0);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(48, 28);
            this.siticoneButton3.TabIndex = 3;
            this.siticoneButton3.Text = "—";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Black;
            this.siticoneButton1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(725, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(48, 28);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.siticoneButton2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.roundedPicture1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-14, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 340);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Green;
            this.siticoneButton2.Font = new System.Drawing.Font("Product Sans", 24F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.LawnGreen;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(21, 266);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(160, 44);
            this.siticoneButton2.TabIndex = 15;
            this.siticoneButton2.Text = "Launch";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Need Mods?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "invalid user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddBuild
            // 
            this.AddBuild.AutoSize = true;
            this.AddBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuild.ForeColor = System.Drawing.Color.White;
            this.AddBuild.Location = new System.Drawing.Point(20, 383);
            this.AddBuild.Name = "AddBuild";
            this.AddBuild.Size = new System.Drawing.Size(101, 24);
            this.AddBuild.TabIndex = 3;
            this.AddBuild.Text = "Add Build";
            this.AddBuild.Click += new System.EventHandler(this.AddBuild_Click);
            // 
            // AddBuild1
            // 
            this.AddBuild1.AutoSize = true;
            this.AddBuild1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AddBuild1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuild1.ForeColor = System.Drawing.Color.White;
            this.AddBuild1.Location = new System.Drawing.Point(121, 380);
            this.AddBuild1.Name = "AddBuild1";
            this.AddBuild1.Size = new System.Drawing.Size(33, 33);
            this.AddBuild1.TabIndex = 4;
            this.AddBuild1.Text = "+";
            this.AddBuild1.Click += new System.EventHandler(this.AddBuild1_Click);
            // 
            // siticoneRoundedTextBox1
            // 
            this.siticoneRoundedTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.siticoneRoundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneRoundedTextBox1.DefaultText = "";
            this.siticoneRoundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.DisabledState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneRoundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.FocusedState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.HoveredState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Location = new System.Drawing.Point(160, 383);
            this.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1";
            this.siticoneRoundedTextBox1.PasswordChar = '\0';
            this.siticoneRoundedTextBox1.PlaceholderText = "";
            this.siticoneRoundedTextBox1.SelectedText = "";
            this.siticoneRoundedTextBox1.ShadowDecoration.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Size = new System.Drawing.Size(589, 24);
            this.siticoneRoundedTextBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-8, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "n";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoreMain.Properties.Resources.Fortnite_Season_7_Loading_Screen_Plane;
            this.pictureBox1.Location = new System.Drawing.Point(174, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 416);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 160);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // roundedPicture1
            // 
            this.roundedPicture1.BackColor = System.Drawing.Color.DarkGray;
            this.roundedPicture1.Location = new System.Drawing.Point(38, 19);
            this.roundedPicture1.Name = "roundedPicture1";
            this.roundedPicture1.Size = new System.Drawing.Size(124, 115);
            this.roundedPicture1.TabIndex = 1;
            this.roundedPicture1.TabStop = false;
            this.roundedPicture1.Click += new System.EventHandler(this.roundedPicture1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(757, 588);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneRoundedTextBox1);
            this.Controls.Add(this.AddBuild1);
            this.Controls.Add(this.AddBuild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneButton siticoneButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddBuild;
        private System.Windows.Forms.Label AddBuild1;
        private ns1.SiticoneRoundedTextBox siticoneRoundedTextBox1;
        private RoundedPicture roundedPicture1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ns1.SiticoneButton siticoneButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

