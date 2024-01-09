namespace F1Club.Driver_pages
{
    partial class DriverMainPage
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
            dataGridDrivers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridDrivers).BeginInit();
            SuspendLayout();
            // 
            // dataGridDrivers
            // 
            dataGridDrivers.AllowUserToAddRows = false;
            dataGridDrivers.AllowUserToDeleteRows = false;
            dataGridDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDrivers.Location = new Point(21, 57);
            dataGridDrivers.Margin = new Padding(3, 4, 3, 4);
            dataGridDrivers.Name = "dataGridDrivers";
            dataGridDrivers.ReadOnly = true;
            dataGridDrivers.RowHeadersWidth = 51;
            dataGridDrivers.RowTemplate.Height = 25;
            dataGridDrivers.Size = new Size(1331, 596);
            dataGridDrivers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(21, 661);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 57);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(125, 661);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 57);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(229, 661);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(97, 57);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(1255, 661);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 57);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 9;
            label1.Text = "Drivers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DriverMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridDrivers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DriverMainPage";
            Size = new Size(1366, 727);
            ((System.ComponentModel.ISupportInitialize)dataGridDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridDrivers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnRefresh;
        private Label label1;
    }
}
