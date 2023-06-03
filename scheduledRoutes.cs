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
    public partial class scheduledRoutes : Form
    {
        public scheduledRoutes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserChoice ucc= new UserChoice();
            ucc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            //string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT MAX(airlines_total_Distance) from Airlines1;";
            //string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView2.DataSource = table;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT MIN(airlines_total_Distance) from Airlines1;";
            //string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView3.DataSource = table;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT SUM(passenger_id) from passenger1;";
            //string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView4.DataSource = table;
            con.Close();

        }
    }
}
