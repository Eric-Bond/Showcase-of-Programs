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
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            infoLBL.Text = "So you clicked the view button anyway... \n Fair enough, I did give you the option to. \n \n" +
                "Since you're here, I suppose I could show you something I found out when messing around creating silly " +
                "programs. \n \n Go ahead, press the button.";
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            B1CH1Form form = new B1CH1Form();
            form.Show();
            this.Close();
        }
    }
}
