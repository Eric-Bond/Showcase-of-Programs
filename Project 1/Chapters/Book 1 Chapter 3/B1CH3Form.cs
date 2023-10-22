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
    public partial class B1CH3Form : Form
    {
        public B1CH3Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        // Every Button aside from the clear Button adds text onto the output Label's string
        private void input_Upper_A_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "A"; }

        private void input_Lower_A_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "a"; }

        private void input_Upper_An_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "An"; }

        private void input_Lower_An_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "an"; }

        private void input_Upper_The_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "The"; }

        private void input_Lower_The_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "the"; }

        private void input_Man_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "man"; }

        private void input_Woman_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "woman"; }

        private void input_Dog_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "dog"; }

        private void input_Cat_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "cat"; }

        private void input_Car_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "car"; }

        private void input_Bicycle_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "bicycle"; }

        private void input_Beautiful_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "beautiful"; }

        private void input_Big_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "big"; }

        private void input_Small_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "small"; }

        private void input_Strange_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "strange"; }

        private void input_LookedAt_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "looked at"; }

        private void input_Rode_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "rode"; }

        private void input_SpokeTo_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "spoke to"; }

        private void input_LaughedAt_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "laughed at"; }

        private void input_Drove_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "drove"; }

        private void input_Space_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += " "; }

        private void input_Period_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "."; }

        private void input_Exclamation_Button_Click(object sender, EventArgs e)
        { textOutputLabel.Text += "!"; }

        private void clearOutputButton_Click(object sender, EventArgs e)
        { textOutputLabel.Text = ""; }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH3_All.png"); }

        private void all2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH3_All2.png"); }
    }
}
