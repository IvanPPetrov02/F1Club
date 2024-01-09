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
        Dictionary<DateOnly, List<int>> TeamsHaveCarForSeason = new Dictionary<DateOnly, List<int>>();
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
            TeamsHaveCarForSeason = carManager.TeamsHaveCarForSeason();
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
            else
            {
                int id = 0;
                Team team = (Team)cbxTeams.SelectedItem;
                DateOnly seasonUsed = DateOnly.FromDateTime(dtpSeason.Value.Date);
                string chassis = tbxChasis.Text;
                string engine = tbxEngine.Text;
                double handlingScore = (double)nudHandling.Value;
                double accelerationScore = (double)nudAcceleration.Value;
                double breakingScore = (double)nudBreaking.Value;
                int topSpeedPossible = (int)nudTopSpeed.Value;
                Car car = new Car(id, team, seasonUsed, chassis, engine, handlingScore, accelerationScore, breakingScore, topSpeedPossible);
                carManager.AddCar(car);
                MessageBox.Show("Car added!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTeams.SelectedValue is int selectedTeamId)
            {
                UpdateSeasonPicker(selectedTeamId);
            }
        }

        private void UpdateSeasonPicker(int teamId)
        {
            int currentYear = dtpSeason.Value.Year;
            dtpSeason.MinDate = new DateTime(currentYear - 10, 1, 1);
            dtpSeason.MaxDate = new DateTime(currentYear + 10, 1, 1);

            if (TeamsHaveCarForSeason.TryGetValue(new DateOnly(currentYear, 1, 1), out List<int> teams) && teams.Contains(teamId))
            {
                dtpSeason.Value = new DateTime(currentYear + 1, 1, 1);
                MessageBox.Show($"The team already has a car registered for the year {currentYear}. Advancing to {currentYear + 1}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpSeason_ValueChanged(object sender, EventArgs e)
        {
            if (cbxTeams.SelectedValue is int selectedTeamId)
            {
                UpdateSeasonPicker(selectedTeamId);
            }
        }
    }
}
