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
    public partial class B1CH1Form : Form
    {
        public B1CH1Form()
        {
            InitializeComponent();
        }

        double total = 1;

        private void B1CH1Form_Load(object sender, EventArgs e)
        {
            spasticLBL.Text = "Click to start...";
        }

        private void fastBoiTMR_Tick(object sender, EventArgs e)
        {
            spasticLBL.Text = total.ToString("n0");
            total = total + total;
            if (spasticLBL.Text == "∞") { fastBoiTMR.Enabled = false; }
        }

        private void spasticLBL_Click(object sender, EventArgs e)
        {
            if (fastBoiTMR.Enabled == false) { fastBoiTMR.Enabled = true; }
            else { fastBoiTMR.Enabled = false; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH1_All.png"); }

        private void popupFormToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH1_PopupForm.png"); }
    }
}
