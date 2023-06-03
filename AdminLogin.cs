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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Admin_ID = "17";
            string Password = "169693bb";

            if(textBox1.Text==Admin_ID && textBox2.Text==Password)
            {
                MessageBox.Show("Successfully Login");
                AdminChoice ac=new AdminChoice();
                ac.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Valid !");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            loginAS la=new loginAS();
            la.Show();  
            this.Hide();    
        }
    }
}
