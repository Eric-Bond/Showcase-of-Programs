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
    public partial class B1CH14Form : Form
    {
        public B1CH14Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private List<string> Words1List = new List<string>();
        private List<string> Words2List = new List<string>();
        private List<string> AllWords = new List<string>();
        private IEnumerable<string> DistinctWords = new List<string>();
        private IEnumerable<string> NotBoth = new List<string>();

        private void B1CH14Form_Load(object sender, EventArgs e)
        {
            // Put words from text files into Lists
            StreamReader inputFile = File.OpenText("Words1.txt");
            while (!inputFile.EndOfStream) { Words1List.Add(inputFile.ReadLine()); }

            StreamReader inputFile2 = File.OpenText("Words2.txt");
            while (!inputFile2.EndOfStream) { Words2List.Add(inputFile2.ReadLine()); }

            foreach (string word in Words1List) { AllWords.Add(word); }
            foreach (string word in Words2List) { AllWords.Add(word); }
        }

        private void uniqueRB_CheckedChanged(object sender, EventArgs e)
        {
            // Show each unique word once (no duplicates)
            outputLB.Items.Clear();

            DistinctWords = AllWords.Distinct();
            foreach (string word in DistinctWords) { outputLB.Items.Add(word); }
        }

        private void bothRB_CheckedChanged(object sender, EventArgs e)
        {
            // Show all words from both Lists
            outputLB.Items.Clear();

            foreach (string word in Words1List) { outputLB.Items.Add(word); }
            foreach (string word in Words2List) { outputLB.Items.Add(word); }
        }

        private void firstRB_CheckedChanged(object sender, EventArgs e)
        {
            // Show words only from first List
            outputLB.Items.Clear();

            foreach (string word in Words1List) { outputLB.Items.Add(word); }
        }

        private void secondRB_CheckedChanged(object sender, EventArgs e)
        {
            // Show words only from second List
            outputLB.Items.Clear();

            foreach (string word in Words2List) { outputLB.Items.Add(word); }
        }

        private void eitherRB_CheckedChanged(object sender, EventArgs e)
        {
            // Show all words that are only in one of the Lists
            outputLB.Items.Clear();

            NotBoth = Words1List.Except(Words2List);
            foreach (string word in NotBoth) { outputLB.Items.Add(word); }

            NotBoth = Words2List.Except(Words1List);
            foreach (string word in NotBoth) { outputLB.Items.Add(word); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void variablesLoadToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH14_Variables&Load.png"); }

        private void radioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH14_RadioButtons.png"); }
    }
}
