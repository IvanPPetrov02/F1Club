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
using static LL.Exceptions;

namespace F1Club.GP_pages
{
    public partial class GPMainPage : UserControl
    {
        GPManager gpManager = new GPManager(new GPDAO());
        DataTable dt = new DataTable();
        public GPMainPage()
        {
            InitializeComponent();
            LoadGPs();
            dataGridGP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadGPs()
        {
            dt.Clear();

            dt.Columns.Add("ID");
            dt.Columns.Add("Circuit");
            dt.Columns.Add("Date of Grand Prix");

            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();

            var gps = gpManager.GetAllGPs();
            foreach (GP gp in gps)
            {
                dt.Rows.Add(gp.ID, gp.Circuit.Name, gp.DateOfGP);
            }

            dataGridGP.DataSource = null;
            dataGridGP.DataSource = dt;
            dataGridGP.Columns["ID"].Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dataGridGP.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridGP.SelectedRows[0].Cells["ID"].Value);
                GP selectedGP = gpManager.GetGPByID(ID);
                if (selectedGP != null)
                {
                    GPStatistics gpStatistics = new GPStatistics(selectedGP);
                    gpStatistics.ShowDialog();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGP addGP = new AddGP();
            addGP.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridGP.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this circuit?", "Delete circuit", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridGP.SelectedRows[0].Cells["ID"].Value);
                    try
                    {
                        gpManager.DeleteGP(ID);
                        MessageBox.Show("Grand Prix deleted.");
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
                    MessageBox.Show("Grand Prix not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select only one Grand Prix!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridGP.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridGP.SelectedRows[0].Cells["ID"].Value);
                GP selectedGP = gpManager.GetGPByID(ID);
                if (selectedGP != null)
                {
                    EditGP editGP = new EditGP(selectedGP);
                    editGP.ShowDialog();
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
