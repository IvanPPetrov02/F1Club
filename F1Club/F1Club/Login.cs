using DAL;
using LL;
using LL.Profile_related;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LL.Exceptions;

namespace F1Club
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ActiveControl = tbxEmail;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProfileManager profileManager = new ProfileManager(new ProfileDAO());
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    Profile profile = profileManager.Login(email, password);
                    if (profile != null)
                    {
                        if (profile.UserType != UserType.Member)
                        {
                            MainForm mainform = new MainForm(profile);
                            mainform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("This app is administration only!");
                            tbxPassword.Text = null;
                            tbxEmail.Text = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong email or password");
                        tbxPassword.Text = null;
                    }
                }
                catch (DatabaseNotAccessibleException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxPassword.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields to log in.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
