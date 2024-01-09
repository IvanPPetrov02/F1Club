using DAL.Car_DAOs_classes;
using LL;
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

namespace F1Club.Team_pages
{
    public partial class CarMainPage : UserControl
    {
        DataTable dt = new DataTable();
        CarManager carManager = new CarManager(new CarDAO());

        public CarMainPage()
        {
            InitializeComponent();
            Initilize();
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Initilize()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Team");
            dt.Columns.Add("Season used");
            dt.Columns.Add("Chassis");
            dt.Columns.Add("Engine");
            dt.Columns.Add("Handling score");
            dt.Columns.Add("Acceleration score");
            dt.Columns.Add("Breaking score");
            dt.Columns.Add("Top speed possible");

            ReLoadData();
        }

        private void ReLoadData()
        {
            dt.Clear();

            var cars = carManager.GetAllCars();
            foreach (Car car in cars)
            {
                dt.Rows.Add(car.ID, car.Team.Name, car.SeasonUsed.Year, car.Chassis, car.Engine, $"{car.HandlingScore}/10", $"{car.AccelerationScore}/10", $"{car.BreakingScore}/10", $"{car.TopSpeedPossible} km/h");
            }

            dataGridCars.DataSource = null;
            dataGridCars.DataSource = dt;
            dataGridCars.Columns["ID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridCars.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this car?", "Delete car", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridCars.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        carManager.DeleteCar(ID);
                        MessageBox.Show("Car deleted.");
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
                    MessageBox.Show("Car not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select only one team.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridCars.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridCars.SelectedRows[0].Cells["ID"].Value);
                if (ID != 0)
                {
                    Car selectedCar = carManager.GetCarById(ID);
                    EditCar editCar = new EditCar(selectedCar);
                    editCar.ShowDialog();
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
