using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class B1CH7Form : Form
    {
        public B1CH7Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        StreamReader inputFile1;
        StreamReader inputFile2;
        List<string> allNamesList = new List<string>();

        private void B1CH7Form_Load(object sender, EventArgs e)
        {
            // Add names from text files into list
            inputFile1 = File.OpenText("BoyNames.txt");
            while (!inputFile1.EndOfStream) { allNamesList.Add(inputFile1.ReadLine()); }

            inputFile2 = File.OpenText("GirlNames.txt");
            while (!inputFile2.EndOfStream) { allNamesList.Add(inputFile2.ReadLine()); }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get input name from TextBox, and check if name is in list
            try
            {
                string inputName = UniversalCode.NameCapitalizer(searchTextBox.Text);
                int position = allNamesList.IndexOf(inputName);
                if (position != -1) { MessageBox.Show(inputName + " was one of the top 200 names!"); }
                else { MessageBox.Show(inputName + " was not one of the top 200."); }
            }
            catch { MessageBox.Show("Please put a valid name."); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH7_All.png"); }
    }
}
