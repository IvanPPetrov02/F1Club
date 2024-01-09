namespace F1Club.GP_pages
{
    partial class AddGPResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGPResult));
            btnSave = new Button();
            btnCancel = new Button();
            cbx1 = new ComboBox();
            nudLTmin1 = new NumericUpDown();
            nudLTsec1 = new NumericUpDown();
            nudLTms1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            nudFTsec1 = new NumericUpDown();
            label9 = new Label();
            nudFTmin1 = new NumericUpDown();
            label10 = new Label();
            nudFThr1 = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            nudMax1 = new NumericUpDown();
            label14 = new Label();
            nudAVG1 = new NumericUpDown();
            label15 = new Label();
            nudFTms1 = new NumericUpDown();
            gbPosit = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblPosition = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            cbDNF = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudLTmin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLTsec1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLTms1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFTsec1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFTmin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFThr1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMax1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAVG1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFTms1).BeginInit();
            gbPosit.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(65, 635);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(183, 635);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbx1
            // 
            cbx1.FormattingEnabled = true;
            cbx1.Location = new Point(31, 43);
            cbx1.Name = "cbx1";
            cbx1.Size = new Size(287, 33);
            cbx1.TabIndex = 5;
            // 
            // nudLTmin1
            // 
            nudLTmin1.Location = new Point(58, 66);
            nudLTmin1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudLTmin1.Name = "nudLTmin1";
            nudLTmin1.Size = new Size(60, 31);
            nudLTmin1.TabIndex = 7;
            // 
            // nudLTsec1
            // 
            nudLTsec1.Location = new Point(137, 66);
            nudLTsec1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudLTsec1.Name = "nudLTsec1";
            nudLTsec1.Size = new Size(60, 31);
            nudLTsec1.TabIndex = 8;
            // 
            // nudLTms1
            // 
            nudLTms1.Location = new Point(218, 68);
            nudLTms1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudLTms1.Name = "nudLTms1";
            nudLTms1.Size = new Size(60, 31);
            nudLTms1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 66);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 10;
            label3.Text = "min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(167, 66);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 11;
            label4.Text = "sec";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(249, 67);
            label5.Name = "label5";
            label5.Size = new Size(45, 32);
            label5.TabIndex = 12;
            label5.Text = "ms";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 37);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 13;
            label6.Text = "Lap time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 114);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 20;
            label7.Text = "Finish time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(202, 142);
            label8.Name = "label8";
            label8.Size = new Size(48, 32);
            label8.TabIndex = 19;
            label8.Text = "sec";
            // 
            // nudFTsec1
            // 
            nudFTsec1.Location = new Point(171, 143);
            nudFTsec1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudFTsec1.Name = "nudFTsec1";
            nudFTsec1.Size = new Size(60, 31);
            nudFTsec1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(120, 143);
            label9.Name = "label9";
            label9.Size = new Size(55, 32);
            label9.TabIndex = 18;
            label9.Text = "min";
            // 
            // nudFTmin1
            // 
            nudFTmin1.Location = new Point(90, 143);
            nudFTmin1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudFTmin1.Name = "nudFTmin1";
            nudFTmin1.Size = new Size(60, 31);
            nudFTmin1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(42, 143);
            label10.Name = "label10";
            label10.Size = new Size(36, 32);
            label10.TabIndex = 17;
            label10.Text = "hr";
            // 
            // nudFThr1
            // 
            nudFThr1.Location = new Point(11, 143);
            nudFThr1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudFThr1.Name = "nudFThr1";
            nudFThr1.Size = new Size(60, 31);
            nudFThr1.TabIndex = 14;
            nudFThr1.ValueChanged += nudFThr1_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(216, 42);
            label11.Name = "label11";
            label11.Size = new Size(102, 25);
            label11.TabIndex = 21;
            label11.Text = "Max speed:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 42);
            label12.Name = "label12";
            label12.Size = new Size(134, 25);
            label12.TabIndex = 22;
            label12.Text = "Average speed:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(248, 74);
            label13.Name = "label13";
            label13.Size = new Size(70, 32);
            label13.TabIndex = 24;
            label13.Text = "km/h";
            // 
            // nudMax1
            // 
            nudMax1.Location = new Point(217, 75);
            nudMax1.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudMax1.Name = "nudMax1";
            nudMax1.Size = new Size(60, 31);
            nudMax1.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(66, 75);
            label14.Name = "label14";
            label14.Size = new Size(70, 32);
            label14.TabIndex = 26;
            label14.Text = "km/h";
            // 
            // nudAVG1
            // 
            nudAVG1.Location = new Point(35, 76);
            nudAVG1.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudAVG1.Name = "nudAVG1";
            nudAVG1.Size = new Size(60, 31);
            nudAVG1.TabIndex = 25;
            nudAVG1.ValueChanged += nudAVG1_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(287, 144);
            label15.Name = "label15";
            label15.Size = new Size(45, 32);
            label15.TabIndex = 28;
            label15.Text = "ms";
            // 
            // nudFTms1
            // 
            nudFTms1.Location = new Point(256, 145);
            nudFTms1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudFTms1.Name = "nudFTms1";
            nudFTms1.Size = new Size(60, 31);
            nudFTms1.TabIndex = 27;
            // 
            // gbPosit
            // 
            gbPosit.Controls.Add(cbx1);
            gbPosit.Location = new Point(12, 49);
            gbPosit.Name = "gbPosit";
            gbPosit.Size = new Size(348, 106);
            gbPosit.TabIndex = 29;
            gbPosit.TabStop = false;
            gbPosit.Text = "Driver:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(nudAVG1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(nudMax1);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 139);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set speeds:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(nudLTms1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudLTsec1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(nudLTmin1);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(nudFTms1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(nudFTsec1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(nudFThr1);
            groupBox2.Controls.Add(nudFTmin1);
            groupBox2.Location = new Point(12, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 198);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set times:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.Location = new Point(57, 9);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(249, 38);
            lblPosition.TabIndex = 32;
            lblPosition.Text = "Enter driver results";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(12, 573);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(112, 34);
            btnPrevious.TabIndex = 33;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(248, 573);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 34;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // cbDNF
            // 
            cbDNF.AutoSize = true;
            cbDNF.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            cbDNF.Location = new Point(140, 522);
            cbDNF.Name = "cbDNF";
            cbDNF.Size = new Size(87, 36);
            cbDNF.TabIndex = 35;
            cbDNF.Text = "DNF";
            cbDNF.UseVisualStyleBackColor = true;
            cbDNF.CheckedChanged += cbDNF_CheckedChanged;
            // 
            // AddGPResult
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 687);
            Controls.Add(cbDNF);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPosition);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbPosit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(398, 743);
            MinimizeBox = false;
            MinimumSize = new Size(398, 743);
            Name = "AddGPResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add results";
            ((System.ComponentModel.ISupportInitialize)nudLTmin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLTsec1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLTms1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFTsec1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFTmin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFThr1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMax1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAVG1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFTms1).EndInit();
            gbPosit.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbx1;
        private NumericUpDown nudLTmin1;
        private NumericUpDown nudLTsec1;
        private NumericUpDown nudLTms1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown nudFTsec1;
        private Label label9;
        private NumericUpDown nudFTmin1;
        private Label label10;
        private NumericUpDown nudFThr1;
        private Label label11;
        private Label label12;
        private Label label13;
        private NumericUpDown nudMax1;
        private Label label14;
        private NumericUpDown nudAVG1;
        private Label label15;
        private NumericUpDown nudFTms1;
        private GroupBox gbPosit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblPosition;
        private Button btnPrevious;
        private Button btnNext;
        private CheckBox cbDNF;
    }
}