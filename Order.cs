using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Furniture_system
{
    public partial class Order : Form
    {
        //OrdersReport Or;
        OrdersReport cr;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            //Or = new OrdersReport();
            cr = new OrdersReport();
            foreach(ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
            {
                Manager_cmb.Items.Add(v.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, Manager_cmb.Text);

            crystalReportViewer1.ReportSource = cr;
        }
    }
}
