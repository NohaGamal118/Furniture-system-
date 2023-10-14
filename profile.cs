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
    public partial class profile : Form
    {
        OracleDataAdapter adapter1;
        OracleCommandBuilder builder1;
        DataSet ds;
        public profile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl1;User Id=scott;Password=tiger;";
            string cmdstr = @"select * from SystemUsers  Where  Username=:n";
            adapter1 = new OracleDataAdapter(cmdstr, constr);
            adapter1.SelectCommand.Parameters.Add("n", password.Text);//PASSWORD
            ds = new DataSet();
            adapter1.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            builder1 = new OracleCommandBuilder(adapter1);
            adapter1.Update(ds.Tables[0]);
            MessageBox.Show("Updated Successfully");
        }

       
    }
}
