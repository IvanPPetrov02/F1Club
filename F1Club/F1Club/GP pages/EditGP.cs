using DAL.GP_DAOs_classes;
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
using System.Xml.Linq;
using static LL.Exceptions;
using static LL.Profile_related.ProfileManager;

namespace F1Club.GP_pages
{
	public partial class EditGP : Form
	{
		GPManager gpManager = new GPManager(new GPDAO());
		CircuitManager circuitManager = new CircuitManager(new CircuitDAO());
		GP _gp = new();

		public EditGP(GP gp)
		{
			InitializeComponent();
			LoadCircuits();
			_gp = gp;
			cbxCircuits.SelectedItem = gp.Circuit;
			dtpDateOfGP.Text = gp.DateOfGP.ToString();
		}

		private void LoadCircuits()
		{
			List<Circuit>? circuits = circuitManager.GetAllCircuits();
			cbxCircuits.DataSource = circuits;
			cbxCircuits.DisplayMember = "Name";
			cbxCircuits.ValueMember = "ID";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			DateOnly DateOfGP = DateOnly.FromDateTime(dtpDateOfGP.Value);
            try
            {
                gpManager.UpdateGP(new GP(_gp.ID, (Circuit)cbxCircuits.SelectedItem, DateOfGP));
                MessageBox.Show($"Grand Prix {cbxCircuits.SelectedText} edited successfully!");
                Close();
            }
            catch (DataLengthException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (DatabaseNotAccessibleException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
	}
}
