namespace F1Club
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
            btnDriver = new Button();
            btnTeam = new Button();
            btnCircuit = new Button();
            btnGPs = new Button();
            btnChampionship = new Button();
            pictureBox1 = new PictureBox();
            panelForms = new Panel();
            btnLogout = new Button();
            btnProfiles = new Button();
            btnStatistics = new Button();
            btnCars = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDriver
            // 
            btnDriver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDriver.Location = new Point(168, 20);
            btnDriver.Margin = new Padding(4, 5, 4, 5);
            btnDriver.Name = "btnDriver";
            btnDriver.Size = new Size(171, 140);
            btnDriver.TabIndex = 0;
            btnDriver.Text = "Drivers";
            btnDriver.UseVisualStyleBackColor = true;
            btnDriver.Click += btnDriver_Click;
            // 
            // btnTeam
            // 
            btnTeam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeam.Location = new Point(347, 20);
            btnTeam.Margin = new Padding(4, 5, 4, 5);
            btnTeam.Name = "btnTeam";
            btnTeam.Size = new Size(171, 140);
            btnTeam.TabIndex = 1;
            btnTeam.Text = "Teams";
            btnTeam.UseVisualStyleBackColor = true;
            btnTeam.Click += btnTeam_Click;
            // 
            // btnCircuit
            // 
            btnCircuit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCircuit.Location = new Point(705, 20);
            btnCircuit.Margin = new Padding(4, 5, 4, 5);
            btnCircuit.Name = "btnCircuit";
            btnCircuit.Size = new Size(171, 140);
            btnCircuit.TabIndex = 2;
            btnCircuit.Text = "Circuits";
            btnCircuit.UseVisualStyleBackColor = true;
            btnCircuit.Click += btnCircuit_Click;
            // 
            // btnGPs
            // 
            btnGPs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGPs.Location = new Point(884, 20);
            btnGPs.Margin = new Padding(4, 5, 4, 5);
            btnGPs.Name = "btnGPs";
            btnGPs.Size = new Size(171, 140);
            btnGPs.TabIndex = 3;
            btnGPs.Text = "Grand Prixes";
            btnGPs.UseVisualStyleBackColor = true;
            btnGPs.Click += btnGP_Click;
            // 
            // btnChampionship
            // 
            btnChampionship.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChampionship.Location = new Point(1063, 20);
            btnChampionship.Margin = new Padding(4, 5, 4, 5);
            btnChampionship.Name = "btnChampionship";
            btnChampionship.Size = new Size(180, 140);
            btnChampionship.TabIndex = 4;
            btnChampionship.Text = "Championships";
            btnChampionship.UseVisualStyleBackColor = true;
            btnChampionship.Click += btnChampionship_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelForms
            // 
            panelForms.Location = new Point(17, 170);
            panelForms.Margin = new Padding(4, 5, 4, 5);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(1707, 908);
            panelForms.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1609, 20);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 140);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfiles
            // 
            btnProfiles.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfiles.Location = new Point(1251, 20);
            btnProfiles.Margin = new Padding(4, 5, 4, 5);
            btnProfiles.Name = "btnProfiles";
            btnProfiles.Size = new Size(171, 140);
            btnProfiles.TabIndex = 8;
            btnProfiles.Text = "Profiles";
            btnProfiles.UseVisualStyleBackColor = true;
            btnProfiles.Click += btnProfiles_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistics.Location = new Point(1430, 20);
            btnStatistics.Margin = new Padding(4, 5, 4, 5);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(171, 140);
            btnStatistics.TabIndex = 9;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnCars
            // 
            btnCars.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCars.Location = new Point(526, 20);
            btnCars.Margin = new Padding(4, 5, 4, 5);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(171, 140);
            btnCars.TabIndex = 10;
            btnCars.Text = "Cars";
            btnCars.UseVisualStyleBackColor = true;
            btnCars.Click += btnBullets_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1084);
            Controls.Add(btnDriver);
            Controls.Add(btnCars);
            Controls.Add(btnStatistics);
            Controls.Add(btnProfiles);
            Controls.Add(btnLogout);
            Controls.Add(panelForms);
            Controls.Add(pictureBox1);
            Controls.Add(btnChampionship);
            Controls.Add(btnGPs);
            Controls.Add(btnCircuit);
            Controls.Add(btnTeam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1755, 1140);
            MinimumSize = new Size(1755, 1140);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F1Club";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDriver;
        private Button btnTeam;
        private Button btnCircuit;
        private Button btnGPs;
        private Button btnChampionship;
        private PictureBox pictureBox1;
        private Panel panelForms;
        private Button btnLogout;
        private Button btnProfiles;
        private Button btnStatistics;
        private Button btnCars;
    }
}