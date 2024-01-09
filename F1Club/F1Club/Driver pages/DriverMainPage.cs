using DAL;
using LL.Profile_related;
using LL;
using LL.Driver_related;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Driver_DAOs_classes;
using F1Club.Profile_pages;
using LL.Team_related;
using DAL.Team_DAOs_classes;
using static LL.Exceptions;

namespace F1Club.Driver_pages
{
    public partial class DriverMainPage : UserControl
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());
        DataTable dt = new DataTable();
        public DriverMainPage()
        {
            InitializeComponent();
            Initialize();
            dataGridDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Initialize()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Number");
            dt.Columns.Add("First name");
            dt.Columns.Add("Last name");
            dt.Columns.Add("Date of birth");
            dt.Columns.Add("Team");

            LoadDrivers();
        }

        private void LoadDrivers()
        {
            dt.Clear();

            var drivers = driverManager.GetAllDrivers();
            foreach (Driver driver in drivers)
            {
                dt.Rows.Add(driver.ID, driver.Number, driver.FirstName, driver.LastName, driver.DateOfBirth, driver.Team.Name);
            }

            dataGridDrivers.DataSource = null;
            dataGridDrivers.DataSource = dt;
            dataGridDrivers.Columns["ID"].Visible = false;
        }

        private void ReLoadData()
        {
            dt.Clear();

            var drivers = driverManager.GetAllDriversRefreshed();
            foreach (Driver driver in drivers)
            {
                dt.Rows.Add(driver.ID, driver.Number, driver.FirstName, driver.LastName, driver.DateOfBirth, driver.Team.Name);
            }

            dataGridDrivers.DataSource = null;
            dataGridDrivers.DataSource = dt;
            dataGridDrivers.Columns["ID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            addDriver.ShowDialog();
            ReLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridDrivers.SelectedRows.Count == 1)
            {
                DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this driver?", "Delete driver", MessageBoxButtons.YesNo);
                if (deletePrompt == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridDrivers.SelectedRows[0].Cells["ID"].Value);
                    try
                    {
                        driverManager.DeleteDriver(ID);
                        MessageBox.Show("Driver deleted.");
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
                    MessageBox.Show("Driver not deleted.");
                }
            }
            else
            {
                MessageBox.Show("Please select only one driver!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridDrivers.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridDrivers.SelectedRows[0].Cells["ID"].Value);

                if (ID != 0)
                {
                    Driver selectedDriver = driverManager.GetDriverByID(ID);
                    EditDriver editDriver = new EditDriver(selectedDriver);
                    editDriver.ShowDialog();
                    ReLoadData();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again later.");
                }
            }
            else
            {
                MessageBox.Show("Select only one driver you want to edit!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDrivers();
        }
    }
}
