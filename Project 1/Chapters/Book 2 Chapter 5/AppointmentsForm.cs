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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private Appointments mAppointments = new Appointments();
        private Customers mCustomers = new Customers();
        private RepairTypes mRepairTypes = new RepairTypes();
        private bool formLoading = true;

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            // Fill the Customers ComboBox
            cboCustomer.ComboBox.DataSource = mCustomers.Items;
            cboCustomer.ComboBox.DisplayMember = "Name";
            cboCustomer.ComboBox.ValueMember = "CustId";
            cboCustomer.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.ComboBox.SelectedIndex = -1;

            // Fill the Repair Types ComboBox
            cboRepairType.ComboBox.DataSource = mRepairTypes.Items;
            cboRepairType.ComboBox.DisplayMember = "Description";
            cboRepairType.ComboBox.ValueMember = "TypeId";
            cboRepairType.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRepairType.ComboBox.SelectedIndex = -1;

            formLoading = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        { 
            // Show all Appointments
            dgvAppointments.DataSource = mAppointments.Items; 
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show Appointments for the selected Customer
            if (formLoading == false)
            {
                short custId = short.Parse(cboCustomer.ComboBox.SelectedValue.ToString());
                dgvAppointments.DataSource = mAppointments.GetByCustomerId(custId);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open the Modify Appointment Form for the selected Appointment
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                short apptId = short.Parse(dgvAppointments.SelectedRows[0].Cells[0].Value.ToString());

                ModAppointmentForm form = new ModAppointmentForm();
                form.AppointmentId = apptId;
                form.ShowDialog();

                dgvAppointments.DataSource = mAppointments.Items;
            }
            else { MessageBox.Show("Please select the appointment to edit"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected Appointment
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                short apptId = short.Parse(dgvAppointments.SelectedRows[0].Cells[0].Value.ToString());

                if (mAppointments.Delete(apptId)) { dgvAppointments.DataSource = mAppointments.Items; }
                else { MessageBox.Show("Unable to delete this appointment"); }
            }
        }

        private void cboRepairType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show Appointments for the selected Repair Type
            if (formLoading == false)
            {
                short typeId = short.Parse(cboRepairType.ComboBox.SelectedValue.ToString());
                dgvAppointments.DataSource = mAppointments.GetByRepairType(typeId);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentsForm_All.png"); }

        private void all2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentsForm_All2.png"); }
    }
}
