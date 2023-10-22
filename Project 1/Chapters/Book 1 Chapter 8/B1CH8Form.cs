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
    public partial class B1CH8Form : Form
    {
        public B1CH8Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            /* Grab input from TextBox, break string into array,
               add all numbers together, and show result */
            try
            {
                string str = inputTB.Text;
                int total = 0;
                char[] delim = { ',' };
                string[] tokens = str.Split(delim);

                foreach (string s in tokens) { total += int.Parse(s); }

                MessageBox.Show("The sum is " + total);
            }
            catch { MessageBox.Show("Please type input as directed."); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH8_All.png"); }
    }
}
