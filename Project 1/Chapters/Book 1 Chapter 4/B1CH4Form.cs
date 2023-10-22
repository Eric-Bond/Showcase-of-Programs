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
    public partial class B1CH4Form : Form
    {
        public B1CH4Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            // Change the Form's background color depending on which Radio Buttons are selected
            if (firstRedRadioButton.Checked && secondRedRadioButton.Checked)
            { this.BackColor = Color.Red; }
            else if (firstRedRadioButton.Checked && secondBlueRadioButton.Checked)
            { this.BackColor = Color.Purple; }
            else if (firstRedRadioButton.Checked && secondYellowRadioButton.Checked)
            { this.BackColor = Color.Orange; }
            else if (firstBlueRadioButton.Checked && secondRedRadioButton.Checked)
            { this.BackColor = Color.Purple; }
            else if (firstBlueRadioButton.Checked && secondBlueRadioButton.Checked)
            { this.BackColor = Color.Blue; }
            else if (firstBlueRadioButton.Checked && secondYellowRadioButton.Checked)
            { this.BackColor = Color.Green; }
            else if (firstYellowRadioButton.Checked && secondRedRadioButton.Checked)
            { this.BackColor = Color.Orange; }
            else if (firstYellowRadioButton.Checked && secondBlueRadioButton.Checked)
            { this.BackColor = Color.Green; }
            else if (firstYellowRadioButton.Checked && secondYellowRadioButton.Checked)
            { this.BackColor = Color.Yellow; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH4_All.png"); }
    }
}
