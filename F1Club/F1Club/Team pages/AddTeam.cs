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
    public partial class AddTeam : Form
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());

        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }
            else
            {
                string name = tbxName.Text;
                DateOnly creationDate = DateOnly.FromDateTime(dtpCreationDate.Value);

                Team newTeam = new Team(0, name, creationDate);

                try
                {
                    teamManager.CreateTeam(newTeam);
                    MessageBox.Show("Team added successfully.");
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
        }
    }
}
