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
    public partial class ViewRoutes : Form
    {
        public ViewRoutes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
             string Query = "SELECT * FROM Route1";
            //string Query = "SELECT * FROM Airlines1 INNER JOIN Route1 ON Airlines1.airlines_id=Route1.route_airlines_id;";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserChoice uc= new UserChoice();
            uc.Show();
            this.Hide();
        }
    }
}
