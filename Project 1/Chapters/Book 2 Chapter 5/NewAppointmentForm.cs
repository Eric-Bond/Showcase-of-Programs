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
    public partial class NewAppointmentForm : Form
    {
        public NewAppointmentForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Appointments mAppointments = new Appointments();
        private RepairTypes mRepairTypes = new RepairTypes();
        private Customers mCustomers = new Customers();

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // Get input data and save to the Appointments Table
            DateTime Scheduled;

            try
            { Scheduled = Appointments.CombinedDateTime(dtpDate.Value.Date, DateTime.Parse(txtTime.Text)); }
            catch (Exception ex)
            { errProvider.SetError(txtTime, "Please enter a valid appointment time"); return; }

            short typeId = short.Parse(cboRepairType.SelectedValue.ToString());
            short custId = short.Parse(cboCustomer.SelectedValue.ToString());
            bool licensed = chkLicensed.Checked;

            if (mAppointments.Insert(typeId, txtDescription.Text, licensed, custId, Scheduled))
            { this.Close(); }
            else { lblStatus.Text = "Cannot Add Appointment. " + Appointments.LastError; }
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            // Fill the Repair Types ComboBox
            cboRepairType.DataSource = mRepairTypes.Items;
            cboRepairType.DisplayMember = "Description";
            cboRepairType.ValueMember = "TypeId";

            // Fill the Customers ComboBox
            cboCustomer.DataSource = mCustomers.Items;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustId";
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_NewAppointmentForm_All.png"); }
    }
}
