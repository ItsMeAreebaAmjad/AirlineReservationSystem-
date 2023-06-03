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
    public partial class ViewPasengerscs : Form
    {
        public ViewPasengerscs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AddPassenger ap=new AddPassenger();
            //ap.Show();
            AdminChoice ac=new AdminChoice();
            ac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlights vf=new ViewFlights();
            vf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Query = "SELECT * FROM Passenger1";
            SqlCommand cmd=new SqlCommand(Query, con);
            var reader= cmd.ExecuteReader();

            DataTable table=new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
