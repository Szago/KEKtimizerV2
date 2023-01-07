using System;
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

namespace KEKTIMIZERv2
{
    public partial class Form1 : Form
    {
        private string _selectedPath = @"C:\";
      
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button2_Click;
            selectedPathTextBox.Text = _selectedPath;


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
            progressBar1.Maximum = 1;
            progressBar1.Value += 1;

            if (checkBox1.Checked)
                progressBar1.Maximum +=4;
            if (checkBox2.Checked)
                progressBar1.Maximum +=2;
            if (checkBox3.Checked)
                progressBar1.Maximum +=2;
            if (checkBox4.Checked)
                progressBar1.Maximum +=2;
            
            
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
                System.Threading.Thread.Sleep(3000);
            }
            if(checkBox2.Checked)
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
                System.Threading.Thread.Sleep(3000);

            }
            if(checkBox3.Checked)
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
                System.Threading.Thread.Sleep(3000);
                
            }
          
            if(checkBox4.Checked)
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
                System.Threading.Thread.Sleep(3000);

            }
            MessageBox.Show("Complete!");
            progressBar1.Value = 0;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

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

       
    }
}
