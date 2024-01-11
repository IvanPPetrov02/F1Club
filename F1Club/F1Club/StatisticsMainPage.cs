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

            for (int i = 0; i < wins.Length; i++)
            {
                plt.AddText(wins[i].ToString(), barPlot.Positions[i], wins[i] + 0.5, size: 16);
            }

            formsPlot1.Render();
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            var teamAveragePositions = gpResultManager.GetTeamsAveragePositions();

            var teamNames = teamAveragePositions.Select(t => t.Team.Name).ToArray();
            var averagePositions = teamAveragePositions.Select(t => t.AveragePosition).ToArray();

            var plt = formsPlot1.Plot;
            plt.Clear();

            var barPlot = plt.AddBar(averagePositions);
            plt.XAxis.ManualTickPositions(barPlot.Positions, teamNames);

            plt.Title("F1 Team Average Positions (lower is better)");
            plt.YLabel("Average Position");
            plt.XLabel("Teams");
            plt.XAxis.TickLabelStyle(rotation: 45);

            plt.YAxis.ManualTickSpacing(1);
            plt.SetAxisLimits(yMin: 0, yMax: averagePositions.Max() + 1);

            for (int i = 0; i < averagePositions.Length; i++)
            {
                plt.AddText(averagePositions[i].ToString("F2"), barPlot.Positions[i], averagePositions[i] + 0.5, size: 16);
            }

            formsPlot1.Render();
        }
    }
}
