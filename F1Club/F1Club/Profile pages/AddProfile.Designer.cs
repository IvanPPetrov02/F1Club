namespace F1Club.Profile_pages
{
    partial class AddProfile
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
            cbxUserTypes = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            tbxFName = new TextBox();
            label4 = new Label();
            tbxPassword = new TextBox();
            label3 = new Label();
            tbxLName = new TextBox();
            label2 = new Label();
            tbxPhone = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cbxUserTypes
            // 
            cbxUserTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUserTypes.FormattingEnabled = true;
            cbxUserTypes.Location = new Point(176, 141);
            cbxUserTypes.Name = "cbxUserTypes";
            cbxUserTypes.Size = new Size(138, 23);
            cbxUserTypes.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 123);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 34;
            label6.Text = "User type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 14);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 33;
            label5.Text = "Phone number:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(176, 86);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(138, 23);
            dtpDateOfBirth.TabIndex = 32;
            // 
            // tbxFName
            // 
            tbxFName.Location = new Point(12, 32);
            tbxFName.Name = "tbxFName";
            tbxFName.Size = new Size(141, 23);
            tbxFName.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 68);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 30;
            label4.Text = "Date of birth:";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(12, 141);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(141, 23);
            tbxPassword.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 28;
            label3.Text = "Password:";
            // 
            // tbxLName
            // 
            tbxLName.Location = new Point(12, 86);
            tbxLName.Name = "tbxLName";
            tbxLName.Size = new Size(141, 23);
            tbxLName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 26;
            label2.Text = "Last Name:";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(176, 32);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(141, 23);
            tbxPhone.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 24;
            label1.Text = "First Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 189);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 32);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 252);
            Controls.Add(cbxUserTypes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(tbxFName);
            Controls.Add(label4);
            Controls.Add(tbxPassword);
            Controls.Add(label3);
            Controls.Add(tbxLName);
            Controls.Add(label2);
            Controls.Add(tbxPhone);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            MaximumSize = new Size(354, 291);
            MinimumSize = new Size(354, 291);
            Name = "AddProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxUserTypes;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbxFName;
        private Label label4;
        private TextBox tbxPassword;
        private Label label3;
        private TextBox tbxLName;
        private Label label2;
        private TextBox tbxPhone;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
    }
}