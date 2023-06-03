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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AirlineReservationSystem_01
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string PassengerID = textBox1.Text;
            string Passenger_booking_id = textBox5.Text;
            string Passenger_type = textBox6.Text;
            string PassengerName = textBox2.Text;
            string Gender = comboBox1.Text;
            string Age = textBox3.Text;
            string Seat_No = textBox4.Text;

            if (PassengerID == "" || Passenger_booking_id == "" || Passenger_type == "" || PassengerName == "" || Gender == "" || Age == "" || Seat_No == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Passenger1(passenger_id,passenger_booking_id,passenger_type,passenger_name,passenger_Gender,passenger_age,passenger_seat_no)values('" + PassengerID + "','" + Passenger_booking_id + "','" + Passenger_type + "','" + PassengerName + "','" + Gender + "','" + Age + "','" + Seat_No + "')", con);
                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("Recorded Successfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPasengerscs vp=new ViewPasengerscs();
            vp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            textBox5.Text="";
            textBox6.Text="";
            textBox2.Text="";
            comboBox1.Text="";
            textBox3.Text="";
            textBox4.Text="";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminChoice ac=new AdminChoice();
            ac.Show();
            this.Hide();
        }
    }
}
