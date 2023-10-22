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
    public partial class ModAppointmentForm : Form
    {
        public ModAppointmentForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Appointments mAppointments = new Appointments();
        private RepairTypes mRepairTypes = new RepairTypes();
        private Customers mCustomers = new Customers();
        public short AppointmentId { get; set; }

        private void ModAppointmentForm_Load(object sender, EventArgs e)
        {
            // Fill the Repair Types ComboBox
            cboRepairType.DataSource = mRepairTypes.Items;
            cboRepairType.DisplayMember = "Description";
            cboRepairType.ValueMember = "TypeId";

            // Fill the Customers ComboBox
            cboCustomer.DataSource = mCustomers.Items;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustId";

            // Get the selected appointment and display in the form's controls
            RepairServicesDataSet.AppointmentsRow row;
            row = mAppointments.FindByApptId(AppointmentId);
            dtpDate.Value = row.Scheduled.Date;
            txtTime.Text = row.Scheduled.TimeOfDay.ToString();
            chkLicensed.Checked = row.Licensed;
            txtDescription.Text = row.Description;
            cboRepairType.SelectedValue = row.TypeId;
            cboCustomer.SelectedValue = row.CustId;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // Get input data and update the Appointment
            DateTime Scheduled;
            try
            {
                Scheduled = Appointments.CombinedDateTime(dtpDate.Value.Date,
                DateTime.Parse(txtTime.Text.ToString()));
            }
            catch (Exception ex)
            {
                errProvider.SetError(txtTime, "Please enter a valid appointment time");
                return;
            }
            short typeId = short.Parse(cboRepairType.SelectedValue.ToString());
            short custId = short.Parse(cboCustomer.SelectedValue.ToString());
            bool licensed = chkLicensed.Checked;

            if (mAppointments.Update(typeId, txtDescription.Text, licensed, custId, Scheduled, AppointmentId))
            { this.Close(); }
            else { lblStatus.Text = "Cannot update the Appointment." + Appointments.LastError; }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_ModAppointmentForm_All.png"); }

        private void all2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_ModAppointmentForm_All2.png"); }
    }
}
