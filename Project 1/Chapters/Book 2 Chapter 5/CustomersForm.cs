using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Chapters.Book_2_Chapter_5
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Customers mCustomers = new Customers();

        private void CustomersForm_Load(object sender, EventArgs e)
        { 
            // Fill DataGridView with all Customers
            this.customersTableAdapter.Fill(this.repairServicesDataSet.Customers); 
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            // Open Modify Customer Form for the selected Customer
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                short custId = short.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());

                ModCustomerForm form = new ModCustomerForm();
                form.CustId = custId;
                form.ShowDialog();

                dgvCustomers.DataSource = mCustomers.Items;
            }
            else { MessageBox.Show("Please select the customer to edit"); }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_CustomersForm_All.png"); }
    }
}
