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
using System.Xml.Linq;

namespace AirlineReservationSystem_01
{
    public partial class cancelFlight : Form
    {
        public cancelFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-JM9PPML;Initial Catalog=Project1;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            string book_id = textBox8.Text;
            string full_name = textBox5.Text;
            string Email = textBox6.Text;
            string phone = textBox7.Text;

            if(book_id=="" || full_name=="" || Email=="" || phone=="")
            {
                MessageBox.Show("please enter complete infromation !");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from book_flight where book_id='" +book_id + "'", con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("data deleted !");
                cancelFinal cf=new cancelFinal();
                cf.Show();
                this.Hide();
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
