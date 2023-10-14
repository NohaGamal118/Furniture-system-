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
    public partial class Log_In : Form
    {
        string oracledatabase = "Data source=orcl1;User Id=scott; Password=tiger;";
        OracleConnection conn;
        
        public Log_In()
        {
            InitializeComponent();
        }
        string users;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            users = "User";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            users = "Managers";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(users=="User")
            {
                if (txt_Email.Text != string.Empty || txt_Password.Text != string.Empty)
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select * from SystemUsers  where Email=:e and Pass=:p";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(":e", txt_Email.Text);
                    command.Parameters.Add(":p", txt_Password.Text);
                    OracleDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();

                        this.Hide();
                        Home b = new Home();
                        b.Show();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show(" This email and password aren't vaild ");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all avaialbe fields.");
                }

            }
            else if(users=="Managers")
            {
                if (txt_Email.Text != string.Empty || txt_Password.Text != string.Empty)
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select * from SystemManagers where Email=:e and Pass=:p";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(":e", txt_Email.Text);
                    command.Parameters.Add(":p", txt_Password.Text);
                    OracleDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();

                        this.Hide();
                        Manager b = new Manager();
                        b.Show();

                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show(" This email and password aren't vaild ");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all avaialbe fields.");
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(oracledatabase);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
