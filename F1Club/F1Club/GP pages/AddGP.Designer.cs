namespace F1Club.GP_pages
{
	partial class AddGP
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
			label5 = new Label();
			btnCancel = new Button();
			btnAdd = new Button();
			dtpDateOfGP = new DateTimePicker();
			label3 = new Label();
			cbxCircuits = new ComboBox();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 9);
			label5.Name = "label5";
			label5.Size = new Size(45, 15);
			label5.TabIndex = 57;
			label5.Text = "Circuit:";
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(183, 71);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(93, 32);
			btnCancel.TabIndex = 53;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(41, 71);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(93, 32);
			btnAdd.TabIndex = 52;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// dtpDateOfGP
			// 
			dtpDateOfGP.Format = DateTimePickerFormat.Short;
			dtpDateOfGP.Location = new Point(161, 27);
			dtpDateOfGP.Name = "dtpDateOfGP";
			dtpDateOfGP.Size = new Size(138, 23);
			dtpDateOfGP.TabIndex = 63;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(164, 9);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 62;
			label3.Text = "Date of GP:";
			// 
			// cbxCircuits
			// 
			cbxCircuits.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCircuits.FormattingEnabled = true;
			cbxCircuits.Location = new Point(12, 27);
			cbxCircuits.Name = "cbxCircuits";
			cbxCircuits.Size = new Size(138, 23);
			cbxCircuits.TabIndex = 64;
			// 
			// AddGP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 131);
			Controls.Add(cbxCircuits);
			Controls.Add(dtpDateOfGP);
			Controls.Add(label3);
			Controls.Add(label5);
			Controls.Add(btnCancel);
			Controls.Add(btnAdd);
			MaximizeBox = false;
			MaximumSize = new Size(336, 170);
			MinimizeBox = false;
			MinimumSize = new Size(336, 170);
			Name = "AddGP";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AddGP";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label5;
		private TextBox tbxName;
		private Label label1;
		private Button btnCancel;
		private Button btnAdd;
		private DateTimePicker dtpDateOfGP;
		private Label label3;
		private ComboBox cbxCircuits;
	}
}