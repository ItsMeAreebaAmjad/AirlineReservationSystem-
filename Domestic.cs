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
    public partial class Domestic : Form
    {
        public Domestic()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "01:00 AM";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Lahore";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "PIA";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "Karachi";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FlightSchedule ftt=new FlightSchedule();
            ftt.Show();
            this.Hide();
        }
    }
}
