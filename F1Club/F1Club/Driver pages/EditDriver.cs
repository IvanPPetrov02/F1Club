using DAL.Driver_DAOs_classes;
using LL.Driver_related;
using LL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LL.Team_related;
using DAL.Team_DAOs_classes;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace F1Club.Driver_pages
{
    public partial class EditDriver : Form
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());
        TeamManager teamManager = new TeamManager(new TeamDAO());
        Driver _driver;

        public EditDriver(Driver driver)
        {
            InitializeComponent();

            tbxNumber.Text = driver.Number.ToString();
            tbxFName.Text = driver.FirstName;
            tbxLName.Text = driver.LastName;
            dtpDateOfBirth.Text = driver.DateOfBirth.ToString();
            LoadTeams();
            cbxTeams.SelectedItem = driver.Team;

            _driver = driver;
        }

        private void LoadTeams()
        {
            List<Team>? teams = teamManager.GetAllTeamsRefresh();
            cbxTeams.DataSource = teams;
            cbxTeams.DisplayMember = "Name";
            cbxTeams.ValueMember = "ID";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(tbxNumber.Text, out int n);
            if (!isNumeric)
            {
                MessageBox.Show("Number must be a number.");
                return;
            }

            int number = Convert.ToInt32(tbxNumber.Text);
            if (number < 0 || number > 999)
            {
                MessageBox.Show("Number must be between 1 and 999.");
                return;
            }
            string firstName = tbxFName.Text;
            string lastName = tbxLName.Text;
            DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            Team team = (Team)cbxTeams.SelectedItem;

            Driver updatedDriver = new Driver(_driver.ID, number, firstName, lastName, dateOfBirth, team);

            try
            {
                driverManager.UpdateDriver(updatedDriver);
                MessageBox.Show("Driver updated successfully.");
                Close();
            }
            catch (DataLengthException ex)
            {
                MessageBox.Show(ex.Message);
                tbxLName.Clear();
                tbxFName.Clear();
                tbxNumber.Clear();
            }
            catch (DatabaseNotAccessibleException ex)
            {
                MessageBox.Show(ex.Message);
                tbxLName.Clear();
                tbxFName.Clear();
                tbxNumber.Clear();
            }
            catch (DuplicateEmailException ex)
            {
                MessageBox.Show(ex.Message);
                tbxLName.Clear();
                tbxFName.Clear();
                tbxNumber.Clear();
            }
            catch (InvalidDateOfBirth ex)
            {
                MessageBox.Show(ex.Message);
                tbxLName.Clear();
                tbxFName.Clear();
                tbxNumber.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
