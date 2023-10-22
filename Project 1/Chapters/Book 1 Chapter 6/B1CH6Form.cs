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
    public partial class B1CH6Form : Form
    {
        public B1CH6Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void NormalCursor()
        {
            playerRockPic.Cursor = Cursors.Default;
            playerPaperPic.Cursor = Cursors.Default;
            playerScissorsPic.Cursor = Cursors.Default;
        }

        Random rand;
        int botChoice;

        private void PlayerChoseRock()
        {
            playerPaperPic.Visible = false;
            playerScissorsPic.Visible = false;
        }

        private void PlayerChosePaper()
        {
            playerRockPic.Visible = false;
            playerScissorsPic.Visible = false;
        }

        private void PlayerChoseScissors()
        {
            playerRockPic.Visible = false;
            playerPaperPic.Visible = false;
        }

        private void BotChoseRock()
        { botRockPic.Visible = true; }

        private void BotChosePaper()
        { botPaperPic.Visible = true; }

        private void BotChoseScissors()
        { botScissorsPic.Visible = true; }

        private void YouWon()
        { winLabel.Visible = true; }

        private void YouLost()
        { loseLabel.Visible = true; }

        private void Tie()
        { tieLabel.Visible = true; }

        private void Restart()
        {
            playerRockPic.Visible = true;
            playerPaperPic.Visible = true;
            playerScissorsPic.Visible = true;
            botRockPic.Visible = false;
            botPaperPic.Visible = false;
            botScissorsPic.Visible = false;
            loseLabel.Visible = false;
            winLabel.Visible = false;
            tieLabel.Visible = false;

            botChoice = rand.Next(1, 4);

            playerRockPic.Cursor = Cursors.Hand;
            playerPaperPic.Cursor = Cursors.Hand;
            playerScissorsPic.Cursor = Cursors.Hand;
        }

        private void B1CH6Form_Load(object sender, EventArgs e)
        {
            int seed = (int)DateTime.Now.Ticks;
            rand = new Random(seed);
            botChoice = rand.Next(1, 4);
        }

        private void playerRockPic_Click(object sender, EventArgs e)
        {
            PlayerChoseRock();
            if (botChoice == 1)
            {
                BotChoseRock();
                Tie();
            }
            else if (botChoice == 2)
            {
                BotChosePaper();
                YouLost();
            }
            else if (botChoice == 3)
            {
                BotChoseScissors();
                YouWon();
            }
            NormalCursor();
        }

        private void playerPaperPic_Click(object sender, EventArgs e)
        {
            PlayerChosePaper();
            if (botChoice == 1)
            {
                BotChoseRock();
                YouWon();
            }
            else if (botChoice == 2)
            {
                BotChosePaper();
                Tie();
            }
            else if (botChoice == 3)
            {
                BotChoseScissors();
                YouLost();
            }
            NormalCursor();
        }

        private void playerScissorsPic_Click(object sender, EventArgs e)
        {
            PlayerChoseScissors();
            if (botChoice == 1)
            {
                BotChoseRock();
                YouLost();
            }
            else if (botChoice == 2)
            {
                BotChosePaper();
                YouWon();
            }
            else if (botChoice == 3)
            {
                BotChoseScissors();
                Tie();
            }
            NormalCursor();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        { Restart(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void methodsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH6_Methods.png"); }

        private void methods2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH6_Methods2.png"); }

        private void loadPicClickToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH6_Load&PicClick.png"); }

        private void picClicksPlayAgainToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH6_PicClicks&PlayAgain.png"); }
    }
}
