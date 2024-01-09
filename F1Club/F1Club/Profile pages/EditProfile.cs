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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LL.Profile_related.ProfileManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static LL.Exceptions;

namespace F1Club.Profile_pages
{
    public partial class EditProfile : Form
    {
        ProfileManager profileManager = new ProfileManager(new ProfileDAO());
        Profile _profile = new();

        public EditProfile(Profile profile)
        {
            InitializeComponent();
            LoadUserTypes();

            tbxFName.Text = profile.FirstName;
            tbxLName.Text = profile.LastName;
            tbxPhone.Text = profile.PhoneNumber;
            cbxUserTypes.SelectedItem = profile.UserType;
            dtpDateOfBirth.Text = profile.DateOfBirth.ToString();
            _profile = profile;
        }

        public void LoadUserTypes()
        {
            cbxUserTypes.DataSource = null;
            cbxUserTypes.DataSource = Enum.GetValues(typeof(UserType)).Cast<UserType>().Where(e => e != UserType.Member).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFName.Text) || string.IsNullOrEmpty(tbxLName.Text) || string.IsNullOrEmpty(tbxPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                string fName = tbxFName.Text;
                string lName = tbxLName.Text;
                string phone = tbxPhone.Text;
                DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                UserType userType = (UserType)cbxUserTypes.SelectedItem;

                try
                {
                    profileManager.UpdateProfile(new Profile(_profile.ID, _profile.Email, fName, lName, dateOfBirth, phone, userType), _profile.Email);
                    MessageBox.Show($"Success! User {_profile.Email} updated!");
                    Close();
                }
                catch (DataLengthException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxPhone.Clear();
                    tbxLName.Clear();
                    tbxFName.Clear();
                }
                catch (DatabaseNotAccessibleException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxPhone.Clear();
                    tbxLName.Clear();
                    tbxFName.Clear();
                }
                catch (DuplicateEmailException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxPhone.Clear();
                    tbxLName.Clear();
                    tbxFName.Clear();
                }
                catch (InvalidDateOfBirth ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxPhone.Clear();
                    tbxLName.Clear();
                    tbxFName.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
