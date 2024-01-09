namespace F1Club.Driver_pages
{
    partial class AddDriver
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
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cbxTeams
            // 
            cbxTeams.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTeams.FormattingEnabled = true;
            cbxTeams.Location = new Point(105, 145);
            cbxTeams.Name = "cbxTeams";
            cbxTeams.Size = new Size(138, 23);
            cbxTeams.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 127);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 48;
            label6.Text = "Team:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 22);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 47;
            label5.Text = "Number:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(186, 94);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(138, 23);
            dtpDateOfBirth.TabIndex = 46;
            // 
            // tbxFName
            // 
            tbxFName.Location = new Point(22, 40);
            tbxFName.Name = "tbxFName";
            tbxFName.Size = new Size(141, 23);
            tbxFName.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 76);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 44;
            label4.Text = "Date of birth:";
            // 
            // tbxLName
            // 
            tbxLName.Location = new Point(22, 94);
            tbxLName.Name = "tbxLName";
            tbxLName.Size = new Size(141, 23);
            tbxLName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 40;
            label2.Text = "Last Name:";
            // 
            // tbxNumber
            // 
            tbxNumber.Location = new Point(186, 40);
            tbxNumber.Name = "tbxNumber";
            tbxNumber.Size = new Size(141, 23);
            tbxNumber.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 38;
            label1.Text = "First Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(205, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 32);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(42, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 32);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddDriver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 257);
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
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            MaximumSize = new Size(368, 296);
            MinimumSize = new Size(368, 296);
            Name = "AddDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDriver";
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
        private Button btnAdd;
    }
}