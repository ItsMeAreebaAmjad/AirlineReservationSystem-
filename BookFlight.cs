using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem_01
{
    public partial class BookFlight : Form
    {
        public BookFlight()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            string booking_from = textBox1.Text;
            string booking_to = textBox2.Text;
            string preferd_airline = comboBox1.Text;
            string preferd_seating = comboBox2.Text;
            string departure_date = textBox4.Text;
            string departure_time = textBox3.Text;
            string book_id = textBox8.Text;
            string full_name = textBox5.Text;
            string Email = textBox6.Text;
            string phone = textBox7.Text;

            if(booking_from=="" || booking_to=="" || preferd_airline=="" || preferd_seating=="" || departure_date=="" || departure_time=="" || book_id=="" || full_name=="" ||Email=="" || phone=="")
            {
                MessageBox.Show("Please Enter complete information !");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into book_flight(book_id,booking_from,booking_to,preferd_airline,preferd_seating,departure_date,departure_time,full_name,Email,phone)values('" + book_id + "','" + booking_from + "','" + booking_to + "','" + preferd_airline + "','" + preferd_seating + "','" + departure_date + "','" + departure_time + "','" + full_name + "','" + Email + "','" + phone + "')",con);
                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("You data is registered !");


                Payment pm = new Payment();
                pm.Show();
                this.Hide();
            }




        
        }

        private void label15_Click(object sender, EventArgs e)
        {
            UserChoice ucc=new UserChoice();
            ucc.Show();
            this.Hide();
        }
    }
}
