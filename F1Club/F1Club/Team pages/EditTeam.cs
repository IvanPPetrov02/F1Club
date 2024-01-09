using DAL.Team_DAOs_classes;
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
using static LL.Profile_related.ProfileManager;
using static LL.Exceptions;

namespace F1Club.Team_pages
{
    public partial class EditTeam : Form
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        Team _team;

        public EditTeam(Team team)
        {
            InitializeComponent();
            tbxName.Text = team.Name;
            dtpCreationDate.Text = team.CreationDate.ToString();
            _team = team;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            DateOnly creationDate = DateOnly.FromDateTime(dtpCreationDate.Value);

            Team updatedTeam = new Team(_team.ID, name, creationDate);

            try
            {
                teamManager.UpdateTeam(updatedTeam);
                MessageBox.Show("Team updated successfully!");
                Close();
            }
            catch (DataLengthException ex)
            {
                MessageBox.Show(ex.Message);
                tbxName.Clear();
            }
            catch (DatabaseNotAccessibleException ex)
            {
                MessageBox.Show(ex.Message);
                tbxName.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
