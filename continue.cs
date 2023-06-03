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
    public partial class @continue : Form
    {
        public @continue()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs= new AboutUs();
              aboutUs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con1 cn=new Con1();
            cn.Show();
            this.Hide();
        }
    }
}
