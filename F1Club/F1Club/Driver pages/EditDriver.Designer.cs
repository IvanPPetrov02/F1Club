namespace F1Club.Driver_pages
{
    partial class EditDriver
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
            cbxTeams = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            tbxFName = new TextBox();
            label4 = new Label();
            tbxLName = new TextBox();
            label2 = new Label();
            tbxNumber = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // cbxTeams
            // 
            cbxTeams.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTeams.FormattingEnabled = true;
            cbxTeams.Location = new Point(95, 132);
            cbxTeams.Name = "cbxTeams";
            cbxTeams.Size = new Size(138, 23);
            cbxTeams.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 114);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 58;
            label6.Text = "Team:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 9);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 57;
            label5.Text = "Number:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(176, 81);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(138, 23);
            dtpDateOfBirth.TabIndex = 56;
            // 
            // tbxFName
            // 
            tbxFName.Location = new Point(12, 27);
            tbxFName.Name = "tbxFName";
            tbxFName.Size = new Size(141, 23);
            tbxFName.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 63);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 54;
            label4.Text = "Date of birth:";
            // 
            // tbxLName
            // 
            tbxLName.Location = new Point(12, 81);
            tbxLName.Name = "tbxLName";
            tbxLName.Size = new Size(141, 23);
            tbxLName.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 52;
            label2.Text = "Last Name:";
            // 
            // tbxNumber
            // 
            tbxNumber.Location = new Point(176, 27);
            tbxNumber.Name = "tbxNumber";
            tbxNumber.Size = new Size(141, 23);
            tbxNumber.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 50;
            label1.Text = "First Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(192, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(29, 176);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 32);
            btnEdit.TabIndex = 60;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 240);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(cbxTeams);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(tbxFName);
            Controls.Add(label4);
            Controls.Add(tbxLName);
            Controls.Add(label2);
            Controls.Add(tbxNumber);
            Controls.Add(label1);
            MaximumSize = new Size(348, 279);
            MinimumSize = new Size(348, 279);
            Name = "EditDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDriver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxTeams;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbxFName;
        private Label label4;
        private TextBox tbxLName;
        private Label label2;
        private TextBox tbxNumber;
        private Label label1;
        private Button btnCancel;
        private Button btnEdit;
    }
}