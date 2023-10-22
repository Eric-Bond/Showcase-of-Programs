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
    public partial class TableOfContentsForm : Form
    {
        public TableOfContentsForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        Dictionary<string, Label> chapters = new Dictionary<string, Label>();

        Label lbl = new Label();

        private void TableOfContentsForm_Load(object sender, EventArgs e)
        {
            bookCB.Items.Add("Book 1");
            bookCB.Items.Add("Book 2");

            book1PNL.Visible = false;
            book2PNL.Visible = false;

            PanelSetup();
        }

        private void bookCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected book Panel
            if (bookCB.SelectedIndex == 0) { book1PNL.Visible = true; book2PNL.Visible = false; }
            else if (bookCB.SelectedIndex == 1) { book1PNL.Visible = false; book2PNL.Visible = true; }
        }

        private void PanelSetup()
        {
            // Used to create all the EventHandlers and add the Labels to the Dictionary
            for (int i = 1; i <= 14; i++)
            {
                // Book Panels (master Panel) loop
                foreach (Control bookPanel in this.Controls)
                {
                    bookPanel.MouseEnter += new System.EventHandler(this.bookPanel_MouseEnter);

                    Type type = bookPanel.GetType();
                    if (type == typeof(Panel))
                    {
                        // Chapter Panels loop
                        foreach (Control chapterPanel in bookPanel.Controls)
                        {
                            type = chapterPanel.GetType();
                            if (type == typeof(Panel))
                            {
                                // Chapter Labels loop
                                foreach (Control chapterLabel in chapterPanel.Controls)
                                {
                                    type = chapterLabel.GetType();
                                    if (type == typeof(Label))
                                    {
                                        if (!chapters.ContainsKey(chapterLabel.Name))
                                        {
                                            // Add the chapter Labels to the Dictionary, and create EventHandlers for each one
                                            chapters.Add(chapterLabel.Name, (Label)chapterLabel);
                                            chapterLabel.MouseEnter += new System.EventHandler(this.chapterLabel_MouseEnter);
                                            chapterLabel.Click += new System.EventHandler(this.chapterLabel_Click);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void chapterLabel_MouseEnter(object sender, EventArgs e)
        {
            // Change the visuals for the chapter Label when the mouse hovers over it
            Label label = (Label)sender;
            lbl = chapters[label.Name];
            lbl.BackColor = Color.LightCyan;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
        }

        private void bookPanel_MouseEnter(object sender, EventArgs e)
        {
            // Reset the chapter Label visuals every time the mouse hovers over the bookPanel
            foreach (KeyValuePair<string, Label> item in chapters)
            {
                item.Value.BackColor = Color.Transparent;
                item.Value.Font = new Font(item.Value.Font, FontStyle.Regular);
            }
        }

        private void chapterLabel_Click(object sender, EventArgs e)
        {
            /* Open the Form according to which chapter Label is clicked,
               and change the BackColor of the clicked Label */
            Label lbl = (Label)sender;

            if (lbl.Name == "b1ch1LBL") { PopupForm form = new PopupForm(); form.Show(); }
            else if (lbl.Name == "b1ch2LBL") { B1CH2Form form = new B1CH2Form(); form.Show(); }
            else if (lbl.Name == "b1ch3LBL") { B1CH3Form form = new B1CH3Form(); form.Show(); }
            else if (lbl.Name == "b1ch4LBL") { B1CH4Form form = new B1CH4Form(); form.Show(); }
            else if (lbl.Name == "b1ch5LBL") { B1CH5Form form = new B1CH5Form(); form.Show(); }
            else if (lbl.Name == "b1ch6LBL") { B1CH6Form form = new B1CH6Form(); form.Show(); }
            else if (lbl.Name == "b1ch7LBL") { B1CH7Form form = new B1CH7Form(); form.Show(); }
            else if (lbl.Name == "b1ch8LBL") { B1CH8Form form = new B1CH8Form(); form.Show(); }
            else if (lbl.Name == "b1ch9LBL") { B1CH9Form form = new B1CH9Form(); form.Show(); }
            else if (lbl.Name == "b1ch10LBL") { B1CH10Form form = new B1CH10Form(); form.Show(); }
            else if (lbl.Name == "b1ch11LBL") { B1CH11Form form = new B1CH11Form(); form.Show(); }
            else if (lbl.Name == "b1ch12LBL") { B1CH12Form form = new B1CH12Form(); form.Show(); }
            else if (lbl.Name == "b1ch13LBL") { B1CH13Form form = new B1CH13Form(); form.Show(); }
            else if (lbl.Name == "b1ch14LBL") { B1CH14Form form = new B1CH14Form(); form.Show(); }
            else if (lbl.Name == "b2ch1LBL") { B2CH1Form form = new B2CH1Form(); form.Show(); }
            else if (lbl.Name == "b2ch2LBL") { B2CH2Form form = new B2CH2Form(); form.Show(); }
            else if (lbl.Name == "b2ch3LBL") { B2CH3Form form = new B2CH3Form(); form.Show(); }
            else if (lbl.Name == "b2ch4LBL") { B2CH4Form form = new B2CH4Form(); form.Show(); }
            else if (lbl.Name == "b2ch5LBL") { B2CH5Form form = new B2CH5Form(); form.Show(); }
            else if (lbl.Name == "b2ch6LBL") { B2CH6Form form = new B2CH6Form(); form.Show(); }
            else if (lbl.Name == "b2ch7LBL") { B2CH7Form form = new B2CH7Form(); form.Show(); }

            lbl.BackColor = Color.LightGreen;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void variablesLoadBookCBToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\TableOfContentsForm_Variables&Load&BookCB.png"); }

        private void panelSetupMethodToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\TableOfContentsForm_PanelSetupMethod.png"); }

        private void mouseEnterEventsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\TableOfContentsForm_MouseEnterEvents.png"); }

        private void chapterLabelsClickToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\TableOfContentsForm_ChapterLabelClick.png"); }
    }
}
