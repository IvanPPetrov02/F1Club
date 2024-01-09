namespace F1Club
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            label1 = new Label();
            tbxEmail = new TextBox();
            tbxPassword = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(52, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 30);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.Location = new Point(52, 82);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(192, 27);
            tbxEmail.TabIndex = 2;
            tbxEmail.Text = "ivanpetrov@email.com";
            tbxEmail.KeyDown += tbxEmail_KeyDown;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(52, 144);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(192, 27);
            tbxPassword.TabIndex = 4;
            tbxPassword.Text = "Ivan1234";
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.KeyDown += tbxPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 121);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(158, 223);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 336);
            Controls.Add(btnExit);
            Controls.Add(tbxPassword);
            Controls.Add(label2);
            Controls.Add(tbxEmail);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(312, 375);
            MinimizeBox = false;
            MinimumSize = new Size(312, 375);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F1Club";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox tbxEmail;
        private TextBox tbxPassword;
        private Label label2;
        private Button btnExit;
    }
}