namespace H2M_Profile_Switcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close_Form1 = new System.Windows.Forms.Button();
            this.Set_Profile = new System.Windows.Forms.Button();
            this.Profile_List = new System.Windows.Forms.ListBox();
            this.Set_H2M_Path = new System.Windows.Forms.Button();
            this.H2M_Path = new System.Windows.Forms.Button();
            this.Program_Path = new System.Windows.Forms.Button();
            this.Refresh_Profile_List = new System.Windows.Forms.Button();
            this.Update_Profile_from_H2M = new System.Windows.Forms.Button();
            this.New_Profile = new System.Windows.Forms.Button();
            this.Delete_Profile = new System.Windows.Forms.Button();
            this.Open_Readme = new System.Windows.Forms.Button();
            this.DarkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.Launch_Game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "H2M Profile Selector";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Close_Form1
            // 
            this.Close_Form1.BackColor = System.Drawing.Color.Red;
            this.Close_Form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Form1.Location = new System.Drawing.Point(395, -4);
            this.Close_Form1.Name = "Close_Form1";
            this.Close_Form1.Size = new System.Drawing.Size(21, 20);
            this.Close_Form1.TabIndex = 3;
            this.Close_Form1.Text = "X";
            this.Close_Form1.UseVisualStyleBackColor = false;
            this.Close_Form1.Click += new System.EventHandler(this.Close_Click);
            // 
            // Set_Profile
            // 
            this.Set_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Set_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set_Profile.Location = new System.Drawing.Point(230, 39);
            this.Set_Profile.Name = "Set_Profile";
            this.Set_Profile.Size = new System.Drawing.Size(87, 23);
            this.Set_Profile.TabIndex = 4;
            this.Set_Profile.Text = "Set Profile";
            this.Set_Profile.UseVisualStyleBackColor = false;
            this.Set_Profile.Click += new System.EventHandler(this.Set_Profile_Click);
            // 
            // Profile_List
            // 
            this.Profile_List.BackColor = System.Drawing.SystemColors.InfoText;
            this.Profile_List.ForeColor = System.Drawing.Color.MistyRose;
            this.Profile_List.FormattingEnabled = true;
            this.Profile_List.Location = new System.Drawing.Point(20, 39);
            this.Profile_List.Name = "Profile_List";
            this.Profile_List.Size = new System.Drawing.Size(204, 82);
            this.Profile_List.TabIndex = 5;
            // 
            // Set_H2M_Path
            // 
            this.Set_H2M_Path.BackColor = System.Drawing.Color.Transparent;
            this.Set_H2M_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set_H2M_Path.Location = new System.Drawing.Point(323, 39);
            this.Set_H2M_Path.Name = "Set_H2M_Path";
            this.Set_H2M_Path.Size = new System.Drawing.Size(87, 23);
            this.Set_H2M_Path.TabIndex = 8;
            this.Set_H2M_Path.Text = "Set H2M Path";
            this.Set_H2M_Path.UseVisualStyleBackColor = false;
            this.Set_H2M_Path.Click += new System.EventHandler(this.Set_H2M_Path_Click);
            // 
            // H2M_Path
            // 
            this.H2M_Path.BackColor = System.Drawing.Color.Transparent;
            this.H2M_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H2M_Path.Location = new System.Drawing.Point(323, 68);
            this.H2M_Path.Name = "H2M_Path";
            this.H2M_Path.Size = new System.Drawing.Size(87, 23);
            this.H2M_Path.TabIndex = 9;
            this.H2M_Path.Text = "H2M Path";
            this.H2M_Path.UseVisualStyleBackColor = false;
            this.H2M_Path.Click += new System.EventHandler(this.H2M_Path_Click);
            // 
            // Program_Path
            // 
            this.Program_Path.BackColor = System.Drawing.Color.Transparent;
            this.Program_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Program_Path.Location = new System.Drawing.Point(230, 68);
            this.Program_Path.Name = "Program_Path";
            this.Program_Path.Size = new System.Drawing.Size(87, 23);
            this.Program_Path.TabIndex = 10;
            this.Program_Path.Text = "Program Path";
            this.Program_Path.UseVisualStyleBackColor = false;
            this.Program_Path.Click += new System.EventHandler(this.Program_Path_Click);
            // 
            // Refresh_Profile_List
            // 
            this.Refresh_Profile_List.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_Profile_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Profile_List.Location = new System.Drawing.Point(230, 95);
            this.Refresh_Profile_List.Name = "Refresh_Profile_List";
            this.Refresh_Profile_List.Size = new System.Drawing.Size(180, 23);
            this.Refresh_Profile_List.TabIndex = 11;
            this.Refresh_Profile_List.Text = "Refresh Profile List";
            this.Refresh_Profile_List.UseVisualStyleBackColor = false;
            this.Refresh_Profile_List.Click += new System.EventHandler(this.Refresh_Profile_List_Click);
            // 
            // Update_Profile_from_H2M
            // 
            this.Update_Profile_from_H2M.BackColor = System.Drawing.Color.Transparent;
            this.Update_Profile_from_H2M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Profile_from_H2M.Location = new System.Drawing.Point(230, 124);
            this.Update_Profile_from_H2M.Name = "Update_Profile_from_H2M";
            this.Update_Profile_from_H2M.Size = new System.Drawing.Size(180, 23);
            this.Update_Profile_from_H2M.TabIndex = 12;
            this.Update_Profile_from_H2M.Text = "Update Profile from H2M";
            this.Update_Profile_from_H2M.UseVisualStyleBackColor = false;
            this.Update_Profile_from_H2M.Click += new System.EventHandler(this.Update_Profile_from_H2M_Click);
            // 
            // New_Profile
            // 
            this.New_Profile.BackColor = System.Drawing.Color.Transparent;
            this.New_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Profile.Location = new System.Drawing.Point(20, 124);
            this.New_Profile.Name = "New_Profile";
            this.New_Profile.Size = new System.Drawing.Size(98, 23);
            this.New_Profile.TabIndex = 13;
            this.New_Profile.Text = "New Profile";
            this.New_Profile.UseVisualStyleBackColor = false;
            this.New_Profile.Click += new System.EventHandler(this.New_Profile_Click);
            // 
            // Delete_Profile
            // 
            this.Delete_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Profile.Location = new System.Drawing.Point(124, 124);
            this.Delete_Profile.Name = "Delete_Profile";
            this.Delete_Profile.Size = new System.Drawing.Size(100, 23);
            this.Delete_Profile.TabIndex = 14;
            this.Delete_Profile.Text = "Delete Profile";
            this.Delete_Profile.UseVisualStyleBackColor = false;
            this.Delete_Profile.Click += new System.EventHandler(this.Delete_Profile_Click);
            // 
            // Open_Readme
            // 
            this.Open_Readme.BackColor = System.Drawing.Color.Transparent;
            this.Open_Readme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Open_Readme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Readme.Location = new System.Drawing.Point(302, -6);
            this.Open_Readme.Name = "Open_Readme";
            this.Open_Readme.Size = new System.Drawing.Size(87, 23);
            this.Open_Readme.TabIndex = 15;
            this.Open_Readme.Text = "Open Readme";
            this.Open_Readme.UseVisualStyleBackColor = false;
            this.Open_Readme.Click += new System.EventHandler(this.Open_Readme_Click);
            // 
            // DarkModeCheckBox
            // 
            this.DarkModeCheckBox.AutoSize = true;
            this.DarkModeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DarkModeCheckBox.Location = new System.Drawing.Point(172, 6);
            this.DarkModeCheckBox.Name = "DarkModeCheckBox";
            this.DarkModeCheckBox.Size = new System.Drawing.Size(79, 17);
            this.DarkModeCheckBox.TabIndex = 16;
            this.DarkModeCheckBox.Text = "Dark Mode";
            this.DarkModeCheckBox.UseVisualStyleBackColor = false;
            this.DarkModeCheckBox.CheckedChanged += new System.EventHandler(this.DarkModeCheckBox_CheckedChanged);
            // 
            // Launch_Game
            // 
            this.Launch_Game.BackColor = System.Drawing.Color.Transparent;
            this.Launch_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch_Game.Location = new System.Drawing.Point(20, 153);
            this.Launch_Game.Name = "Launch_Game";
            this.Launch_Game.Size = new System.Drawing.Size(390, 23);
            this.Launch_Game.TabIndex = 17;
            this.Launch_Game.Text = "Launch Game";
            this.Launch_Game.UseVisualStyleBackColor = false;
            this.Launch_Game.Click += new System.EventHandler(this.Launch_Game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(428, 196);
            this.Controls.Add(this.Launch_Game);
            this.Controls.Add(this.DarkModeCheckBox);
            this.Controls.Add(this.Open_Readme);
            this.Controls.Add(this.Delete_Profile);
            this.Controls.Add(this.New_Profile);
            this.Controls.Add(this.Update_Profile_from_H2M);
            this.Controls.Add(this.Refresh_Profile_List);
            this.Controls.Add(this.Program_Path);
            this.Controls.Add(this.H2M_Path);
            this.Controls.Add(this.Set_H2M_Path);
            this.Controls.Add(this.Profile_List);
            this.Controls.Add(this.Set_Profile);
            this.Controls.Add(this.Close_Form1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "H2M Profile Switcher";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Close_Form1;
        private System.Windows.Forms.Button Set_Profile;
        private System.Windows.Forms.ListBox Profile_List;
        private System.Windows.Forms.Button Set_H2M_Path;
        private System.Windows.Forms.Button H2M_Path;
        private System.Windows.Forms.Button Program_Path;
        private System.Windows.Forms.Button Refresh_Profile_List;
        private System.Windows.Forms.Button Update_Profile_from_H2M;
        private System.Windows.Forms.Button New_Profile;
        private System.Windows.Forms.Button Delete_Profile;
        private System.Windows.Forms.Button Open_Readme;
        private System.Windows.Forms.CheckBox DarkModeCheckBox;
        private System.Windows.Forms.Button Launch_Game;
    }
}

