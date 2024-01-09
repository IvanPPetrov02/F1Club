namespace F1Club.GP_pages
{
    partial class CircuitMainPage
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
            dataGridCircuits = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCircuits).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1251, 657);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 21;
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
            btnDelete.Size = new Size(207, 57);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete selected circuit";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(430, 656);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(193, 57);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit selected circuit";
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
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add new circuit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridCircuits
            // 
            dataGridCircuits.AllowUserToAddRows = false;
            dataGridCircuits.AllowUserToDeleteRows = false;
            dataGridCircuits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCircuits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCircuits.Location = new Point(17, 53);
            dataGridCircuits.Margin = new Padding(3, 4, 3, 4);
            dataGridCircuits.Name = "dataGridCircuits";
            dataGridCircuits.ReadOnly = true;
            dataGridCircuits.RowHeadersWidth = 51;
            dataGridCircuits.RowTemplate.Height = 25;
            dataGridCircuits.Size = new Size(1331, 596);
            dataGridCircuits.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 16;
            label1.Text = "Circuits";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CircuitMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridCircuits);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CircuitMainPage";
            Size = new Size(1366, 727);
            ((System.ComponentModel.ISupportInitialize)dataGridCircuits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridCircuits;
        private Label label1;
    }
}
