using DAL;
using LL.GP_related;
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
using LL.Driver_related;
using DAL.Driver_DAOs_classes;

namespace F1Club.GP_pages
{
    public partial class AddGPResult : Form
    {
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        List<GPResult> gpResults = new List<GPResult>();
        DriverManager driverManager = new DriverManager(new DriverDAO());
        List<Driver>? drivers = new List<Driver>();
        GP _gp = new GP();
        int i;

        bool isEdit = false;

        public AddGPResult(GP gp, bool edit = false)
        {
            isEdit = edit;

            InitializeComponent();
            drivers = driverManager.GetAllDrivers();

            i = 1;
            _gp = gp;
            LoadCbxs();
            btnPrevious.Enabled = false;

            if (isEdit)
            {
                gpResults = gpResultManager.GetAllGPResultsByGPID(gp.ID);

                foreach (GPResult gpResult in gpResults)
                {
                    drivers.Remove(gpResult.Driver);
                }
                GPResult? result = GetGPResult(i);

                if (result != null)
                {
                    LoadCbxs();
                    cbx1.SelectedItem = result.Driver;
                    nudFThr1.Value = result.FinishTime.Hours;
                    nudFTmin1.Value = result.FinishTime.Minutes;
                    nudFTsec1.Value = result.FinishTime.Seconds;
                    nudFTms1.Value = result.FinishTime.Milliseconds;
                    nudLTmin1.Value = result.LapTime.Minutes;
                    nudLTsec1.Value = result.LapTime.Seconds;
                    nudLTms1.Value = result.LapTime.Milliseconds;
                    nudMax1.Value = result.MaxSpeed;
                    nudAVG1.Value = result.AvgSpeed;

                    if (result.FinishTime == TimeSpan.Zero && result.LapTime == TimeSpan.Zero && result.AvgSpeed == 0 && result.MaxSpeed == 0)
                    {
                        cbDNF.Checked = true;
                    }

                    if (result.FinishTime.Hours == 3)
                    {
                        nudFTmin1.Enabled = false;
                        nudFTsec1.Enabled = false;
                        nudFTms1.Enabled = false;
                    }
                    else
                    {
                        nudFTmin1.Enabled = true;
                        nudFTsec1.Enabled = true;
                        nudFTms1.Enabled = true;
                    }
                }
            }
        }

        private void LoadCbxs()
        {
            cbx1.DataSource = null;
            cbx1.DataSource = drivers;
            cbx1.DisplayMember = "FullName";
            cbx1.ValueMember = "ID";
        }

        private void nudFThr1_ValueChanged(object sender, EventArgs e)
        {
            if (nudFThr1.Value == 3)
            {
                nudFTmin1.Value = 0;
                nudFTsec1.Value = 0;
                nudFTms1.Value = 0;
                nudFTmin1.Enabled = false;
                nudFTsec1.Enabled = false;
                nudFTms1.Enabled = false;
            }
            else
            {
                nudFTmin1.Enabled = true;
                nudFTsec1.Enabled = true;
                nudFTms1.Enabled = true;
            }
        }

