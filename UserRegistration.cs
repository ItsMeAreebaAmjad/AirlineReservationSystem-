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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogincs ull=new UserLogincs();
            ull.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            //string Username = "Areeba";
            string Password = textBox2.Text;
            string Email=textBox3.Text;

            if(Username=="" || Password=="" || Email=="")
            {
                MessageBox.Show("Please Enter All Information");
            }
            else
            {
                MessageBox.Show("Registered Successfully");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            loginAS la=new loginAS();
            la.Show();
            this.Show();
        }
    }
}
