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
    public partial class B1CH10Form : Form
    {
        public B1CH10Form()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        class Pet
        {
            public Pet()
            {
                Name = "";
                Type = "";
                Age = 0;
            }
            public string Name { get; set; }
            public string Type { get; set; }
            public int Age { get; set; }
        }

        private void GetPetData(Pet pet)
        {
            // Set Pet variables
            int age;
            pet.Name = nameTextBox.Text;
            pet.Type = typeTextBox.Text;

            if (int.TryParse(ageTextBox.Text, out age)) { pet.Age = age; }
            else { MessageBox.Show("Invalid age"); }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Show Pet data in output labels
            Pet pet = new Pet();

            GetPetData(pet);

            nameLabel.Text = pet.Name;
            typeLabel.Text = pet.Type;
            ageLabel.Text = pet.Age.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\B1CH10_All.png"); }
    }
}
