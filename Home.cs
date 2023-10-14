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

    public partial class Home : Form
    {
        public Home()
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

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChild(new Booking());
        }

        private void Home_Load(object sender, EventArgs e)
        {
           // Or = new OrdersReport();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Log_In l = new Log_In();
            l.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private Form activeform = null;
        private void OpenChild(Form childform)
        {
            if(activeform!=null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel4.Controls.Add(childform);
            panel4.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
