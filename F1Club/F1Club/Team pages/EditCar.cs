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

namespace F1Club.Team_pages
{
    public partial class EditCar : Form
    {
        public EditCar(Car car)
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
