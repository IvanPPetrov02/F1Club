namespace F1Club.GP_pages
{
    partial class GPMainPage
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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridGP = new DataGridView();
            label1 = new Label();
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridGP).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1251, 656);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(217, 656);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(193, 57);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete selected GP";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(417, 656);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(193, 57);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit selected GP";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(17, 656);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(193, 57);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add new GP";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridGP
            // 
            dataGridGP.AllowUserToAddRows = false;
            dataGridGP.AllowUserToDeleteRows = false;
            dataGridGP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridGP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGP.Location = new Point(17, 53);
            dataGridGP.Margin = new Padding(3, 4, 3, 4);
            dataGridGP.Name = "dataGridGP";
            dataGridGP.ReadOnly = true;
            dataGridGP.RowHeadersWidth = 51;
            dataGridGP.RowTemplate.Height = 25;
            dataGridGP.Size = new Size(1331, 596);
            dataGridGP.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 22;
            label1.Text = "Grand Prix";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            btnInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.Location = new Point(880, 656);
            btnInfo.Margin = new Padding(3, 4, 3, 4);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(193, 57);
            btnInfo.TabIndex = 28;
            btnInfo.Text = "Show more info for selected GP\r\n\r\n";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // GPMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnInfo);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridGP);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GPMainPage";
            Size = new Size(1366, 727);
            ((System.ComponentModel.ISupportInitialize)dataGridGP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridGP;
        private Label label1;
        private Button btnInfo;
    }
}
