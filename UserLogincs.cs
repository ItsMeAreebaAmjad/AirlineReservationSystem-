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
    public partial class UserLogincs : Form
    {
        public UserLogincs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if(Username=="Areeba" && Password=="169693bb")
            {
                MessageBox.Show("Login Successfully");
                UserChoice uc=new UserChoice();
                uc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not registered");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserRegistration ur=new UserRegistration();
            ur.Show();
            this.Hide();
        }
    }
}
