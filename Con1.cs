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
    public partial class Con1 : Form
    {
        public Con1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            @continue cn = new @continue();
            cn.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
