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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Customers mCustomers = new Customers();

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // Get input data and save to the Customers Table
            short custId = (short)(mCustomers.HighestCustId() + 10);

            if (lastNameTB.Text != "" && firstNameTB.Text != "" && phoneNumberTB.Text != "")
            {
                if (mCustomers.Insert(custId, lastNameTB.Text + ", " + firstNameTB.Text, phoneNumberTB.Text))
                { this.Close(); }
                else { MessageBox.Show("Cannot Add Customer. " + Appointments.LastError); }
            }
            else { MessageBox.Show("Please enter a first name, last name, and phone number."); }
        }

        private void viewCustomersBTN_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();
            form.ShowDialog();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_NewCustomerForm_All.png"); }
    }
}
