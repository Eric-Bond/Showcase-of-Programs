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
    public partial class B2CH3Form : Form
    {
        public B2CH3Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        public class Account
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Balance { get; set; }

            public Account(string pId, string pName, string pBalance)
            {
                IsValidInput(pId, pName, pBalance);
            }

            public bool IsValidInput(string vId, string vName, string vBalance)
            {
                bool isValid = true;
                if (vId == "" || vId == null)
                {
                    MessageBox.Show("Please enter a valid Id.");
                    return false;
                }
                else { Id = Convert.ToInt32(vId); }

                if (vName == "" || vName == null)
                {
                    MessageBox.Show("Please enter a name.");
                    return false;
                }
                else { Name = vName; }

                if (vBalance == "" || vBalance == null)
                {
                    MessageBox.Show("Please enter a valid balance.");
                    return false;
                }
                else { Balance = Convert.ToDouble(vBalance); }

                return isValid;
            }
        }

        private Dictionary<int, Account> accounts = new Dictionary<int, Account>();

        private void B2CH3Form_Load(object sender, EventArgs e)
        {
            // Add accounts and display in output ListBox
            accounts.Add(1234, new Account("1234", "Eric", "1234.56"));
            accounts.Add(1010, new Account("1010", "Brian", "1993.05"));
            accounts.Add(1111, new Account("1111", "Joe", "987"));
            accounts.Add(1357, new Account("1357", "Leo", "5555.55"));

            foreach (KeyValuePair<int, Account> account in accounts)
            { outputLB.Items.Add(account.Value.Id.ToString() + ", " + account.Value.Name + ", " + account.Value.Balance.ToString("n")); }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            // Get user input, add new account, and reload output to show new account
            Account newAccount = new Account(idTB.Text, nameTB.Text, balanceTB.Text);
            if (newAccount.Id == 0) { return; }
            else if (newAccount.Name == "" || newAccount.Name == null) { return; }
            else if (newAccount.Balance == 0) { return; }

            if (accounts.Keys.Contains(int.Parse(idTB.Text)))
            { MessageBox.Show("Account Id " + int.Parse(idTB.Text) + " already exists."); }
            else { accounts.Add(newAccount.Id, newAccount); }

            outputLB.Items.Clear();

            foreach (KeyValuePair<int, Account> account in accounts)
            { outputLB.Items.Add(account.Value.Id.ToString() + ", " + account.Value.Name + ", " + account.Value.Balance.ToString("n")); }
        }

        private void replaceBTN_Click(object sender, EventArgs e)
        {
            // Get user input, update account, and reload output to show updated account
            try
            {
                if (accounts.Keys.Contains(int.Parse(idTB.Text)))
                {
                    bool valid = accounts[int.Parse(idTB.Text)].IsValidInput(idTB.Text, nameTB.Text, balanceTB.Text);
                    if (valid == true)
                    {
                        outputLB.Items.Clear();

                        foreach (KeyValuePair<int, Account> account in accounts)
                        { outputLB.Items.Add(account.Value.Id.ToString() + ", " + account.Value.Name + ", " + account.Value.Balance.ToString("n")); }
                    }
                }
                else { MessageBox.Show("Account Id " + idTB.Text + " does not exist."); }
            }
            catch { MessageBox.Show("Please enter a valid Id."); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void classMethodToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH3_Class&Method.png"); }

        private void loadAddButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH3_Load&AddButton.png"); }

        private void replaceButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B2CH3_ReplaceButton.png"); }
    }
}
