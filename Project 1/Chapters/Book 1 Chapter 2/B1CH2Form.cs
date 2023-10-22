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
    public partial class B1CH2Form : Form
    {
        public B1CH2Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headsPicture.Visible = true;
            tailsPicture.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            headsPicture.Visible = false;
            tailsPicture.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH2_All.png"); }
    }
}
