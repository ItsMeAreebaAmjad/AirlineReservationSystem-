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
    public partial class International : Form
    {
        public International()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FlightSchedule ftt=new FlightSchedule();
            ftt.Show();
            this.Hide();
        }
    }
}
