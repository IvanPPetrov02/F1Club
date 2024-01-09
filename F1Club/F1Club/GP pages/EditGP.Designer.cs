namespace F1Club.GP_pages
{
	partial class EditGP
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
			cbxCircuits = new ComboBox();
			dtpDateOfGP = new DateTimePicker();
			label3 = new Label();
			label5 = new Label();
			btnCancel = new Button();
			btnEdit = new Button();
			SuspendLayout();
			// 
			// cbxCircuits
			// 
			cbxCircuits.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCircuits.FormattingEnabled = true;
			cbxCircuits.Location = new Point(12, 27);
			cbxCircuits.Name = "cbxCircuits";
			cbxCircuits.Size = new Size(138, 23);
			cbxCircuits.TabIndex = 68;
			// 
			// dtpDateOfGP
			// 
			dtpDateOfGP.Format = DateTimePickerFormat.Short;
			dtpDateOfGP.Location = new Point(161, 27);
			dtpDateOfGP.Name = "dtpDateOfGP";
			dtpDateOfGP.Size = new Size(138, 23);
			dtpDateOfGP.TabIndex = 67;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(164, 9);
			label3.Name = "label3";
			label3.Size = new Size(66, 15);
			label3.TabIndex = 66;
			label3.Text = "Date of GP:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 9);
			label5.Name = "label5";
			label5.Size = new Size(45, 15);
			label5.TabIndex = 65;
			label5.Text = "Circuit:";
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(181, 70);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(93, 32);
			btnCancel.TabIndex = 70;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(40, 70);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(93, 32);
			btnEdit.TabIndex = 69;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// EditGP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 131);
			Controls.Add(btnCancel);
			Controls.Add(btnEdit);
			Controls.Add(cbxCircuits);
			Controls.Add(dtpDateOfGP);
			Controls.Add(label3);
			Controls.Add(label5);
			MaximizeBox = false;
			MaximumSize = new Size(336, 170);
			MinimizeBox = false;
			MinimumSize = new Size(336, 170);
			Name = "EditGP";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EditGP";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbxCircuits;
		private DateTimePicker dtpDateOfGP;
		private Label label3;
		private Label label5;
		private Button btnCancel;
		private Button btnEdit;
	}
}