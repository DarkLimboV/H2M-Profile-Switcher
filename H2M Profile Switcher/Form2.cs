using System;
using System.IO;
using System.Windows.Forms;

namespace H2M_Profile_Switcher
{
    public partial class Form2 : Form
    {
        // Constructor for Form2
        public Form2()
        {
            InitializeComponent();  // Initialize the form components


            // Test if dark mode is on to change to remove the background and make it darker
            if (Properties.Settings.Default.DarkMode)
            {
                BackgroundImage = null;
                pictureBox1.BackgroundImage = null;
            }
            else
            {
                BackgroundImage = Properties.Resources.mw2;
                pictureBox1.BackgroundImage = Properties.Resources.mw2c;
            }
        }

        // Constants for moving the window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // Importing user32.dll functions for window movement
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Event handler to allow moving the form when the mouse is pressed on the form
        private void Form2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();  // Release the mouse capture
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);  // Send a message to move the window
            }
        }

        // Event handler for the Create button click event
        private void Create_Click(object sender, EventArgs e)
        {
            // Create a new directory with the name specified in textBox1
            Directory.CreateDirectory(textBox1.Text);
            this.Close();  // Close the form after creating the directory
        }

        // Event handler for the Cancel button click event
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form without making any changes
        }

        // Event handler for the Close button click event (this button might be redundant as Cancel already closes the form)
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form
        }
    }
}
