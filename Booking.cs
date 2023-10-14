using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Furniture_system
{
    public partial class Booking : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Booking()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select ProductID from Furnitures";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select ProductCategory,Color,Material from Furnitures where ProductID=:id";
            c.CommandType = CommandType.Text;

            c.Parameters.Add("id", comboBox3.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Booking submited");
                textBox1.Text = dr[0].ToString();
                textBox3.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
            }
            dr.Close();
        }
    }
}
