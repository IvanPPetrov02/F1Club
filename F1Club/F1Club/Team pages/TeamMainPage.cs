using DAL.Team_DAOs_classes;
using LL;
using LL.Driver_related;
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
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace F1Club.Team_pages
{
    public partial class TeamMainPage : UserControl
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        DataTable dt = new DataTable();

        public TeamMainPage()
        {
            InitializeComponent();
            Initilize();
            dataGridTeams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Initilize()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Creation date");

            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();

            var teams = teamManager.GetAllTeamsRefresh();
            foreach (Team team in teams)
            {
                dt.Rows.Add(team.ID, team.Name, team.CreationDate);
            }

            dataGridTeams.DataSource = null;
            dataGridTeams.DataSource = dt;
            dataGridTeams.Columns["ID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            addTeam.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridTeams.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this team?", "Delete team", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridTeams.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        teamManager.DeleteTeam(ID);
                        MessageBox.Show("Team deleted.");
                        ReLoadData();
                    }
                    catch (DatabaseNotAccessibleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong! Try again later.");
                    }
                }
                else
                {
                    MessageBox.Show("Team not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select only one team.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridTeams.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridTeams.SelectedRows[0].Cells["ID"].Value);
                if (ID != 0)
                {
                    Team selectedTeam = teamManager.GetTeamByID(ID);
                    EditTeam editTeam = new EditTeam(selectedTeam);
                    editTeam.ShowDialog();
                    ReLoadData();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again later.");
                }
            }
            else
            {
                MessageBox.Show("Select only one team you want to edit.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }
    }
}
