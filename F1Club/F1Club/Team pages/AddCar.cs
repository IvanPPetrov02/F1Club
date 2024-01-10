using LL.Team_related;
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
using DAL.Team_DAOs_classes;
using DAL.Car_DAOs_classes;

namespace F1Club.Team_pages
{
    public partial class AddCar : Form
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        CarManager carManager = new CarManager(new CarDAO());
        public AddCar()
        {
            InitializeComponent();
            LoadTeams();
            dtpSeason.CustomFormat = "yyyy";
            dtpSeason.ShowUpDown = true;
            if (cbxTeams.Items.Count > 0)
            {
                cbxTeams.SelectedIndex = 0;
            }
        }
        private void LoadTeams()
        {
            List<Team>? teams = teamManager.GetAllTeamsRefresh();
            cbxTeams.DataSource = teams;
            cbxTeams.DisplayMember = "Name";
            cbxTeams.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxTeams.SelectedItem == null)
            {
                MessageBox.Show("Please select a team!");
                return;
            }
            if (string.IsNullOrEmpty(tbxChasis.Text) || string.IsNullOrEmpty(tbxEngine.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }

            Team team = (Team)cbxTeams.SelectedItem;
            DateOnly seasonUsed = DateOnly.FromDateTime(dtpSeason.Value.Date);

            if (TeamHasCarForYear(team.ID, seasonUsed.Year))
            {
                MessageBox.Show($"The team {team.Name} already has a car registered for the season {seasonUsed.Year}. Please change the year or the team.", "Car Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chassis = tbxChasis.Text;
            string engine = tbxEngine.Text;
            double handlingScore = (double)nudHandling.Value;
            double accelerationScore = (double)nudAcceleration.Value;
            double breakingScore = (double)nudBreaking.Value;
            int topSpeedPossible = (int)nudTopSpeed.Value;

            Car car = new Car(0,team, seasonUsed, chassis, engine, handlingScore, accelerationScore, breakingScore, topSpeedPossible);
            carManager.AddCar(car);

            MessageBox.Show("Car added!");
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool TeamHasCarForYear(int teamId, int year)
        {
            Dictionary<DateOnly, List<int>> TeamsHaveCarForSeason = new Dictionary<DateOnly, List<int>>();
            TeamsHaveCarForSeason = carManager.TeamsHaveCarForSeason();
            return TeamsHaveCarForSeason.TryGetValue(new DateOnly(year, 1, 1), out List<int> teams) && teams.Contains(teamId);
        }

    }
}
