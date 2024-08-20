using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace H2M_Profile_Switcher
{
    public partial class Form1 : Form
    {
        // Constructor: Initializes the form and checks if H2M path is set
        public Form1()
        {
            InitializeComponent();
            refreshlist();  // Refresh the profile list

            this.TopMost = true;

            // If H2M path is not set, prompt the user to set it
            if (Properties.Settings.Default.H2MPath == "")
            {
                DialogResult result = MessageBox.Show(this,"You have not set your H2M path. Please set one now.", "First run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // If OK is clicked, allow the user to set the H2M path
                if (result == DialogResult.OK)
                {
                    h2mpathselect();
                    this.TopMost = false;
                    return;
                }
                else
                {
                    // If path is not set, close the application
                    MessageBox.Show(this,"You have not set your H2M path. The program will now close", "First run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }


            // Test if dark mode is on to change to remove the background and make it darker

            if (Properties.Settings.Default.DarkMode)
            {
                DarkModeCheckBox.Checked = true;
            }

            this.TopMost = false;

        }

        // Constants for enabling window dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // DLL imports to allow dragging of the form by clicking anywhere
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Method to handle mouse down event for dragging the form
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Method to prompt the user to select the H2M path
        private void h2mpathselect()
        {
            /*using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Check if the selected path contains the expected file
                    if (File.Exists(folderDialog.SelectedPath + "\\tier0_s.dll"))
                    {
                        Properties.Settings.Default.H2MPath = folderDialog.SelectedPath;
                        Properties.Settings.Default.Save();
                        return;
                    }
                    else
                    {
                        // If the path is invalid, prompt the user to try again or close the app
                        DialogResult msgbox = MessageBox.Show(this, folderDialog.SelectedPath + " is not a valid path, please try again.\n\nMake sure you choose the same folder where your H2M.exe is located!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (msgbox == DialogResult.OK)
                        {
                            h2mpathselect();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(this,"You have not set your H2M path. The program will now close", "First run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            return;
                        }
                    }
                }
            }*/

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set dialog properties
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Applications (*.exe)|*.exe"; // You can change the filter as needed
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // Get the directory of the selected file
                string directoryPath = Path.GetDirectoryName(filePath);

                // Check if the selected path contains the expected file
                if (File.Exists(directoryPath + "\\tier0_s.dll"))
                {
                    Properties.Settings.Default.H2MPath = directoryPath;
                    Properties.Settings.Default.H2MEXE = filePath;
                    Properties.Settings.Default.Save();
                    return;
                }
                else
                {
                    // If the path is invalid, prompt the user to try again or close the app
                    DialogResult msgbox = MessageBox.Show(this, directoryPath + " is not a valid path, please try again.\n\nMake sure you choose the same folder where your H2M.exe is located!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (msgbox == DialogResult.OK)
                    {
                        h2mpathselect();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "You have not set your H2M path. The program will now close", "First run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                }
            }

        }

        // Method to copy a directory recursively
        static void CopyDirectory(string sourceDir, string destinationDir)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDir);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceDir);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();

                // Delete and recreate destination directory
                Directory.Delete(destinationDir, true);
                Directory.CreateDirectory(destinationDir);

                // Copy all files in the directory
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string tempPath = Path.Combine(destinationDir, file.Name);
                    file.CopyTo(tempPath, false);
                }

                // Copy subdirectories recursively
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destinationDir, subdir.Name);
                    CopyDirectory(subdir.FullName, tempPath);
                }
            }
            catch (Exception ex)
            {
                // Show error message if there is an exception during the copy process
                MessageBox.Show("Error! Please make sure H2M is fully closed!\n\nFor Devs: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to refresh the profile list
        private void refreshlist()
        {
            Profile_List.Items.Clear();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] directories = Directory.GetDirectories(exeDirectory);
            foreach (string d in directories)
            {
                Profile_List.Items.Add(Path.GetFileName(d.TrimEnd(Path.DirectorySeparatorChar)));
            }
        }

        // Event handler for setting a profile
        private void Set_Profile_Click(object sender, EventArgs e)
        {
            if (Profile_List.SelectedItems.Count == 0)
            {
                MessageBox.Show(this,"Please select a profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this,"You are about to replace the current H2M profile in your files with the profile that you have selected, are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Copy the selected profile to the H2M path
                    CopyDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\" + Profile_List.SelectedItems[0].ToString(), Properties.Settings.Default.H2MPath + "\\players2\\user");
                    MessageBox.Show(this,"Done, Profile \"" + Profile_List.SelectedItems[0] + "\" has been updated in H2M!", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refreshlist();
            }
        }

        // Event handler for setting the H2M path
        private void Set_H2M_Path_Click(object sender, EventArgs e)
        {
            h2mpathselect();
        }

        // Event handler to open the program's directory
        private void Program_Path_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
        }

        // Event handler to open the H2M path directory
        private void H2M_Path_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Properties.Settings.Default.H2MPath);
        }

        // Event handler to refresh the profile list
        private void Refresh_Profile_List_Click(object sender, EventArgs e)
        {
            refreshlist();
        }

        // Event handler to update the selected profile from H2M files
        private void Update_Profile_from_H2M_Click(object sender, EventArgs e)
        {
            if (Profile_List.SelectedItems.Count == 0)
            {
                MessageBox.Show(this,"Please select a profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this,"You are about to replace the current selected profile with the profile from your H2M files, are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Copy the profile from H2M files to the selected profile
                    CopyDirectory(Properties.Settings.Default.H2MPath + "\\players2\\user", AppDomain.CurrentDomain.BaseDirectory + "\\" + Profile_List.SelectedItems[0].ToString());
                    MessageBox.Show(this,"Done, Profile \"" + Profile_List.SelectedItems[0] + "\" has been updated!", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refreshlist();
            }
        }

        // Event handler to create a new profile
        private void New_Profile_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
            refreshlist();
        }

        // Event handler to delete the selected profile
        private void Delete_Profile_Click(object sender, EventArgs e)
        {
            if (Profile_List.SelectedItems.Count == 0)
            {
                MessageBox.Show(this,"Please select a profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this,"You are about to delete the current profile selected, are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the selected profile
                    Directory.Delete(Profile_List.SelectedItems[0].ToString(), true);
                    MessageBox.Show(this,"Done, Profile \"" + Profile_List.SelectedItems[0] + "\" has been deleted!", "Profile Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refreshlist();
            }
            refreshlist();
        }

        // Event handler to close the application
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler to open the ReadMe file
        private void Open_Readme_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "\\ReadMe.txt");
        }

        private void DarkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Handler for dark mode. behind the image is a backcolor. To get dark mode it just remo
            if (DarkModeCheckBox.Checked)
            {
                BackgroundImage = null;
                pictureBox1.BackgroundImage = null;
            }
            else
            {
                BackgroundImage = Properties.Resources.mw2;
                pictureBox1.BackgroundImage = Properties.Resources.mw2c;
            }
            Properties.Settings.Default.DarkMode = DarkModeCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Launch_Game_Click(object sender, EventArgs e)
        {
            //Have to do this or it wont launch :(
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.H2MEXE,
                WorkingDirectory = Properties.Settings.Default.H2MPath
            };
            Process.Start(startInfo);
        }
    }
}
