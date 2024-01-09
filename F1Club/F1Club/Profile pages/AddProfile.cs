using DAL;
using LL.Profile_related;
using LL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.ProfileDAO;
using static LL.Profile_related.ProfileManager;
using static LL.Exceptions;

namespace F1Club.Profile_pages
{
    public partial class AddProfile : Form
    {
        ProfileManager profileManager = new ProfileManager(new ProfileDAO());

        public AddProfile()
        {
            InitializeComponent();
			LoadUserTypes();

		}

        public void LoadUserTypes()
        {
            cbxUserTypes.DataSource = null;
            cbxUserTypes.DataSource = Enum.GetValues(typeof(UserType)).Cast<UserType>().Where(e => e != UserType.Member).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxPhone.Text) || string.IsNullOrEmpty(tbxLName.Text) || string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrEmpty(tbxFName.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }
            else
            {
                string fName = tbxFName.Text;
                string lName = tbxLName.Text;
                string password = tbxPassword.Text;
                string phone = tbxPhone.Text;
                DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                UserType userType = (UserType)cbxUserTypes.SelectedItem;
                string email = profileManager.CreateEmail(fName, lName);

                try
                {
					profileManager.CreateProfile(new Profile(0, email, password, fName, lName, dateOfBirth, phone, userType));
					MessageBox.Show($"Success! User created! The email is: {email}");
					Close();
				}
                catch (DataLengthException ex)
                {
					MessageBox.Show(ex.Message);
					tbxPhone.Clear();
					tbxLName.Clear();
					tbxPassword.Clear();
					tbxFName.Clear();
				}
				catch (DatabaseNotAccessibleException ex)
				{
					MessageBox.Show(ex.Message);
					tbxPhone.Clear();
					tbxLName.Clear();
					tbxPassword.Clear();
					tbxFName.Clear();
				}
				catch (DuplicateEmailException ex)
				{
					MessageBox.Show(ex.Message);
					tbxPhone.Clear();
					tbxLName.Clear();
					tbxPassword.Clear();
					tbxFName.Clear();
				}
				catch (InvalidDateOfBirth ex)
				{
					MessageBox.Show(ex.Message);
					tbxPhone.Clear();
					tbxLName.Clear();
					tbxPassword.Clear();
					tbxFName.Clear();
				}
			}
        }
    }
}
