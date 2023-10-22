using Project_1.Chapters.Book_2_Chapter_6;
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
    public partial class B2CH6Form : Form
    {
        public B2CH6Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        public WeatherStation myStation = new WeatherStation();

        SummaryForm sumForm;

        public int timesNormal = 0;
        public int timesLightning = 0;
        public int timesRaining = 0;
        public int timesSnowing = 0;
        public int timesTornado = 0;

        // Every time one of the Methods are called, it adds 1 to the Event's total, and displays a message
        private void myStation_Normal() { timesNormal += 1; lblEventDetected.Text = "The weather is normal"; }
        private void myStation_Lightning() { timesLightning += 1; lblEventDetected.Text = "A Lightning storm is in progress"; }
        private void myStation_Raining() { timesRaining += 1; lblEventDetected.Text = "Rainfall has been detected"; }
        private void myStation_Snowing() { timesSnowing += 1; lblEventDetected.Text = "It has begun to snow"; }
        private void myStation_Tornado() { timesTornado += 1; lblEventDetected.Text = "There is a tornado!"; }

        private void B2CH6Form_Load(object sender, EventArgs e)
        {
            // Add weather Methods to weather Delegate Events
            myStation.Normal += new WeatherStation.WeatherEvent(myStation_Normal);
            myStation.Lightning += new WeatherStation.WeatherEvent(myStation_Lightning);
            myStation.Raining += new WeatherStation.WeatherEvent(myStation_Raining);
            myStation.Snowing += new WeatherStation.WeatherEvent(myStation_Snowing);
            myStation.Tornado += new WeatherStation.WeatherEvent(myStation_Tornado);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Every time the Timer ticks, one Event is randomly selected. Share totals data with summary Form
            myStation.MonitorTheWeather();
            if (sumForm != null)
            {
                sumForm.timesNormal = timesNormal;
                sumForm.timesLightning = timesLightning;
                sumForm.timesRaining = timesRaining;
                sumForm.timesSnowing = timesSnowing;
                sumForm.timesTornado = timesTornado;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        { timer1.Enabled = true; }

        private void summaryBTN_Click(object sender, EventArgs e)
        {
            // Show summary Form and share totals data
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.myStation = myStation;
            sumForm = summaryForm;
            sumForm.timesNormal = timesNormal;
            sumForm.timesLightning = timesLightning;
            sumForm.timesRaining = timesRaining;
            sumForm.timesSnowing = timesSnowing;
            sumForm.timesTornado = timesTornado;
            summaryForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void variablesMethodsLoadToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH6_Variables&Methods&Load.png"); }

        private void timerTickButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH6_TimerTick&Buttons.png"); }

        private void weatherStationClassToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH6_WeatherStationClass.png"); }
    }
}
