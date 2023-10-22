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
    public partial class B2CH7Form : Form
    {
        public B2CH7Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        KarateClassesDataContext db = new KarateClassesDataContext();
        Payment payment = new Payment();

        private void B2CH7Form_Load(object sender, EventArgs e)
        {
            /* Create a query of payments by members, group the payments to the member,
               add the groups to the output ListBox, and make the output look fancy */
            var query = from payment in db.Payments
                        group payment by payment.Member_Id
                        into MemberGroup
                        select MemberGroup;

            foreach (var member in query)
            {
                outputLB.Items.Add("Member ID = " + member.Key.ToString());

                foreach (var payment in member)
                {
                    outputLB.Items.Add('\t' + payment.Amount.ToString("C")
                        + ", " + payment.Payment_Date.ToString("MM/dd/yy"));
                }
                outputLB.Items.Add("");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH7_All.png"); }
    }
}
