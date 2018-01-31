using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Tab2Calibre
{
    public partial class Form1 : Form
    {
        private List<string> filesToDelete = new List<string>();

        private string m_appPath = string.Empty;
          
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.Add("TAB");
            comboBoxType.Items.Add("CRD");
            comboBoxType.Items.Add("TXT");
            comboBoxType.SelectedIndex = 0;
            
            //Check for the "installed.dat" file
            //If there: use the appdata folder
            //If not there: use the directory for all files
            //The "installed.dat" file will be copied to the directory by the installer
            string installedPath = Path.GetDirectoryName(Application.ExecutablePath); //no final "\"
            string fname = installedPath + "\\installed.dat";
            FileInfo fi = new FileInfo(fname);
            if (File.Exists(fname)) //Use system app data path
            {
                m_appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                m_appPath += "\\Tab2Calibre";
                // Specify the directory you want to manipulate.
                try
                {
                    // Determine whether the directory exists.
                    if (!Directory.Exists(m_appPath))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(m_appPath);
                    }
                }
                catch (Exception except)
                {
                    Console.WriteLine("The directory creation process failed: {0}", except.ToString());
                }
                finally { }

            }
            else //Use app folder in portable mode
            {
                m_appPath = Path.GetDirectoryName(Application.ExecutablePath); //no final "\"
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //form the file name
            string tabName = m_appPath + "\\" + textBoxArtist.Text.Replace(" ", "") + "_" + textBoxSong.Text.Replace(" ", "");
            switch (comboBoxType.SelectedItem.ToString())
            {
                case "TAB":
                    {
                        tabName = tabName + ".tab";
                        break;
                    }
                case "CRD":
                    {
                        tabName = tabName + ".crd";
                        break;
                    }
                case "TXT":
                    {
                        tabName = tabName + ".txt";
                        break;
                    }
            }

            //create the emptyfile
            File.Open(tabName, FileMode.Create).Close();

            //Open the file in textpad
            OpenFileToEdit(tabName);

            //Add the new file to calibre
            FileInfo fi = new FileInfo(tabName);
            if (File.Exists(tabName) && fi.Length != 0) //check that the file exists and isn't empty
            {

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "cmd";
                proc.StartInfo.Arguments = "/c calibredb add \"" + tabName + "\" --library-path \"" + textBoxCalibre.Text + "\"";
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }

            //Add the file to the files to delete list
            filesToDelete.Add(tabName);
        }

        private void OpenFileToEdit(String tabName)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = textBoxTextEditor.Text;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = tabName;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Exe|*.exe";
            openFileDialog1.Title = "Text Editor Location";
            openFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (openFileDialog1.FileName != "")
            {
                textBoxTextEditor.Text = openFileDialog1.FileName;
            }

        }

        private void buttonCalibre_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selectedFolder = dialog.SelectedPath;

            textBoxCalibre.Text = selectedFolder;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save the text box data 
            Properties.Settings.Default.Save();

            //delete the temp guitar tab files
            foreach (string s in filesToDelete)
            {
                File.Delete(s);
            }

        }
    }
}