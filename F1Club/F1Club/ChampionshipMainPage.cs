using DAL.Driver_DAOs_classes;
using DAL.GP_DAOs_classes;
using DAL.Team_DAOs_classes;
using DAL;
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
using LL.Championship_related;
using LL.GP_related;

namespace F1Club
{
    public partial class ChampionshipMainPage : UserControl
    {
        ChampionshipManager championshipManager = new ChampionshipManager(new GPResultDAO(), new DriverDAO(), new TeamDAO(), new GPDAO());
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        DataTable dt = new DataTable();

        public ChampionshipMainPage()
        {
            InitializeComponent();
            LoadYears();
            cbxYears.SelectedIndex = 0;
            Initialize();
            dataGridChampionshipResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadYears()
        {
            List<int> years = championshipManager.GetYears();
            foreach (int year in years)
            {
                cbxYears.Items.Add(year);
            }
        }

        private void Initialize()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Circuit");
            dt.Columns.Add("Date");
            dt.Columns.Add("Winner");
            dt.Columns.Add("Team");
            dt.Columns.Add("Fastest lap");
            dt.Columns.Add("Finish time");

            LoadChampionship();
        }

        private void LoadChampionship()
        {
            dt.Clear();

            Championship championship = championshipManager.GetChampionshipByYear((int)cbxYears.SelectedItem);
            var orderedGPs = championship.GPs.OrderBy(gp => gp.DateOfGP);
            foreach (GP gp in orderedGPs)
            {
                List<GPResult> gpResults = gpResultManager.GetAllGPResultsByGPID(gp.ID);

                GPResult winnerResult = gpResults.FirstOrDefault(r => r.Place == 1);

                string winnerName = winnerResult?.Driver.FullName ?? "N/A";
                string winningTeam = winnerResult?.Driver.Team.Name ?? "N/A";
                string fastestLap = gpResultManager.GetBestLapTime(gp.ID)?.LapTime.ToString() ?? "N/A";
                string finishTime = winnerResult?.FinishTime.ToString() ?? "N/A";

                dt.Rows.Add(gp.ID, gp.Circuit.Name, gp.DateOfGP.ToShortDateString(), winnerName, winningTeam, fastestLap, finishTime);
            }

            dataGridChampionshipResults.DataSource = null;
            dataGridChampionshipResults.DataSource = dt;
            dataGridChampionshipResults.Columns["ID"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadChampionship();
        }
    }
}
