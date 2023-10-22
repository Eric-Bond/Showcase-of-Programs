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
    public partial class ModCustomerForm : Form
    {
        public ModCustomerForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Customers mCustomers = new Customers();
        public short CustId { get; set; }

        private void ModCustomerForm_Load(object sender, EventArgs e)
        {
            // Load Customer info into output Label
            RepairServicesDataSet.CustomersRow row;
            row = mCustomers.FindByCustId(CustId);
            outputLBL.Text = row.Name + " " + row.Phone;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // Get input data and update Customer
            if (firstNameTB.Text != "" && lastNameTB.Text != "" && phoneNumberTB.Text != "")
            {
                try
                {
                    mCustomers.UpdateInfo(lastNameTB.Text + ", " + firstNameTB.Text, phoneNumberTB.Text, CustId);
                    this.Close();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Please enter a first name, last name, and phone number."); }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_ModCustomerForm_All.png"); }
    }
}
