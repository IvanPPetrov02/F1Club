namespace F1Club.Team_pages
{
    partial class EditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCar));
            dtpSeason = new DateTimePicker();
            label6 = new Label();
            tbxEngine = new TextBox();
            label15 = new Label();
            tbxChasis = new TextBox();
            label14 = new Label();
            label10 = new Label();
            nudTopSpeed = new NumericUpDown();
            label11 = new Label();
            label8 = new Label();
            nudBreaking = new NumericUpDown();
            label9 = new Label();
            label4 = new Label();
            nudAcceleration = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            nudHandling = new NumericUpDown();
            label3 = new Label();
            cbxTeams = new ComboBox();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTopSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBreaking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAcceleration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHandling).BeginInit();
            SuspendLayout();
            // 
            // dtpSeason
            // 
            dtpSeason.Format = DateTimePickerFormat.Custom;
            dtpSeason.Location = new Point(115, 259);
            dtpSeason.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpSeason.Name = "dtpSeason";
            dtpSeason.Size = new Size(131, 31);
            dtpSeason.TabIndex = 117;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 231);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 116;
            label6.Text = "Season used:";
            // 
            // tbxEngine
            // 
            tbxEngine.Location = new Point(12, 116);
            tbxEngine.Name = "tbxEngine";
            tbxEngine.Size = new Size(350, 31);
            tbxEngine.TabIndex = 115;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 88);
            label15.Name = "label15";
            label15.Size = new Size(69, 25);
            label15.TabIndex = 114;
            label15.Text = "Engine:";
            // 
            // tbxChasis
            // 
            tbxChasis.Location = new Point(12, 188);
            tbxChasis.Name = "tbxChasis";
            tbxChasis.Size = new Size(350, 31);
            tbxChasis.TabIndex = 113;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 162);
            label14.Name = "label14";
            label14.Size = new Size(66, 25);
            label14.TabIndex = 112;
            label14.Text = "Chasis:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(119, 335);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 38);
            label10.TabIndex = 111;
            label10.Text = "km/h";
            // 
            // nudTopSpeed
            // 
            nudTopSpeed.Location = new Point(22, 339);
            nudTopSpeed.Margin = new Padding(4, 3, 4, 3);
            nudTopSpeed.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudTopSpeed.Name = "nudTopSpeed";
            nudTopSpeed.Size = new Size(122, 31);
            nudTopSpeed.TabIndex = 110;
            nudTopSpeed.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 311);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 109;
            label11.Text = "Top speed:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(310, 335);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 38);
            label8.TabIndex = 108;
            label8.Text = "/10";
            // 
            // nudBreaking
            // 
            nudBreaking.DecimalPlaces = 2;
            nudBreaking.Location = new Point(213, 339);
            nudBreaking.Margin = new Padding(4, 3, 4, 3);
            nudBreaking.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudBreaking.Name = "nudBreaking";
            nudBreaking.Size = new Size(122, 31);
            nudBreaking.TabIndex = 107;
            nudBreaking.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 311);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 106;
            label9.Text = "Breaking score:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 416);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 38);
            label4.TabIndex = 105;
            label4.Text = "/10";
            // 
            // nudAcceleration
            // 
            nudAcceleration.DecimalPlaces = 2;
            nudAcceleration.Location = new Point(213, 420);
            nudAcceleration.Margin = new Padding(4, 3, 4, 3);
            nudAcceleration.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAcceleration.Name = "nudAcceleration";
            nudAcceleration.Size = new Size(122, 31);
            nudAcceleration.TabIndex = 104;
            nudAcceleration.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 392);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 103;
            label5.Text = "Acceleration score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(115, 416);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 38);
            label2.TabIndex = 102;
            label2.Text = "/10";
            // 
            // nudHandling
            // 
            nudHandling.DecimalPlaces = 2;
            nudHandling.Location = new Point(18, 420);
            nudHandling.Margin = new Padding(4, 3, 4, 3);
            nudHandling.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHandling.Name = "nudHandling";
            nudHandling.Size = new Size(122, 31);
            nudHandling.TabIndex = 101;
            nudHandling.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 392);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 100;
            label3.Text = "Handling score:";
            // 
            // cbxTeams
            // 
            cbxTeams.FormattingEnabled = true;
            cbxTeams.Location = new Point(12, 39);
            cbxTeams.Name = "cbxTeams";
            cbxTeams.Size = new Size(350, 33);
            cbxTeams.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 98;
            label1.Text = "Team:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(217, 485);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 53);
            btnCancel.TabIndex = 97;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(14, 485);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 53);
            btnEdit.TabIndex = 96;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditCar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 550);
            Controls.Add(dtpSeason);
            Controls.Add(label6);
            Controls.Add(tbxEngine);
            Controls.Add(label15);
            Controls.Add(tbxChasis);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(nudTopSpeed);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(nudBreaking);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(nudAcceleration);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(nudHandling);
            Controls.Add(label3);
            Controls.Add(cbxTeams);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 606);
            MinimizeBox = false;
            MinimumSize = new Size(400, 606);
            Name = "EditCar";
            Text = "EditCar";
            ((System.ComponentModel.ISupportInitialize)nudTopSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBreaking).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAcceleration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHandling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpSeason;
        private Label label6;
        private TextBox tbxEngine;
        private Label label15;
        private TextBox tbxChasis;
        private Label label14;
        private Label label10;
        private NumericUpDown nudTopSpeed;
        private Label label11;
        private Label label8;
        private NumericUpDown nudBreaking;
        private Label label9;
        private Label label4;
        private NumericUpDown nudAcceleration;
        private Label label5;
        private Label label2;
        private NumericUpDown nudHandling;
        private Label label3;
        private ComboBox cbxTeams;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
    }
}