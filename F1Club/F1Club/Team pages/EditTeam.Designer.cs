namespace F1Club.Team_pages
{
    partial class EditTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeam));
            dtpCreationDate = new DateTimePicker();
            tbxName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // dtpCreationDate
            // 
            dtpCreationDate.Format = DateTimePickerFormat.Short;
            dtpCreationDate.Location = new Point(248, 45);
            dtpCreationDate.Margin = new Padding(4, 5, 4, 5);
            dtpCreationDate.Name = "dtpCreationDate";
            dtpCreationDate.Size = new Size(195, 31);
            dtpCreationDate.TabIndex = 64;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(17, 45);
            tbxName.Margin = new Padding(4, 5, 4, 5);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(200, 31);
            tbxName.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 62;
            label4.Text = "Creation date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 60;
            label1.Text = "Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(283, 123);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 53);
            btnCancel.TabIndex = 67;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(50, 123);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 53);
            btnEdit.TabIndex = 66;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 219);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(dtpCreationDate);
            Controls.Add(tbxName);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(482, 275);
            MinimizeBox = false;
            MinimumSize = new Size(482, 275);
            Name = "EditTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTeam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpCreationDate;
        private TextBox tbxName;
        private Label label4;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
    }
}