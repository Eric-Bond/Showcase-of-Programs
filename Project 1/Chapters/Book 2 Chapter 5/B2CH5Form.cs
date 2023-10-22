using Project_1.Chapters.Book_2_Chapter_5;
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
    public partial class B2CH5Form : Form
    {
        public B2CH5Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        // Load Form according to which Menu Item is pressed
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAppointmentForm frm = new NewAppointmentForm();
            frm.ShowDialog();
        }

        private void viewAppointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentsForm frm = new AppointmentsForm();
            frm.ShowDialog();
        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentListForm frm = new AppointmentListForm();
            frm.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewCustomerForm frm = new NewCustomerForm();
            frm.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void menuItemsClickToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_MenuItemsClick.png"); }

        private void appointmentsClassToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentsClass.png"); }

        private void appointmentsClass2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentsClass2.png"); }

        private void appointmentsClass3ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_AppointmentsClass3.png"); }

        private void customersClassToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_CustomersClass.png"); }

        private void customersClass2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_CustomersClass2.png"); }

        private void repairTypesClassToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH5_RepairTypesClass.png"); }
    }
}
