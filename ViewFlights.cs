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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT * FROM Booking1";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ViewPasengerscs vp=new ViewPasengerscs();
           // vp.Show();
           AdminChoice ac=new AdminChoice();
            ac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AdminLogin al=new AdminLogin();
            //al.Show();
            //this.Hide();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {

        }
    }
}
