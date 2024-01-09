using DAL.GP_DAOs_classes;
using F1Club.Profile_pages;
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

namespace F1Club.GP_pages
{
    public partial class CircuitMainPage : UserControl
    {
        CircuitManager circuitManager = new CircuitManager(new CircuitDAO());
        DataTable dt = new DataTable();
        public CircuitMainPage()
        {
            InitializeComponent();
            LoadCircuits();
            dataGridCircuits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadCircuits()
        {
            dt.Clear();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Number Of Laps");
            dt.Columns.Add("Length");
            dt.Columns.Add("Number Of Corners");
            dt.Columns.Add("Road Score");


            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();

            var circuits = circuitManager.GetAllCircuits();
            foreach (Circuit circuit in circuits)
            {
                dt.Rows.Add(circuit.ID, circuit.Name, circuit.NumberOfLaps, $"{circuit.Length} km", $"{circuit.NumberOfCorners} per lap", $"{circuit.RoadScore}/10");
            }

            dataGridCircuits.DataSource = null;
            dataGridCircuits.DataSource = dt;
            dataGridCircuits.Columns["ID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCircuit addCircuit = new AddCircuit();
            addCircuit.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridCircuits.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this circuit?", "Delete circuit", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridCircuits.SelectedRows[0].Cells["ID"].Value);
                    try
                    {
                        circuitManager.DeleteCircuit(ID);
                        MessageBox.Show("Circuit deleted.");
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
                    MessageBox.Show("Circuit not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select only one circuit!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridCircuits.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridCircuits.SelectedRows[0].Cells["ID"].Value);
                Circuit selectedCircuit = circuitManager.GetCircuitByID(ID);
                if (selectedCircuit != null)
                {
                    EditCircuit editCircuit = new EditCircuit(selectedCircuit);
                    editCircuit.ShowDialog();
                    ReLoadData();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again later.");
                }

            }
            else
            {
                MessageBox.Show("Select only one circuit you want to edit!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }
    }
}
