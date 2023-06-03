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
    public partial class ConfirmFlight : Form
    {
        public ConfirmFlight()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Payment pm=new Payment();
            pm.Show();
            this.Hide();
        }
    }
}
