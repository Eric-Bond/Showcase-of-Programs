using Project_1.Chapters.Book_1_Chapter_11;
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
    public partial class B1CH11Form : Form
    {
        public B1CH11Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void arrayRB_CheckedChanged(object sender, EventArgs e)
        {
            infoLBL.Text = "This will seperate every character you type" +
                " into the textbox into an array, which is then shown " +
                "in the label below the textbox with commas separating each charater.";
        }

        private void dateRB_CheckedChanged(object sender, EventArgs e)
        {
            infoLBL.Text = "When you put a date into the textbox with the fashion " +
                "MM/DD/YYYY , this will separate the month, day and year into " +
                "separate strings, and then display it with some extra text.";
        }

        private void phoneRB_CheckedChanged(object sender, EventArgs e)
        {
            infoLBL.Text = "When you put a 10 digit phone number into the textbox" +
                " with no spaces or special characters (##########), this will format" +
                " it so that the area code is inside parethesis, and there is a dash.";
        }

        private void backwardsRB_CheckedChanged(object sender, EventArgs e)
        {
            infoLBL.Text = "This will take everything you type into the textbox" +
                " and return it backwards.. How fun!";
        }

        private void wordRB_CheckedChanged(object sender, EventArgs e)
        { infoLBL.Text = "This will count how many words you typed into the textbox."; }

        private void magicBTN_Click(object sender, EventArgs e)
        {
            // Use Method on input depending on which RadioButton is checked
            string input = inputTB.Text;

            if (arrayRB.Checked) { outputLBL.Text = input.CharArray(); }
            else if (dateRB.Checked) { outputLBL.Text = input.DateSplitter(); }
            else if (phoneRB.Checked)
            {
                if (input.PhoneNumberValidator())
                { outputLBL.Text = input.PhoneNumberFormatter(); }
                else { outputLBL.Text = "Enter a valid 10 digit number"; }
            }
            else if (backwardsRB.Checked) 
            {
                if (input != "") { outputLBL.Text = input.Backwards(); }
                else { outputLBL.Text = "You can't reverse what's not there.."; }
            }
            else if (wordRB.Checked) { outputLBL.Text = input.WordCounter(); }
            else { MessageBox.Show("Please select one of the options on the left"); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void radioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH11_RadioButtons.png"); }

        private void magicButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH11_MagicButton.png"); }

        private void extensionMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH11_ExtensionMethods.png"); }

        private void extensionMethods2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH11_ExtensionMethods2.png"); }
    }
}
