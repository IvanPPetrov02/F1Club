using DAL;
using LL;
using LL.Profile_related;
using LL.Team_related;
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
using static LL.Profile_related.ProfileManager;

namespace F1Club.Profile_pages
{
    public partial class ProfileMainPage : UserControl
    {
        ProfileManager profileManager = new ProfileManager(new ProfileDAO());
        DataTable dt = new DataTable();

        public ProfileMainPage()
        {
            InitializeComponent();
            Initialize();
            LoadComboboxes();
            dataGridProfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Initialize()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Email");
            dt.Columns.Add("First name");
            dt.Columns.Add("Last name");
            dt.Columns.Add("Date of birth");
            dt.Columns.Add("Phone number");
            dt.Columns.Add("User type");

            LoadProfiles();
        }

        private void LoadProfiles()
        {
            cbxUserTypes.SelectedItem = "All";

            dt.Clear();

            var profiles = profileManager.GetAllProfiles();
            foreach (Profile profile in profiles)
            {
                dt.Rows.Add(profile.ID, profile.Email, profile.FirstName, profile.LastName, profile.DateOfBirth, profile.PhoneNumber, profile.UserType);
            }

            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();

            var profiles = profileManager.GetAllProfilesRefresh();
            foreach (Profile profile in profiles)
            {
                dt.Rows.Add(profile.ID, profile.Email, profile.FirstName, profile.LastName, profile.DateOfBirth, profile.PhoneNumber, profile.UserType);
            }

            dataGridProfiles.DataSource = null;
            dataGridProfiles.DataSource = dt;
            dataGridProfiles.Columns["ID"].Visible = false;
        }

        private void LoadComboboxes()
        {
            List<string> userTypes = new List<string> { "All" }.Concat(Enum.GetValues(typeof(UserType)).Cast<UserType>().Select(t => t.ToString())).ToList();
            cbxUserTypes.DataSource = userTypes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProfile addProfile = new AddProfile();
            addProfile.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridProfiles.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this profile?", "Delete profile", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridProfiles.SelectedRows[0].Cells["ID"].Value);
                    try
                    {
                        profileManager.DeleteProfile(ID);
                        MessageBox.Show("Profile deleted.");
                        ReLoadData();
                    }
                    catch (DatabaseNotAccessibleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong! Try again later.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select only one profile!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridProfiles.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridProfiles.SelectedRows[0].Cells["ID"].Value);
                Profile selectedProfile = profileManager.GetProfileByID(ID);
                if (selectedProfile.UserType != UserType.Member)
                {
                    if (selectedProfile != null)
                    {
                        EditProfile editProfile = new EditProfile(selectedProfile);
                        editProfile.ShowDialog();
                        ReLoadData();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong! Try again later.");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot edit members data! Try again with other user type.");
                }

            }
            else
            {
                MessageBox.Show("Select only one profile you want to edit!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProfiles();
        }

        private void cbxUserTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = (string)cbxUserTypes.SelectedItem;

            if (selectedUserType == "All")
            {
                dataGridProfiles.DataSource = dt;
            }
            else
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = $"[User type] = '{selectedUserType}'";
                dataGridProfiles.DataSource = dv;
            }
        }
    }
}
