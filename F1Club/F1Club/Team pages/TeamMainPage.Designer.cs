namespace F1Club.Team_pages
{
    partial class TeamMainPage
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
            label1 = new Label();
            btnRefresh = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridTeams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTeams).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 15;
            label1.Text = "Teams";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1255, 661);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(229, 663);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(97, 57);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(125, 663);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 57);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(21, 663);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 57);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridTeams
            // 
            dataGridTeams.AllowUserToAddRows = false;
            dataGridTeams.AllowUserToDeleteRows = false;
            dataGridTeams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTeams.Location = new Point(21, 57);
            dataGridTeams.Margin = new Padding(3, 4, 3, 4);
            dataGridTeams.Name = "dataGridTeams";
            dataGridTeams.ReadOnly = true;
            dataGridTeams.RowHeadersWidth = 51;
            dataGridTeams.RowTemplate.Height = 25;
            dataGridTeams.Size = new Size(1331, 596);
            dataGridTeams.TabIndex = 10;
            // 
            // TeamMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridTeams);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeamMainPage";
            Size = new Size(1366, 727);
            ((System.ComponentModel.ISupportInitialize)dataGridTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRefresh;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridTeams;
    }
}
