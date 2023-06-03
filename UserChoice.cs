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
    public partial class UserChoice : Form
    {
        public UserChoice()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           UserLogincs ull=new UserLogincs();
            ull.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutUs au=new AboutUs();
            au.Show();  
            this.Hide();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contact cn=new Contact();
            cn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewRoutes vr=new ViewRoutes();
            vr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookFlight bff=new BookFlight();
            bff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelFlight cff=new cancelFlight();
            cff.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FlightSchedule fts=new FlightSchedule();
            fts.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scheduledRoutes srcc = new scheduledRoutes();
            srcc.Show();
            this.Hide();
        }
    }
}
