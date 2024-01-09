namespace F1Club.Profile_pages
{
    partial class EditProfile
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
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            cbxUserTypes = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            tbxFName = new TextBox();
            tbxLName = new TextBox();
            label2 = new Label();
            tbxPhone = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(100, 141);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(138, 23);
            dtpDateOfBirth.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 123);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 68;
            label3.Text = "Date of birth:";
            // 
            // cbxUserTypes
            // 
            cbxUserTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUserTypes.FormattingEnabled = true;
            cbxUserTypes.Location = new Point(179, 86);
            cbxUserTypes.Name = "cbxUserTypes";
            cbxUserTypes.Size = new Size(138, 23);
            cbxUserTypes.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 68);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 56;
            label6.Text = "User type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 14);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 55;
            label5.Text = "Phone number:";
            // 
            // tbxFName
            // 
            tbxFName.Location = new Point(12, 32);
            tbxFName.Name = "tbxFName";
            tbxFName.Size = new Size(141, 23);
            tbxFName.TabIndex = 54;
            // 
            // tbxLName
            // 
            tbxLName.Location = new Point(12, 86);
            tbxLName.Name = "tbxLName";
            tbxLName.Size = new Size(141, 23);
            tbxLName.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 52;
            label2.Text = "Last Name:";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(179, 32);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(138, 23);
            tbxPhone.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 50;
            label1.Text = "First Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(32, 197);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 32);
            btnEdit.TabIndex = 48;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 255);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label3);
            Controls.Add(cbxUserTypes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxFName);
            Controls.Add(tbxLName);
            Controls.Add(label2);
            Controls.Add(tbxPhone);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            MaximumSize = new Size(350, 294);
            MinimumSize = new Size(350, 294);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private ComboBox cbxUserTypes;
        private Label label6;
        private Label label5;
        private TextBox tbxFName;
        private TextBox tbxLName;
        private Label label2;
        private TextBox tbxPhone;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
    }
}