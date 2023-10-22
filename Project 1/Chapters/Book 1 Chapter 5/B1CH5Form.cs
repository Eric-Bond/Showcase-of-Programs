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
    public partial class B1CH5Form : Form
    {
        public B1CH5Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /* Create variables, get variable data from TextBoxes,
               calculate conversion, and show results in output ListBox */
            int speed;
            int hours;
            int distance;
            int count = 1;

            distanceTraveledListBox.Items.Clear();

            if (int.TryParse(speedTextBox.Text, out speed))
            {
                if (int.TryParse(hoursTextBox.Text, out hours))
                {
                    while (count <= hours)
                    {
                        distance = speed * count;
                        distanceTraveledListBox.Items.Add("After " + count +
                        " hours you have traveled " + distance.ToString("") + " miles.");
                        count++;
                    }
                }
                else { MessageBox.Show("Invalid value for hours."); }
            }
            else { MessageBox.Show("Invalid value for speed."); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH5_All.png"); }
    }
}
