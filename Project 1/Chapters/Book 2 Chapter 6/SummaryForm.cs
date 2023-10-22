using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.Chapters.Book_2_Chapter_6
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        public WeatherStation myStation = new WeatherStation();

        // Totals for how many times a weather Event occured
        public int timesNormal { set { normalOutputLBL.Text = value.ToString(); } }
        public int timesLightning { set { lightningOutputLBL.Text = value.ToString(); } }
        public int timesRaining { set { rainingOutputLBL.Text = value.ToString(); } }
        public int timesSnowing { set { snowingOutputLBL.Text = value.ToString(); } }
        public int timesTornado { set { tornadoOutputLBL.Text = value.ToString(); } }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH6_SummaryForm_All.png"); }
    }
}
