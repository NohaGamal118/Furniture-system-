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
    public partial class BranchReport : Form
    {
        CrystalReport6 c;
        public BranchReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BranchReport_Load(object sender, EventArgs e)
        {
            c = new CrystalReport6();
            foreach (ParameterDiscreteValue v in c.ParameterFields[0].DefaultValues)
            {
                Manager_cmb.Items.Add(v.Value);
            }
        }

        private void Manager_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.SetParameterValue(0, Manager_cmb.Text);

            crystalReportViewer1.ReportSource = c;
        }
    }
}
