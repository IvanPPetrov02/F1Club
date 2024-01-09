namespace F1Club.GP_pages
{
    partial class EditCircuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCircuit));
            label4 = new Label();
            label3 = new Label();
            nudLength = new NumericUpDown();
            nudNrOfLaps = new NumericUpDown();
            label5 = new Label();
            tbxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            label6 = new Label();
            nudRoadScore = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            nudNrOfCorners = new NumericUpDown();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfLaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoadScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfCorners).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 61;
            label4.Text = "total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(410, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 38);
            label3.TabIndex = 60;
            label3.Text = "km";
            // 
            // nudLength
            // 
            nudLength.Location = new Point(246, 53);
            nudLength.Margin = new Padding(4, 3, 4, 3);
            nudLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudLength.Name = "nudLength";
            nudLength.Size = new Size(187, 31);
            nudLength.TabIndex = 59;
            nudLength.TextAlign = HorizontalAlignment.Right;
            // 
            // nudNrOfLaps
            // 
            nudNrOfLaps.Location = new Point(13, 134);
            nudNrOfLaps.Margin = new Padding(4, 3, 4, 3);
            nudNrOfLaps.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudNrOfLaps.Name = "nudNrOfLaps";
            nudNrOfLaps.Size = new Size(187, 31);
            nudNrOfLaps.TabIndex = 58;
            nudNrOfLaps.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 57;
            label5.Text = "Length:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(7, 53);
            tbxName.Margin = new Padding(4, 5, 4, 5);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(200, 31);
            tbxName.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 55;
            label2.Text = "Number of laps:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 54;
            label1.Text = "Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(256, 272);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 53);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(54, 272);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 53);
            btnEdit.TabIndex = 52;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(356, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 38);
            label6.TabIndex = 64;
            label6.Text = "/10";
            // 
            // nudRoadScore
            // 
            nudRoadScore.DecimalPlaces = 2;
            nudRoadScore.Location = new Point(259, 141);
            nudRoadScore.Margin = new Padding(4, 3, 4, 3);
            nudRoadScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRoadScore.Name = "nudRoadScore";
            nudRoadScore.Size = new Size(122, 31);
            nudRoadScore.TabIndex = 63;
            nudRoadScore.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 88);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(198, 50);
            label7.TabIndex = 62;
            label7.Text = "Road score\r\n(how good the road is):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(269, 211);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 38);
            label8.TabIndex = 67;
            label8.Text = "per lap";
            // 
            // nudNrOfCorners
            // 
            nudNrOfCorners.Location = new Point(107, 215);
            nudNrOfCorners.Margin = new Padding(4, 3, 4, 3);
            nudNrOfCorners.Name = "nudNrOfCorners";
            nudNrOfCorners.Size = new Size(187, 31);
            nudNrOfCorners.TabIndex = 66;
            nudNrOfCorners.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(107, 185);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 65;
            label9.Text = "Number of corners:";
            // 
            // EditCircuit
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
            Controls.Add(btnEdit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(488, 395);
            MinimizeBox = false;
            MinimumSize = new Size(488, 395);
            Name = "EditCircuit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCircuit";
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfLaps).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoadScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNrOfCorners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private NumericUpDown nudLength;
        private NumericUpDown nudNrOfLaps;
        private Label label5;
        private TextBox tbxName;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
        private Label label6;
        private NumericUpDown nudRoadScore;
        private Label label7;
        private Label label8;
        private NumericUpDown nudNrOfCorners;
        private Label label9;
    }
}