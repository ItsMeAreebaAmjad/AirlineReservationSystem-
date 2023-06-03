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
    public partial class loginAS : Form
    {
        public loginAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin al=new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegistration ur=new UserRegistration();
            ur.Show();
            this.Hide();
        }
    }
}
