using DAL;
using DAL.Driver_DAOs_classes;
using DAL.GP_DAOs_classes;
using DAL.Team_DAOs_classes;
using LL;
using LL.GP_related;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Club.GP_pages
{
    public partial class GPStatistics : Form
    {
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        DataTable dt = new DataTable();
        List<GPResult> gpResults = new List<GPResult>();
        GP _gp = new GP();
        public GPStatistics(GP gp)
        {
            InitializeComponent();
            _gp = gp;
            LoadCircuits();
        }
        private void LoadCircuits()
        {
            dt.Clear();

            dt.Columns.Add("Place");
            dt.Columns.Add("Driver");
            dt.Columns.Add("Lap time (minutes)");
            dt.Columns.Add("Time to finish (hours)");
            dt.Columns.Add("Max speed");
            dt.Columns.Add("Avg speed");
            dt.Columns.Add(" ");

            ReLoadData();


        }


        private void ReLoadData()
        {
            dt.Clear();
            gpResults = gpResultManager.GetAllGPResultsByGPID(_gp.ID);

            if (gpResults.Count == 0)
            {
                dt.Rows.Add(null, null, null, null, null, null, "No data available");
                dgvPlaces.DataSource = null;
                dgvPlaces.DataSource = dt;
                dgvPlaces.Columns["Place"].Visible = false;
                dgvPlaces.Columns["Driver"].Visible = false;
                dgvPlaces.Columns["Lap time (minutes)"].Visible = false;
                dgvPlaces.Columns["Time to finish (hours)"].Visible = false;
                dgvPlaces.Columns["Max speed"].Visible = false;
                dgvPlaces.Columns["Avg speed"].Visible = false;
                btnEdit.Enabled = false;
                btnReset.Enabled = false;
                tbLapTime.Text = "-";
                tbxFinishTime.Text = "-";
                tbxMaxSpeed.Text = "-";
                tbxAverageSpeed.Text = "-";
            }
            else
            {
                foreach (GPResult results in gpResults)
                {
                    dt.Rows.Add(results.Place, $"{results.Driver.FirstName} {results.Driver.LastName} ({results.Driver.Team.Name})", $"{results.LapTime.Minutes}:{results.LapTime.Seconds}:{results.LapTime.Milliseconds}", $"{results.FinishTime.Hours}:{results.FinishTime.Minutes}:{results.FinishTime.Seconds}:{results.FinishTime.Milliseconds}", $"{results.MaxSpeed} km/h", $"{results.AvgSpeed} km/h", null);
                }
                this.Text = $"{gpResults[0].GP.Circuit.Name} - {gpResults[0].GP.DateOfGP}";
                dgvPlaces.DataSource = null;
                dgvPlaces.DataSource = dt;
                dgvPlaces.Columns[" "].Visible = false;
                btnAdd.Enabled = false;
                if (gpResults.Count > 0)
                {
                    GPResult lapTime = gpResultManager.GetBestLapTime(_gp.ID);
                    GPResult finishTime = gpResultManager.GetBestFinishTime(_gp.ID);
                    GPResult avgSpeed = gpResultManager.GetBestAvgSpeed(_gp.ID);
                    GPResult maxSpeed = gpResultManager.GetBestMaxSpeed(_gp.ID);
                    tbLapTime.Text = $"{lapTime.Driver.FullName}" + " - " + $"{lapTime.LapTime.Minutes}:{lapTime.LapTime.Seconds}:{(Convert.ToInt32(lapTime.LapTime.TotalMilliseconds)) / 1000}";
                    tbxFinishTime.Text = $"{finishTime.Driver.FullName}" + " - " + $"{finishTime.FinishTime.Hours}:{finishTime.FinishTime.Minutes}:{finishTime.FinishTime.Seconds}:{(Convert.ToInt32(finishTime.FinishTime.TotalMilliseconds)) / 1000}";
                    tbxMaxSpeed.Text = $"{maxSpeed.Driver.FullName}" + " - " + $"{maxSpeed.MaxSpeed} km/h";
                    tbxAverageSpeed.Text = $"{avgSpeed.Driver.FullName}" + " - " + $"{avgSpeed.AvgSpeed} km/h";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGPResult addGPResult = new AddGPResult(_gp);
            addGPResult.ShowDialog();
            ReLoadData();
            btnAdd.Enabled = false;
            btnReset.Enabled = true;
            btnClose.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddGPResult addGPResult = new AddGPResult(_gp, true);
            addGPResult.ShowDialog();
            ReLoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (GPResult gpResult in gpResults)
            {
                gpResultManager.DeleteGPResult(gpResult);
            }
            ReLoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }
    }
}
