namespace CoreMain.Forms
{
    partial class AddBuild
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.siticoneTextBox1 = new ns1.SiticoneTextBox();
            this.PathText = new ns1.SiticoneTextBox();
            this.siticoneButton4 = new ns1.SiticoneButton();
            this.siticoneButton5 = new ns1.SiticoneButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.siticoneButton3);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 28);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.Black;
            this.siticoneButton3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(316, 0);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(48, 28);
            this.siticoneButton3.TabIndex = 3;
            this.siticoneButton3.Text = "-";
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
            this.siticoneButton1.Location = new System.Drawing.Point(362, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(48, 28);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "Build Name";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(12, 52);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(385, 55);
            this.siticoneTextBox1.TabIndex = 2;
            // 
            // PathText
            // 
            this.PathText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathText.DefaultText = "Path";
            this.PathText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathText.DisabledState.Parent = this.PathText;
            this.PathText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PathText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathText.FocusedState.Parent = this.PathText;
            this.PathText.ForeColor = System.Drawing.Color.White;
            this.PathText.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathText.HoveredState.Parent = this.PathText;
            this.PathText.Location = new System.Drawing.Point(12, 113);
            this.PathText.Name = "PathText";
            this.PathText.PasswordChar = '\0';
            this.PathText.PlaceholderText = "";
            this.PathText.SelectedText = "";
            this.PathText.ShadowDecoration.Parent = this.PathText;
            this.PathText.Size = new System.Drawing.Size(333, 55);
            this.PathText.TabIndex = 3;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.Green;
            this.siticoneButton4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Location = new System.Drawing.Point(12, 183);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Color = System.Drawing.Color.Green;
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(385, 53);
            this.siticoneButton4.TabIndex = 4;
            this.siticoneButton4.Text = "Launch";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Location = new System.Drawing.Point(351, 115);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.ShadowDecoration.Color = System.Drawing.Color.Green;
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(46, 53);
            this.siticoneButton5.TabIndex = 5;
            this.siticoneButton5.Text = "...";
            this.siticoneButton5.Click += new System.EventHandler(this.siticoneButton5_Click);
            // 
            // AddBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(409, 259);
            this.Controls.Add(this.siticoneButton5);
            this.Controls.Add(this.siticoneButton4);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBuild";
            this.Load += new System.EventHandler(this.AddBuild_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneButton siticoneButton3;
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneTextBox siticoneTextBox1;
        private ns1.SiticoneTextBox PathText;
        private ns1.SiticoneButton siticoneButton4;
        private ns1.SiticoneButton siticoneButton5;
    }
}