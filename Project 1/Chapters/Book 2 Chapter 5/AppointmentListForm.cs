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
    public partial class AppointmentListForm : Form
    {
        public AppointmentListForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void AppointmentListForm_Load(object sender, EventArgs e)
        {
            // Fill the DataGridView with all Appointments
            Appointments mAppointments = new Appointments();
            dgvAppointments.DataSource = mAppointments.AppointmentList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentListForm_All.png"); }
    }
}
