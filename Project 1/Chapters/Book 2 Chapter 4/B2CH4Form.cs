using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class B2CH4Form : Form
    {
        public B2CH4Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void B2CH4Form_Load(object sender, EventArgs e)
        {
            // Load sales staff database table into TableAdapter, showing full time staff
            this.salesStaffTableAdapter.FillByFullPartTime(this.salesStaffDataSet.SalesStaff, true);
            decimal output = (decimal)this.salesStaffTableAdapter.AVGSalary(true);
            outputLBL.Text = output.ToString("c2");
        }

        private void fullTimeRB_CheckedChanged(object sender, EventArgs e)
        {
            // Load full time sales staff into TableAdapter
            this.salesStaffTableAdapter.FillByFullPartTime(this.salesStaffDataSet.SalesStaff, true);
            decimal output = (decimal)this.salesStaffTableAdapter.AVGSalary(true);
            outputLBL.Text = output.ToString("c2");
        }

        private void partTimeRB_CheckedChanged(object sender, EventArgs e)
        {
            // Load part time sales staff into TableAdapter
            this.salesStaffTableAdapter.FillByFullPartTime(this.salesStaffDataSet.SalesStaff, false);
            decimal output = (decimal)this.salesStaffTableAdapter.AVGSalary(false);
            outputLBL.Text = output.ToString("c2");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH4_All.png"); }
    }
}
