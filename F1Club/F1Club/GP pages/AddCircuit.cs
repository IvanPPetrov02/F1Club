using LL.Profile_related;
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
using LL.GP_related;
using DAL.GP_DAOs_classes;
using static LL.Exceptions;

namespace F1Club.GP_pages
{
    public partial class AddCircuit : Form
    {
        CircuitManager circuitManager = new CircuitManager(new CircuitDAO());
        public AddCircuit()
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
                int numberOfLaps = (int)nudNrOfLaps.Value;
                int length = (int)nudLength.Value;
                int numberOfCorners = (int)nudNrOfCorners.Value;
                double roadScore = (double)nudRoadScore.Value;

                try
                {
                    circuitManager.CreateCircuit(new Circuit(0, name, numberOfLaps, length, numberOfCorners, roadScore));
                    MessageBox.Show($"Success! Circuit {name} created!");
                    Close();
                }
                catch (DataLengthException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxName.Clear();
                    nudLength.Value = 0;
                    nudNrOfLaps.Value = 0;
                }
                catch (DatabaseNotAccessibleException ex)
                {
                    MessageBox.Show(ex.Message);
                    tbxName.Clear();
                    nudLength.Value = 0;
                    nudNrOfLaps.Value = 0;
                }
            }
        }
    }
}