        private GPResult? GetGPResult(int position)
        {
            if (gpResults != null)
            {
                GPResult? gpResult = gpResults.FirstOrDefault(gpResult => gpResult.Place == position);
                return gpResult;
            }
            return null;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbx1.SelectedItem != null)
            {
                if (i >= 20)
                {
                    btnNext.Enabled = false;
                    btnNext.Visible = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                }


                TimeSpan fastestLap = TimeSpan.FromMinutes((double)nudLTmin1.Value) + TimeSpan.FromSeconds((double)nudLTsec1.Value) + TimeSpan.FromMilliseconds((double)nudLTms1.Value);
                TimeSpan finishTime = TimeSpan.FromHours((double)nudFThr1.Value) + TimeSpan.FromMinutes((double)nudFTmin1.Value) + TimeSpan.FromSeconds((double)nudFTsec1.Value) + TimeSpan.FromMilliseconds((double)nudFTms1.Value);

                GPResult? existingResult = GetGPResult(i);
                if (existingResult != null)
                {
                    gpResults.Remove(existingResult);
                }
                gpResults.Add(new GPResult(_gp, i, cbx1.SelectedItem as Driver, fastestLap, finishTime, (int)nudMax1.Value, (int)nudAVG1.Value));

                nudFThr1.Value = 0;
                nudFTmin1.Value = 0;
                nudFTsec1.Value = 0;
                nudFTms1.Value = 0;
                nudLTmin1.Value = 0;
                nudLTsec1.Value = 0;
                nudLTms1.Value = 0;
                nudMax1.Value = 0;
                nudAVG1.Value = 0;

                drivers.Remove(cbx1.SelectedItem as Driver);
                LoadCbxs();
                if (cbDNF.Checked == true) cbDNF.Checked = false;
                i++;
                GPResult? result = GetGPResult(i);
                if (result != null)
                {
                    cbx1.SelectedItem = result.Driver;
                    nudFThr1.Value = result.FinishTime.Hours;
                    nudFTmin1.Value = result.FinishTime.Minutes;
                    nudFTsec1.Value = result.FinishTime.Seconds;
                    nudFTms1.Value = result.FinishTime.Milliseconds;
                    nudLTmin1.Value = result.LapTime.Minutes;
                    nudLTsec1.Value = result.LapTime.Seconds;
                    nudLTms1.Value = result.LapTime.Milliseconds;
                    nudMax1.Value = result.MaxSpeed;
                    nudAVG1.Value = result.AvgSpeed;

                    if (result.FinishTime == TimeSpan.Zero && result.LapTime == TimeSpan.Zero && result.AvgSpeed == 0 && result.MaxSpeed == 0)
                    {
                        cbDNF.Checked = true;
                    }

                    if (nudMax1.Value < nudAVG1.Value)
                    {
                        nudMax1.Value = nudAVG1.Value;
                    }

                    if (result.FinishTime.Hours == 3)
                    {
                        nudFTmin1.Enabled = false;
                        nudFTsec1.Enabled = false;
                        nudFTms1.Enabled = false;
                    }
                    else
                    {
                        nudFTmin1.Enabled = true;
                        nudFTsec1.Enabled = true;
                        nudFTms1.Enabled = true;
                    }
                }
                this.Text = $"Position {i}";
                lblPosition.Text = $"Position {i}";
                cbDNF_CheckedChanged(cbDNF, e);

            }
            else
            {
                MessageBox.Show("Please select a driver!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            i--;

            this.Text = $"Position {i}";
            lblPosition.Text = $"Position {i}";

            if (i <= 1)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }

            GPResult? result = GetGPResult(i);

            if (result != null)
            {
                drivers.Add(result.Driver);
                LoadCbxs();
                cbx1.SelectedItem = result.Driver;
                nudFThr1.Value = result.FinishTime.Hours;
                nudFTmin1.Value = result.FinishTime.Minutes;
                nudFTsec1.Value = result.FinishTime.Seconds;
                nudFTms1.Value = result.FinishTime.Milliseconds;
                nudLTmin1.Value = result.LapTime.Minutes;
                nudLTsec1.Value = result.LapTime.Seconds;
                nudLTms1.Value = result.LapTime.Milliseconds;
                nudMax1.Value = result.MaxSpeed;
                nudAVG1.Value = result.AvgSpeed;

                if (result.FinishTime == TimeSpan.Zero && result.LapTime == TimeSpan.Zero && result.AvgSpeed == 0 && result.MaxSpeed == 0)
                {
                    cbDNF.Checked = true;
                }

                if (nudMax1.Value < nudAVG1.Value)
                {
                    nudMax1.Value = nudAVG1.Value;
                }

                if (result.FinishTime.Hours == 3)
                {
                    nudFTmin1.Enabled = false;
                    nudFTsec1.Enabled = false;
                    nudFTms1.Enabled = false;
                }
                else
                {
                    nudFTmin1.Enabled = true;
                    nudFTsec1.Enabled = true;
                    nudFTms1.Enabled = true;
                }
                if (i == 1)
                {
                    cbDNF.Checked = false;
                    cbDNF.Enabled = true;
                }
                cbDNF_CheckedChanged(cbDNF, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gpResults.Count != 0)
            {
                btnNext_Click(sender, e);
                if (isEdit)
                {
                    foreach (GPResult gpResult in gpResults)
                    {
                        gpResultManager.UpdateGPResult(gpResults);
                    }
                }
                else
                {
                    foreach (GPResult gpResult in gpResults)
                    {
                        gpResultManager.SetGPResult(gpResults);
                    }
                }
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void cbDNF_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbDNF.Checked)
            {
                nudFThr1.Enabled = true;
                nudFTmin1.Enabled = true;
                nudFTsec1.Enabled = true;
                nudFTms1.Enabled = true;
                nudAVG1.Enabled = true;
                nudMax1.Enabled = true;
                nudLTmin1.Enabled = true;
                nudLTsec1.Enabled = true;
                nudLTms1.Enabled = true;
            }
            else
            {
                nudFThr1.Enabled = false;
                nudFThr1.Value = 3;
                nudFTmin1.Enabled = false;
                nudFTmin1.Value = 0;
                nudFTsec1.Enabled = false;
                nudFTsec1.Value = 0;
                nudFTms1.Enabled = false;
                nudFTms1.Value = 0;
                nudAVG1.Enabled = false;
                nudAVG1.Value = 0;
                nudMax1.Enabled = false;
                nudMax1.Value = 0;
                nudLTmin1.Enabled = false;
                nudLTmin1.Value = 0;
                nudLTsec1.Enabled = false;
                nudLTsec1.Value = 0;
                nudLTms1.Enabled = false;
                nudLTms1.Value = 0;
            }
        }

        private void nudAVG1_ValueChanged(object sender, EventArgs e)
        {
            if (nudMax1.Value < nudAVG1.Value)
            {
                nudMax1.Value = nudAVG1.Value;
            }
        }
    }
}
