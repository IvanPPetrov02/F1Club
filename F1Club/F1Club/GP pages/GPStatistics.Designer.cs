namespace F1Club.GP_pages
{
    partial class GPStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPStatistics));
            dgvPlaces = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbLapTime = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClose = new Button();
            btnReset = new Button();
            btnRefresh = new Button();
            tbxFinishTime = new TextBox();
            label3 = new Label();
            tbxMaxSpeed = new TextBox();
            label4 = new Label();
            tbxAverageSpeed = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPlaces).BeginInit();
            SuspendLayout();
            // 
            // dgvPlaces
            // 
            dgvPlaces.AllowUserToAddRows = false;
            dgvPlaces.AllowUserToDeleteRows = false;
            dgvPlaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvPlaces.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaces.Location = new Point(12, 37);
            dgvPlaces.MultiSelect = false;
            dgvPlaces.Name = "dgvPlaces";
            dgvPlaces.ReadOnly = true;
            dgvPlaces.RowHeadersWidth = 62;
            dgvPlaces.RowTemplate.Height = 33;
            dgvPlaces.Size = new Size(395, 674);
            dgvPlaces.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Placements:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 31);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Best lap time:";
            // 
            // tbLapTime
            // 
            tbLapTime.Location = new Point(449, 59);
            tbLapTime.Name = "tbLapTime";
            tbLapTime.ReadOnly = true;
            tbLapTime.Size = new Size(279, 31);
            tbLapTime.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(518, 396);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 62);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add statistics";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(518, 464);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 62);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit statistics";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(635, 677);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(518, 532);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(138, 62);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset statistics";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(413, 650);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 61);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tbxFinishTime
            // 
            tbxFinishTime.Location = new Point(449, 132);
            tbxFinishTime.Name = "tbxFinishTime";
            tbxFinishTime.ReadOnly = true;
            tbxFinishTime.Size = new Size(279, 31);
            tbxFinishTime.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 104);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 10;
            label3.Text = "Best finish time:";
            // 
            // tbxMaxSpeed
            // 
            tbxMaxSpeed.Location = new Point(449, 206);
            tbxMaxSpeed.Name = "tbxMaxSpeed";
            tbxMaxSpeed.ReadOnly = true;
            tbxMaxSpeed.Size = new Size(279, 31);
            tbxMaxSpeed.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 178);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 12;
            label4.Text = "Fastest max speed:";
            // 
            // tbxAverageSpeed
            // 
            tbxAverageSpeed.Location = new Point(449, 276);
            tbxAverageSpeed.Name = "tbxAverageSpeed";
            tbxAverageSpeed.ReadOnly = true;
            tbxAverageSpeed.Size = new Size(279, 31);
            tbxAverageSpeed.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 248);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 14;
            label5.Text = "Fastest average speed:";
            // 
            // GPStatistics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 723);
            Controls.Add(tbxAverageSpeed);
            Controls.Add(label5);
            Controls.Add(tbxMaxSpeed);
            Controls.Add(label4);
            Controls.Add(tbxFinishTime);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tbLapTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPlaces);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(781, 779);
            MinimizeBox = false;
            MinimumSize = new Size(781, 779);
            Name = "GPStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPStatistics";
            ((System.ComponentModel.ISupportInitialize)dgvPlaces).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlaces;
        private Label label1;
        private Label label2;
        private TextBox tbLapTime;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClose;
        private Button btnReset;
        private Button btnRefresh;
        private TextBox tbxFinishTime;
        private Label label3;
        private TextBox tbxMaxSpeed;
        private Label label4;
        private TextBox tbxAverageSpeed;
        private Label label5;
    }
}