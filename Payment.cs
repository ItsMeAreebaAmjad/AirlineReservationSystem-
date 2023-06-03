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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Full_Name=textBox1.Text;
            string Email = textBox2.Text;
            string Address=textBox3.Text;
            string City=textBox4.Text;
            string State=comboBox1.Text;
            string zipcode=textBox5.Text;
            string credit_card_num=textBox6.Text;
            string exp_month=textBox7.Text;
            string exp_year = comboBox2.Text;
            string CVV = textBox8.Text;

            if(Full_Name=="" || Email=="" || Address=="" || City=="" || State=="" || zipcode=="" || credit_card_num=="" || exp_month=="" || exp_year=="" || CVV=="")
            {
                MessageBox.Show("Cannot Confirm Until you enter complete information");
  
            }
            else
            {
                ConfirmFlight cf = new ConfirmFlight();
                cf.Show();
                this.Hide();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookFlight bff=new BookFlight();
            bff.Show();
            this.Hide();
        }
    }
}
