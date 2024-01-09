using F1Club.Driver_pages;
using F1Club.GP_pages;
using F1Club.Profile_pages;
using F1Club.Team_pages;
using LL;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Club
{
    public partial class MainForm : Form
    {
        UserControl lastPage = new();
        DriverMainPage driverMainPage = new();
        TeamMainPage teamMainPage = new();
        ProfileMainPage profileMainPage = new();
        CircuitMainPage circuitMainPage = new();
        GPMainPage gpMainPage = new();
        StatisticsMainPage statisticsMainPage = new();
        CarMainPage carMainPage = new();
        public MainForm(Profile profile)
        {
            InitializeComponent();
            LoadUserControls();
            ShowPage(driverMainPage);
        }

        public void LoadUserControls()
        {
            panelForms.Controls.Clear();
            panelForms.Controls.Add(driverMainPage);
            driverMainPage.Hide();
            panelForms.Controls.Add(teamMainPage);
            teamMainPage.Hide();
            panelForms.Controls.Add(profileMainPage);
            profileMainPage.Hide();
            panelForms.Controls.Add(circuitMainPage);
            circuitMainPage.Hide();
            panelForms.Controls.Add(gpMainPage);
            gpMainPage.Hide();
            panelForms.Controls.Add(statisticsMainPage);
            statisticsMainPage.Hide();
            panelForms.Controls.Add(carMainPage);
            carMainPage.Hide();
        }

        private void ShowPage(UserControl page)
        {
            lastPage.Hide();
            page.Show();
            lastPage = page;
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logIn = new Login();
            logIn.Show();
            Hide();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            ShowPage(driverMainPage);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            ShowPage(teamMainPage);
        }

        private void btnCircuit_Click(object sender, EventArgs e)
        {
            ShowPage(circuitMainPage);
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            ShowPage(gpMainPage);
        }

        private void btnChampionship_Click(object sender, EventArgs e)
        {

        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            ShowPage(profileMainPage);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ShowPage(statisticsMainPage);
        }

        private void btnBullets_Click(object sender, EventArgs e)
        {
            ShowPage(carMainPage);
        }
    }
}
