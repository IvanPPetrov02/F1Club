using DAL.Car_DAOs_classes;
using DAL.Team_DAOs_classes;
using LL;
using LL.Team_related;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Club.Team_pages
{
    public partial class EditCar : Form
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        CarManager carManager = new CarManager(new CarDAO());
        private Car _car;
        Dictionary<DateOnly, List<int>> TeamsHaveCarForSeason = new Dictionary<DateOnly, List<int>>();
        public EditCar(Car car)
        {
            InitializeComponent();
            LoadTeams();
            TeamsHaveCarForSeason = carManager.TeamsHaveCarForSeason();
            
            dtpSeason.CustomFormat = "yyyy";
            dtpSeason.ShowUpDown = true;

            if (cbxTeams.Items.Count > 0)
            {
                cbxTeams.SelectedIndex = 0;
            }

            _car = car;
            cbxTeams.SelectedItem = _car.Team;
            dtpSeason.Value = _car.SeasonUsed.ToDateTime(TimeOnly.MinValue);
            tbxChasis.Text = _car.Chassis;
            tbxEngine.Text = _car.Engine;
            nudHandling.Value = (decimal)_car.HandlingScore;
            nudAcceleration.Value = (decimal)_car.AccelerationScore;
            nudBreaking.Value = (decimal)_car.BreakingScore;
            nudTopSpeed.Value = _car.TopSpeedPossible;

            if (TeamsHaveCarForSeason.TryGetValue(_car.SeasonUsed, out List<int> teams))
            {
                teams.Remove(_car.Team.ID);
            }
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

            Team selectedTeam = (Team)cbxTeams.SelectedItem;
            DateOnly selectedSeason = DateOnly.FromDateTime(dtpSeason.Value);

            if (TeamHasCarForYear(selectedTeam.ID, selectedSeason.Year))
            {
                MessageBox.Show($"The team {selectedTeam.Name} already has a car registered for the season {selectedSeason.Year}. Please change the year or the team.", "Car Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _car.Team = selectedTeam;
            _car.SeasonUsed = selectedSeason;
            _car.Chassis = tbxChasis.Text;
            _car.Engine = tbxEngine.Text;
            _car.HandlingScore = (double)nudHandling.Value;
            _car.AccelerationScore = (double)nudAcceleration.Value;
            _car.BreakingScore = (double)nudBreaking.Value;
            _car.TopSpeedPossible = (int)nudTopSpeed.Value;

            carManager.UpdateCar(_car);

            MessageBox.Show("Car updated successfully!");
            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool TeamHasCarForYear(int teamId, int year)
        {
            
            
            return TeamsHaveCarForSeason.TryGetValue(new DateOnly(year, 1, 1), out List<int> teams) && teams.Contains(teamId);
        }
    }
}
