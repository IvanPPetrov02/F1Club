namespace F1Club.Profile_pages
{
    partial class ProfileMainPage
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
            label2 = new Label();
            cbxUserTypes = new ComboBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridProfiles = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProfiles).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(985, 20);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 15;
            label2.Text = "Filter by user types:\r\n";
            // 
            // cbxUserTypes
            // 
            cbxUserTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUserTypes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxUserTypes.FormattingEnabled = true;
            cbxUserTypes.Location = new Point(1169, 16);
            cbxUserTypes.Margin = new Padding(3, 4, 3, 4);
            cbxUserTypes.Name = "cbxUserTypes";
            cbxUserTypes.Size = new Size(182, 33);
            cbxUserTypes.TabIndex = 14;
            cbxUserTypes.SelectedIndexChanged += cbxUserTypes_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1255, 661);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(221, 660);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 57);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete selected profile";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(436, 660);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(193, 57);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit selected profile";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(21, 660);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 57);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add new profile";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridProfiles
            // 
            dataGridProfiles.AllowUserToAddRows = false;
            dataGridProfiles.AllowUserToDeleteRows = false;
            dataGridProfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProfiles.Location = new Point(21, 57);
            dataGridProfiles.Margin = new Padding(3, 4, 3, 4);
            dataGridProfiles.Name = "dataGridProfiles";
            dataGridProfiles.ReadOnly = true;
            dataGridProfiles.RowHeadersWidth = 51;
            dataGridProfiles.RowTemplate.Height = 25;
            dataGridProfiles.Size = new Size(1331, 596);
            dataGridProfiles.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 8;
            label1.Text = "Profiles";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(cbxUserTypes);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridProfiles);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfileMainPage";
            Size = new Size(1366, 727);
            ((System.ComponentModel.ISupportInitialize)dataGridProfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbxUserTypes;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridProfiles;
        private Label label1;
    }
}