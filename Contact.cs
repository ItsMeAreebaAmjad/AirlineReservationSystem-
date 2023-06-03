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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Full_Name = textBox1.Text;
            string email = textBox2.Text;
            string Message = richTextBox1.Text;

            if(Full_Name=="" || email=="" || Message=="")
            {
                MessageBox.Show("Please Enter All information !");
            }
            else
            {
                MessageBox.Show("Message Sent !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserChoice uc=new UserChoice();
            uc.Show();
            this.Hide();
        }
    }
}
