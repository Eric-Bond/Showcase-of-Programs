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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            { UniversalCode.SetCursorEventsOnControls(control, Cursors.Hand); }
        }

        private void ViewButtonActivator()
        {
            // View Button is not active unless a book and a chapter are both selected from ComboBoxes
            if (bookCB.SelectedItem != null && chapterCB.SelectedItem != null)
            { viewBTN.Enabled = true; }
            else { viewBTN.Enabled = false; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add the books to book ComboBox, clear details Label, and disable the View Button
            bookCB.Items.Add("1. Starting Out With Visual C#");
            bookCB.Items.Add("2. Advanced Visual C#");

            detailsLBL.Text = "";
            ViewButtonActivator();
            

            // Center ComboBox text after the item is selected
            bookCB.DrawMode = DrawMode.OwnerDrawVariable;
            bookCB.DrawItem += UniversalCode.comboBox_DrawItem;
            chapterCB.DrawMode = DrawMode.OwnerDrawVariable;
            chapterCB.DrawItem += UniversalCode.comboBox_DrawItem;
        }

        private void bookCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add the chapters to the chapter ComboBox depending on which book is selected
            if (bookCB.SelectedIndex == 0)
            {
                chapterCB.Items.Clear();
                chapterCB.Text = "";
                chapterCB.Items.Add("1: Introduction to Computers and Programming");
                chapterCB.Items.Add("2: Introduction to Visual C#");
                chapterCB.Items.Add("3: Processing Data");
                chapterCB.Items.Add("4: Making Decisions");
                chapterCB.Items.Add("5: Loops, Files, and Random Numbers");
                chapterCB.Items.Add("6: Modularizing Your Code with Methods");
                chapterCB.Items.Add("7: Arrays and Lists");
                chapterCB.Items.Add("8: Text Processing");
                chapterCB.Items.Add("9: Structures, Enumerated Types, and Dictionaries");
                chapterCB.Items.Add("10: Introduction to Classes");
                chapterCB.Items.Add("11: Inheritance, Polymorphism, and Interfaces");
                chapterCB.Items.Add("12: Databases");
                chapterCB.Items.Add("13: Delegates and Lambda Expressions");
                chapterCB.Items.Add("14: Language-Integrated Query (LINQ)");
            }
            else if (bookCB.SelectedIndex == 1)
            {
                chapterCB.Items.Clear();
                chapterCB.Text = "";
                chapterCB.Items.Add("1: Classes");
                chapterCB.Items.Add("2: Input Validation and User Interfaces");
                chapterCB.Items.Add("3: Collections");
                chapterCB.Items.Add("4: Using SQL Server Databases");
                chapterCB.Items.Add("5: Database Applications");
                chapterCB.Items.Add("6: Advanced Classes");
                chapterCB.Items.Add("7: LINQ to SQL");
            }
            detailsLBL.Text = "";
            ViewButtonActivator();
        }

        private void chapterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewButtonActivator();

            // Set the details Label text according to which book & chapter is selected
            if (bookCB.SelectedIndex == 0)
            {
                switch (chapterCB.SelectedIndex)
                {
                    case 0:
                        detailsLBL.Text = "There was no programming in Chapter 1...";
                        break;
                    case 1:
                        detailsLBL.Text = "Heads or Tails \n \n This program has two pictures and two buttons; a Show Heads picture & button, and a Show Tails picture & button. When the Form loads, neither picture is visible, but once the user clicks one of the buttons, the corresponding picture appears. Only one picture is visible at a time.";
                        break;
                    case 2:
                        detailsLBL.Text = "Sentence Builder \n \n This program allows the user to create sentences by pressing buttons, which add text to a label. A perfect example of progressively adding onto a string using +=";
                        break;
                    case 3:
                        detailsLBL.Text = "Color Mixer \n \n This program allows the user to change the background color of the Form by selecting color options from two sets of Radio Buttons, and then pressing a Button to mix the colors.";
                        break;
                    case 4:
                        detailsLBL.Text = "Distance Calculator \n \n This program allows the user to calculate the distance traveled in a vehicle based on how fast the vehicle is going, and how many hours were spent travelling.";
                        break;
                    case 5:
                        detailsLBL.Text = "Rock Paper Scissors \n \n This program allows the user to play Rock Paper Scissors with a 'bot', which is just a random number.";
                        break;
                    case 6:
                        detailsLBL.Text = "Name Search \n \n This program allows the user to type a name into a TextBox, and find out if it is one of the top 200 most popular names.";
                        break;
                    case 7:
                        detailsLBL.Text = "Sum Calculator \n \n This program allows the user to input numbers into a TextBox seperated by commas (,) and then calculate the sum of all the numbers.";
                        break;
                    case 8:
                        detailsLBL.Text = "Slot Machine \n \n This program simulates a slot machine, where the user can input a specific amount of money, press a button to spin the slots, and the program returns the results.";
                        break;
                    case 9:
                        detailsLBL.Text = "Pet Class \n \n This program allows the user to input information about a pet into 3 TextBoxes, which the program then uses a class to create an Object of the user's unput, and then show the output in seperate Labels.";
                        break;
                    case 10:
                        detailsLBL.Text = "String Extension Methods \n \n This program allows the user to input data into a TextBox, and do different things with the input, using Radio Buttons to select what the program will do.";
                        break;
                    case 11:
                        detailsLBL.Text = "Personnel Database \n \n This program allows the user to see and interact with a BindingNavigator for a database, which holds info about personnel.";
                        break;
                    case 12:
                        detailsLBL.Text = "Prime Number Generator \n \n This program allows the user to input a number into a TextBox, and when they press a Button, the program finds and outputs all prime numbers from 2 up to their number.";
                        break;
                    case 13:
                        detailsLBL.Text = "Text File Analysis \n \n This program lets allows the user to view a list of words from two different Text Files, and it allows the user to filter the words using Radio Buttons which all have a unique LINQ method.";
                        break;
                }
            }
            else if (bookCB.SelectedIndex == 1)
            {
                switch (chapterCB.SelectedIndex)
                {
                    case 0:
                        detailsLBL.Text = "Elevator Simulation \n \n This program simulates an elevator going up and down, while picking up people on each floor and adding the number of passengers to the elevator. The program is completely automatic.";
                        break;
                    case 1:
                        detailsLBL.Text = "Image Album \n \n This program allows the user to select a folder with images in it, which the program then puts into a Flow Panel. The user is able to click on the smaller images, which shows it in a seperate Form by itself, blown up to a bigger size.";
                        break;
                    case 2:
                        detailsLBL.Text = "Accouts Dictionary \n \n This program allows the user to view a Dictionary of accounts, which they are able to either add new accounts, or replace the existing ones.";
                        break;
                    case 3:
                        detailsLBL.Text = "Sales Staff Salaries \n \n This program shows a DataGridView of a Database Table, which the user is able to interact with by selecting two different radio buttons, which show different results.";
                        break;
                    case 4:
                        detailsLBL.Text = "Home Repair Services \n \n This program shows an example of multiple forms, all revolved around a database, which is editable through the different forms. The user is able to look at and edit the customers and appointments that a company has in a database.";
                        break;
                    case 5:
                        detailsLBL.Text = "Weather Station Events \n \n This program shows how events raised by a class can be broadcasted to more than one class. The main form uses a random number to display a weather event every 2 seconds using a Timer, after the user clicks the Start Button. The Summary Form displays how many times each weather event has occured.";
                        break;
                    case 6:
                        detailsLBL.Text = "Grouping Karate Payments \n \n This program shows an example of grouping data from a database through a LINQ Query, and displaying it in a ListBox.";
                        break;
                }
            }
        }

        private void viewBTN_Click(object sender, EventArgs e)
        {
            // Open the Form according to which book & chapter is selected
            if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 0)
            { PopupForm form = new PopupForm(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 1)
            { B1CH2Form form = new B1CH2Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 2)
            { B1CH3Form form = new B1CH3Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 3)
            { B1CH4Form form = new B1CH4Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 4)
            { B1CH5Form form = new B1CH5Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 5)
            { B1CH6Form form = new B1CH6Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 6)
            { B1CH7Form form = new B1CH7Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 7)
            { B1CH8Form form = new B1CH8Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 8)
            { B1CH9Form form = new B1CH9Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 9)
            { B1CH10Form form = new B1CH10Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 10)
            { B1CH11Form form = new B1CH11Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 11)
            { B1CH12Form form = new B1CH12Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 12)
            { B1CH13Form form = new B1CH13Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 0 && chapterCB.SelectedIndex == 13)
            { B1CH14Form form = new B1CH14Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 0)
            { B2CH1Form form = new B2CH1Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 1)
            { B2CH2Form form = new B2CH2Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 2)
            { B2CH3Form form = new B2CH3Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 3)
            { B2CH4Form form = new B2CH4Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 4)
            { B2CH5Form form = new B2CH5Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 5)
            { B2CH6Form form = new B2CH6Form(); form.Show(); }
            else if (bookCB.SelectedIndex == 1 && chapterCB.SelectedIndex == 6)
            { B2CH7Form form = new B2CH7Form(); form.Show(); }
        }

        private void tableOfContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfContentsForm form = new TableOfContentsForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void initializeViewButtonMethodToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_Initialize&ViewButtonMethod.png"); }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_Load.png"); }

        private void bookComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_BookComboBox.png"); }

        private void chapterComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_ChapterComboBox.png"); }

        private void chapterComboBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_ChapterComboBox2.png"); }

        private void viewButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_ViewButton.png"); }

        private void tOCCodeButtonExitButtonToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\MainForm_TOC&CodeButton&ExitButton.png"); }

        private void pictureFormToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\UniversalCode_PictureForm.png"); }

        private void nameCapitalizerToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\UniversalCode_NameCapitalizer.png"); }

        private void comboBoxDrawItemToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\UniversalCode_ComboBoxDrawItem.png"); }

        private void setCursorEventsOnControlsToolStripMenuItem_Click(object sender, EventArgs e)
        { UniversalCode.PictureForm("..\\..\\..\\Screenshots\\UniversalCode_SetCursorEventsOnControls.png"); }
    }
}
