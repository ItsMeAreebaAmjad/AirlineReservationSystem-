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
    public partial class AdminChoice : Form
    {
        public AdminChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassenger ap=new AddPassenger();
            ap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPasengerscs vp=new ViewPasengerscs();
            vp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlights vf=new ViewFlights();
            vf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutUs au=new AboutUs();
            au.Show(); 
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            removePassenger rp=new removePassenger();
            rp.Show();
            this.Hide();
        }
    }
}
