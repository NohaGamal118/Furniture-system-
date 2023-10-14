using System;
//using BenchmarkDotNet.Toolchains.Roslyn;
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
    public partial class ManageFurniture : Form
    {
        
        OracleDataAdapter adapter ;
        DataSet ds ;
        OracleCommandBuilder Builder ;
        public ManageFurniture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageFurniture_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1;User Id=scott;Password=tiger;";

            string cmdstr = "";

            if (radioButton2.Checked)
            {
                cmdstr = "Select * from Furnitures";
            }
            else if (radioButton1.Checked)
            {
                cmdstr = "Select * from Orders";
            }
           adapter = new OracleDataAdapter(cmdstr, constr);
           ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Saved Successfully");
        }
    }
}
