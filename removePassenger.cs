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
    public partial class removePassenger : Form
    {
        public removePassenger()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminChoice acc=new AdminChoice();
            acc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();


            string passenger_id = textBox1.Text;
            string full_name = textBox2.Text;
            string seat_no = textBox3.Text;

            if(passenger_id=="")
            {
                MessageBox.Show("Must Enter Passenger Id !");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from Passenger1 where passenger_id='" + passenger_id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger Removed From the System");
            }
        }

        private void removePassenger_Load(object sender, EventArgs e)
        {

        }
    }
}
