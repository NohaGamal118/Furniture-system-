using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_system
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChild(new profile());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order o = new Order();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In l = new Log_In();
            l.Show();
        }
        private Form activeform = null;
        private void OpenChild(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel3.Controls.Add(childform);
            panel3.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChild(new ManageFurniture());
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchReport o = new BranchReport();
            o.Show();
        }
    }
}
