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
    public partial class B1CH13Form : Form
    {
        public B1CH13Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private List<int> AllNumbers = new List<int>();
        private int iNum;

        Predicate<int> checkPrime = delegate (int inputN)
        {
            bool isPrime = true;

            for (int i = 2; i < inputN; i++)
            {
                if (inputN % i == 0) { isPrime = false; }
            }
            return isPrime;
        };

        private void findBTN_Click(object sender, EventArgs e)
        {
            /* Grab input number, find all prime numbers lower than that number,
               and display results (including a count of how many there were) */
            AllNumbers.Clear();
            outputLB.Items.Clear();
            outputTotalLBL.Text = "";

            try { iNum = int.Parse(inputTB.Text); }
            catch { MessageBox.Show("Please enter a valid number."); }

            for (int n = 2; n <= iNum; n++) { AllNumbers.Add(n); }

            List<int> PrimeNumbers = AllNumbers.FindAll(checkPrime);

            foreach (int numbers in PrimeNumbers) { outputLB.Items.Add(numbers); }

            int count = PrimeNumbers.Count();
            outputTotalLBL.Text = count.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH13_All.png"); }
    }
}
