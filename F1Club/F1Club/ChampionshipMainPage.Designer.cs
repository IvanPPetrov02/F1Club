namespace F1Club
{
    partial class ChampionshipMainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            cbxYears = new ComboBox();
            btnRefresh = new Button();
            dataGridChampionshipResults = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridChampionshipResults).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1162, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 23;
            label2.Text = "Filter by year:\r\n";
            // 
            // cbxYears
            // 
            cbxYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxYears.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxYears.FormattingEnabled = true;
            cbxYears.Location = new Point(1320, 13);
            cbxYears.Margin = new Padding(4, 5, 4, 5);
            cbxYears.Name = "cbxYears";
            cbxYears.Size = new Size(226, 39);
            cbxYears.TabIndex = 22;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1565, 9);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 44);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridChampionshipResults
            // 
            dataGridChampionshipResults.AllowUserToAddRows = false;
            dataGridChampionshipResults.AllowUserToDeleteRows = false;
            dataGridChampionshipResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridChampionshipResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChampionshipResults.Location = new Point(22, 67);
            dataGridChampionshipResults.Margin = new Padding(4, 5, 4, 5);
            dataGridChampionshipResults.Name = "dataGridChampionshipResults";
            dataGridChampionshipResults.ReadOnly = true;
            dataGridChampionshipResults.RowHeadersWidth = 51;
            dataGridChampionshipResults.RowTemplate.Height = 25;
            dataGridChampionshipResults.Size = new Size(1664, 824);
            dataGridChampionshipResults.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(22, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 31);
            label1.TabIndex = 16;
            label1.Text = "Championships' results";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChampionshipMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(cbxYears);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridChampionshipResults);
            Controls.Add(label1);
            Name = "ChampionshipMainPage";
            Size = new Size(1708, 909);
            ((System.ComponentModel.ISupportInitialize)dataGridChampionshipResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbxYears;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridChampionshipResults;
        private Label label1;
    }
}
