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

namespace F1Club.Driver_pages
{
    public partial class AddDriver : Form
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());
        TeamManager teamManager = new TeamManager(new TeamDAO());

        public AddDriver()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            List<Team>? teams = teamManager.GetAllTeamsRefresh();
            cbxTeams.DataSource = teams;
            cbxTeams.DisplayMember = "Name";
            cbxTeams.ValueMember = "ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNumber.Text) || string.IsNullOrEmpty(tbxFName.Text) || string.IsNullOrEmpty(tbxLName.Text) || cbxTeams.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }

            if (!int.TryParse(tbxNumber.Text, out int number) || number < 1 || number > 999)
            {
                MessageBox.Show("Number must be between 1 and 999.");
                return;
            }

            string firstName = tbxFName.Text;
            string lastName = tbxLName.Text;
            DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            Team team = (Team)cbxTeams.SelectedItem;

            Driver driver = new Driver(0, number, firstName, lastName, dateOfBirth, team);

            try
            {
                driverManager.CreateDriver(driver);
                MessageBox.Show($"Driver {firstName} {lastName} added successfully!");
                Close();
            }
            catch (DataLengthException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (DatabaseNotAccessibleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
