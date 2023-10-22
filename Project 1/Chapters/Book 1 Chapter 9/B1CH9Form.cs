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
    public partial class B1CH9Form : Form
    {
        public B1CH9Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        Random slot1Randomizer;
        Random slot2Randomizer;
        Random slot3Randomizer;

        double moneySpent = 0;
        double moneyWon = 0;
        double insertedMoney = 0;

        int rand1;
        int rand2;
        int rand3;

        private void PictureChoice(PictureBox PB, int rand)
        {
            switch (rand)
            {
                case 1:
                    { PB.Image = Properties.Resources.Apple; break; }
                case 2:
                    { PB.Image = Properties.Resources.Banana; break; }
                case 3:
                    { PB.Image = Properties.Resources.Cherries; break; }
                case 4:
                    { PB.Image = Properties.Resources.Grapes; break; }
                case 5:
                    { PB.Image = Properties.Resources.Lemon; break; }
                case 6:
                    { PB.Image = Properties.Resources.Lime; break; }
                case 7:
                    { PB.Image = Properties.Resources.Orange; break; }
                case 8:
                    { PB.Image = Properties.Resources.Pear; break; }
                case 9:
                    { PB.Image = Properties.Resources.Strawberry; break; }
                case 10:
                    { PB.Image = Properties.Resources.Watermelon; break; }
            }
        }
        private void NoneMatch()
        {
            if (rand1 != rand2 && rand2 != rand3 && rand1 != rand3)
            {
                moneySpent += insertedMoney;
                MessageBox.Show("You won $0");
            }
        }
        private void TwoMatch()
        {
            if (rand1 == rand2 || rand2 == rand3 || rand1 == rand3)
            {
                moneySpent += insertedMoney;
                moneyWon += insertedMoney * 2;
                MessageBox.Show("You won $" + insertedMoney * 2);
            }
        }

        private void ThreeMatch()
        {
            if (rand1 == rand2 && rand2 == rand3)
            {
                moneySpent += insertedMoney;
                moneyWon += insertedMoney * 3;
                MessageBox.Show("You won $" + insertedMoney * 3);
            }
        }

        private void B1CH9Form_Load(object sender, EventArgs e)
        {
            int seed = (int)DateTime.Now.Ticks;
            slot1Randomizer = new Random(seed);
            slot2Randomizer = new Random(seed + 1);
            slot3Randomizer = new Random(seed + 2);
        }

        private void spinBTN_Click(object sender, EventArgs e)
        {
            // Get money input, randomize numbers, show according pictures, and show result
            if (double.TryParse(insertedTB.Text, out insertedMoney))
            {
                if (insertedMoney > 0)
                {
                    rand1 = slot1Randomizer.Next(1, 11);
                    rand2 = slot2Randomizer.Next(1, 11);
                    rand3 = slot3Randomizer.Next(1, 11);

                    PictureChoice(PBslot1, rand1);
                    PictureChoice(PBslot2, rand2);
                    PictureChoice(PBslot3, rand3);

                    NoneMatch();
                    TwoMatch();
                    ThreeMatch();
                }
                else { MessageBox.Show("Be realistic now..."); }
            }
            else { MessageBox.Show("Please enter some money!"); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void variablesPBMethodToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH9_Variables&Method.png"); }

        private void matchMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH9_Methods.png"); }

        private void loadSpinButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH9_Load&SpinButton.png"); }
    }
}
