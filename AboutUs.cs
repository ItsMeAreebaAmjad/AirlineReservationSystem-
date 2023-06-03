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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminChoice ac=new AdminChoice();
            ac.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            @continue cn = new @continue();
            cn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserChoice uc=new UserChoice();
            uc.Show();
            this.Hide();
        }
    }
}
