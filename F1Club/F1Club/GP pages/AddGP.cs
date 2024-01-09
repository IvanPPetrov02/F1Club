using LL.Driver_related;
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
using LL.GP_related;
using DAL.GP_DAOs_classes;
using LL.Team_related;
using static LL.Exceptions;

namespace F1Club.GP_pages
{
	public partial class AddGP : Form
	{
		GPManager gpManager = new GPManager(new GPDAO());
		CircuitManager circuitManager = new CircuitManager(new CircuitDAO());

		public AddGP()
		{
			InitializeComponent();
			LoadCircuits();
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DateOnly dateOfGP = DateOnly.FromDateTime(dtpDateOfGP.Value);
			Circuit circuit = (Circuit)cbxCircuits.SelectedItem;

			GP gp = new GP(0, circuit, dateOfGP);

			try
			{
				gpManager.CreateGP(gp);
				MessageBox.Show($"Grand Prix {cbxCircuits.SelectedText} added successfully!");
				Close();
			}
			catch (DataLengthException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (DatabaseNotAccessibleException ex)
			{
				MessageBox.Show(ex.Message);

			}
        }
	}
}
