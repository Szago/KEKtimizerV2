﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace KEKTIMIZERv2
{


    public partial class KEKtimizer : Form
    {
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
        
        private string _selectedPath = @"C:\";
        private BackgroundWorker _backgroundWorker;
        public KEKtimizer()
        {
            InitializeComponent();         
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            button1.Click += Button_Click;
            button2.Click += Button2_Click;
            selectedPathTextBox.Text = _selectedPath;

            UpdateButtonStatus();

           

    }
 
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBar1.Maximum = 1;
            progressBar1.Value += 1;

            if (checkBox1.Checked)
                progressBar1.Maximum += 4;
            if (checkBox2.Checked)
                progressBar1.Maximum += 2;
            if (checkBox3.Checked)
                progressBar1.Maximum += 2;
            if (checkBox4.Checked)
                progressBar1.Maximum += 2;
            if (checkBox5.Checked)
                progressBar1.Maximum += 2;
            if (checkBox6.Checked)
                progressBar1.Maximum += 2;
            if (checkBox7.Checked)
                progressBar1.Maximum += 2;
            if (checkBox8.Checked)
                progressBar1.Maximum += 2;




            if (checkBox1.Checked)
            {


                // Change the current directory to C:\
                Directory.SetCurrentDirectory(_selectedPath);
                progressBar1.Value += 1;
                // Create a new directory called "Backup"
                Directory.CreateDirectory(@"Backup");
                progressBar1.Value += 1;


                //regbackup
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "reg";


                process.StartInfo.Arguments = $"export HKLM \"{_selectedPath}\\Backup\\HKLM.Reg\" /y";
                process.Start();
                process.WaitForExit();
                progressBar1.Value += 1;

                process.StartInfo.Arguments = $"export HKCU \"{_selectedPath}\\Backup\\HKCU.Reg\" /y";
                process.Start();
                process.WaitForExit();
                progressBar1.Value += 1;
                
            }
            if (checkBox2.Checked)
            {
                progressBar1.Value += 1;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR");
                key.SetValue("value", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();

                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games");
                key.SetValue("GPU Priority", 8, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("Priority", 6, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("Scheduling Category", "High", Microsoft.Win32.RegistryValueKind.String);
                key.SetValue("Latency Sensitive", "True", Microsoft.Win32.RegistryValueKind.String);
                key.SetValue("SFIO Priority", "High", Microsoft.Win32.RegistryValueKind.String);
                key.Close();

                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile");
                key.SetValue("NetworkThrottlingIndex", Convert.ToInt32("ffffffff", 16), Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("SystemResponsiveness", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("NoLazyMode", 1, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("AlwaysOn", 1, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
                progressBar1.Value += 1;
                

            }
            if (checkBox3.Checked)
            {
                progressBar1.Value += 1;
                Process process2 = new Process();
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process2.StartInfo.FileName = "bcdedit";

                process2.StartInfo.Arguments = "/set useplatformclock No";
                process2.Start();
                process2.WaitForExit();

                process2.StartInfo.Arguments = "/set useplatformtick No";
                process2.Start();
                process2.WaitForExit();

                process2.StartInfo.Arguments = "/set disabledynamictick Yes";
                process2.Start();
                process2.WaitForExit();

                process2.StartInfo.Arguments = "/set tscsyncpolicy Enhanced";
                process2.Start();
                process2.WaitForExit();
                progressBar1.Value += 1;
                

            }

            if (checkBox4.Checked)
            {
                progressBar1.Value += 1;
                Process process3 = new Process();
                process3.StartInfo.FileName = "powercfg";

                process3.StartInfo.Arguments = "-duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61 95533644-e700-4a79-a56c-a89e8cb109d9";
                process3.Start();
                process3.WaitForExit();

                process3.StartInfo.Arguments = "-changename 95533644-e700-4a79-a56c-a89e8cb109d9 SPEED";
                process3.Start();
                process3.WaitForExit();

                process3.StartInfo.Arguments = "-setactive 95533644-e700-4a79-a56c-a89e8cb109d9";
                process3.Start();
                process3.WaitForExit();
                progressBar1.Value += 1;
                

            }
            if(checkBox5.Checked)
            {
                progressBar1.Value += 1;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender");
                key.SetValue("DisableAntiSpyware", 1, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
                progressBar1.Value += 1;
                
            }
            if(checkBox6.Checked)
            {
                progressBar1.Value += 1;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform");
                key.SetValue("NoGenuineNotification", 1, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
                progressBar1.Value += 1;
                
            }
            if(checkBox7.Checked)
            {
                progressBar1.Value += 1;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse");
                key.SetValue("MouseThreshold1", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("MouseThreshold2", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("MouseSpeed", 0, Microsoft.Win32.RegistryValueKind.DWord);                
                key.Close();
                progressBar1.Value += 1;
            }
            if (checkBox8.Checked)
            {
                progressBar1.Value += 1;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search");
                key.SetValue("AllowCortana", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.SetValue("BingSearchEnabled", 0, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer");
                key.SetValue("DisableSearchBoxSuggestions", 1, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();                
                progressBar1.Value += 1;
               
            }

            if (checkBox6.Checked)
            {

            }
            MessageBox.Show("Complete!");
            progressBar1.Value = 0;
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    
                    _selectedPath = dialog.SelectedPath;
                    
                    selectedPathTextBox.Text = _selectedPath;

                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            _backgroundWorker.RunWorkerAsync();
        }
        private void UpdateButtonStatus()
        {
            // Check if any of the checkboxes are checked
            bool anyChecked = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked;

            // Enable or disable the button based on whether any checkboxes are checked
            button1.Enabled = anyChecked;
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update UI or perform post-processing tasks here
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox7.Checked = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void KEKtimizer_Load(object sender, EventArgs e)
        {
        

        }
    }
}