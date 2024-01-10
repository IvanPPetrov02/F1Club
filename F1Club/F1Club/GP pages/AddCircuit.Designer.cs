namespace F1Club.GP_pages
{
    partial class AddCircuit
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
            label5 = new Label();
            tbxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            nudNrOfLaps = new NumericUpDown();
            nudLength = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            nudRoadScore = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            nudNrOfCorners = new NumericUpDown();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNrOfLaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoadScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfCorners).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 12);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 47;
            label5.Text = "Length:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(14, 42);
            tbxName.Margin = new Padding(4, 5, 4, 5);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(200, 31);
            tbxName.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 40;
            label2.Text = "Number of laps:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 38;
            label1.Text = "Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(258, 255);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 53);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 255);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 53);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudNrOfLaps
            // 
            nudNrOfLaps.Location = new Point(13, 135);
            nudNrOfLaps.Margin = new Padding(4, 3, 4, 3);
            nudNrOfLaps.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudNrOfLaps.Name = "nudNrOfLaps";
            nudNrOfLaps.Size = new Size(187, 31);
            nudNrOfLaps.TabIndex = 48;
            nudNrOfLaps.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLength
            // 
            nudLength.Location = new Point(253, 42);
            nudLength.Margin = new Padding(4, 3, 4, 3);
            nudLength.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudLength.Name = "nudLength";
            nudLength.Size = new Size(187, 31);
            nudLength.TabIndex = 49;
            nudLength.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(414, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 38);
            label3.TabIndex = 50;
            label3.Text = "km";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(175, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 51;
            label4.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(366, 135);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 38);
            label6.TabIndex = 54;
            label6.Text = "/10";
            // 
            // nudRoadScore
            // 
            nudRoadScore.DecimalPlaces = 2;
            nudRoadScore.Location = new Point(269, 139);
            nudRoadScore.Margin = new Padding(4, 3, 4, 3);
            nudRoadScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRoadScore.Name = "nudRoadScore";
            nudRoadScore.Size = new Size(122, 31);
            nudRoadScore.TabIndex = 53;
            nudRoadScore.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 86);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(198, 50);
            label7.TabIndex = 52;
            label7.Text = "Road score\r\n(how good the road is):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(286, 200);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 38);
            label8.TabIndex = 57;
            label8.Text = "per lap";
            // 
            // nudNrOfCorners
            // 
            nudNrOfCorners.Location = new Point(124, 204);
            nudNrOfCorners.Margin = new Padding(4, 3, 4, 3);
            nudNrOfCorners.Name = "nudNrOfCorners";
            nudNrOfCorners.Size = new Size(187, 31);
            nudNrOfCorners.TabIndex = 56;
            nudNrOfCorners.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(124, 174);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 55;
            label9.Text = "Number of corners:";
            // 
            // AddCircuit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 339);
            Controls.Add(label8);
            Controls.Add(nudNrOfCorners);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(nudRoadScore);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nudLength);
            Controls.Add(nudNrOfLaps);
            Controls.Add(label5);
            Controls.Add(tbxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(488, 395);
            MinimizeBox = false;
            MinimumSize = new Size(488, 395);
            Name = "AddCircuit";
            Text = "AddCircuit";
            ((System.ComponentModel.ISupportInitialize)nudNrOfLaps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoadScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfCorners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox tbxName;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
        private NumericUpDown nudNrOfLaps;
        private NumericUpDown nudLength;
        private Label label3;
        private Label label4;
        private Label label6;
        private NumericUpDown nudRoadScore;
        private Label label7;
        private Label label8;
        private NumericUpDown nudNrOfCorners;
        private Label label9;
    }
}