using DAL.GP_DAOs_classes;
using LL;
using LL.GP_related;
using LL.Profile_related;
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

namespace F1Club.GP_pages
{
    public partial class EditCircuit : Form
    {
        CircuitManager circuitManager = new CircuitManager(new CircuitDAO());
        Circuit _circuit = new();
        public EditCircuit(Circuit circuit)
        {
            InitializeComponent();
            _circuit = circuit;
            tbxName.Text = circuit.Name;
            nudLength.Value = circuit.Length;
            nudNrOfLaps.Value = circuit.NumberOfLaps;
            nudNrOfCorners.Value = circuit.NumberOfCorners;
            nudRoadScore.Value = (decimal)circuit.RoadScore;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                try
                {
                    circuitManager.UpdateCircuit(new Circuit(_circuit.ID, tbxName.Text, (int)nudNrOfLaps.Value, (int)nudLength.Value, (int)nudNrOfCorners.Value, (double)nudRoadScore.Value));
                    MessageBox.Show($"Circuit {tbxName.Text} edited successfully!");
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
