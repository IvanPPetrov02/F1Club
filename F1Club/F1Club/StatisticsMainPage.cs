using DAL;
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

namespace F1Club
{
    public partial class StatisticsMainPage : UserControl
    {
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        public StatisticsMainPage()
        {
            InitializeComponent();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            var driverWins = gpResultManager.GetAllDriversWins();

            var driverNames = driverWins.Values.Select(d => d.FullName).ToArray();
            var wins = driverWins.Values.Select(d => (double)d.Wins).ToArray();

            var plt = formsPlot1.Plot;
            plt.Clear();

            var barPlot = plt.AddBar(wins);
            plt.XAxis.ManualTickPositions(barPlot.Positions, driverNames);

            plt.Title("F1 Driver Wins");
            plt.YLabel("Number of Wins");
            plt.XLabel("Drivers");
            plt.XAxis.TickLabelStyle(rotation: 45);

            plt.YAxis.ManualTickSpacing(1);
            plt.SetAxisLimits(yMin: 0);

            formsPlot1.Render();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {

        }

        private void btnCircuits_Click(object sender, EventArgs e)
        {

        }
    }
}
