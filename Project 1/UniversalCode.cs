using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    static class UniversalCode
    {
        public static void PictureForm(string imgPath)
        {
            /* Create a new Form the size of the picture put in 
               the PictureBox, which is docked to fill the form */
            Form form = new Form();
            Bitmap img = new Bitmap(imgPath);

            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.Width = img.Width + 16;
            form.Height = img.Height + 39;
            form.BackColor = Color.White;
            form.Padding = new Padding(5, 0, 5, 5);
            form.ShowIcon = false;
            form.Text = imgPath;

            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = img;

            form.Controls.Add(pb);
            form.Show();
        }

        public static string NameCapitalizer(string name)
        {
            // Used to capitalize the first letter in the user's input name (if needed)
            string Name = name;
            char[] chars = name.ToCharArray();

            if (char.IsLower(chars[0]))
            {
                Name = "";
                chars[0] = char.ToUpper(chars[0]);

                foreach (char c in chars)
                { Name += c; }
            }
            return Name;
        }

        public static void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    if ((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit)
                    {
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                    }

                    /* Set the Brush to ComboBox ForeColor to maintain any 
                       ComboBox color settings Assumes Brush is solid */
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    { brush = SystemBrushes.HighlightText; }

                    // Draw the string
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        public static void SetCursorEventsOnControls(Control parent, Cursor cursor)
        {
            /* If the Control type is a Container, run the ChangeCursor Method to affect the Cursor for the specified 
               Controls inside the Container, and change the Cursor for the specified Controls outside of Containers */
            Type type = parent.GetType();

            if (type == typeof(Panel) || type == typeof(GroupBox))
            {
                foreach (Control c in parent.Controls)
                {
                    type = c.GetType();

                    if (type == typeof(Button) || type == typeof(ComboBox) || type == typeof(CheckBox) || type == typeof(RadioButton))
                    {
                        c.Cursor = Cursors.Hand;
                    }
                }
            }
            else
            {
                if (type == typeof(Button) || type == typeof(ComboBox) || type == typeof(CheckBox) || type == typeof(RadioButton)
                    || type == typeof(DateTimePicker))
                {
                    parent.Cursor = Cursors.Hand;

                    foreach (Control c in parent.Controls)
                    { SetCursorEventsOnControls(c, cursor); }
                }
            }
        }
    }
}
