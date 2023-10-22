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
    public partial class B2CH2Form : Form
    {
        public B2CH2Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private string folderPath;
        private PictureBox[] pics;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Open a folder browser to select a folder with pictures in it
               and add the pictures to PictureBoxes inside of the FlowPanel */
            folderBrowser.SelectedPath = Directory.GetCurrentDirectory();

            if (folderBrowser.ShowDialog() == DialogResult.Cancel) { return; }

            folderPath = folderBrowser.SelectedPath;
            string[] fileNames = Directory.GetFiles(folderPath);

            if (fileNames.Length == 0)
            { MessageBox.Show("Unable to find any image files."); return; }

            this.Text = folderPath;

            pics = new PictureBox[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                pics[i] = new PictureBox();
                pics[i].Size = new System.Drawing.Size(100, 100);
                pics[i].SizeMode = PictureBoxSizeMode.Zoom;
                pics[i].Image = new Bitmap(fileNames[i]);
                FlowPanel.Controls.Add(pics[i]);
                pics[i].Click += new System.EventHandler(this.Btn_Click);
                pics[i].Cursor = Cursors.Hand;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            /* Open a new Form with the picture that was clicked on,
               making it bigger and able to be resized */
            PictureBox pictureBox = new PictureBox();
            pictureBox = (PictureBox)sender;
            B2CH2Form2 form = new B2CH2Form2();
            form.pictureBox1.Image = pictureBox.Image;
            form.pictureBox1.Size = new System.Drawing.Size(300, 300);
            form.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH2_All.png"); }
    }
}
