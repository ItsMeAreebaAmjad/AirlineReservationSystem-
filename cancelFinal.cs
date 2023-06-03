using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem_01
{
    public partial class cancelFinal : Form
    {
        public cancelFinal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cancelFlight cf= new cancelFlight();
            cf.Show();
            this.Hide();
        }
    }
}
