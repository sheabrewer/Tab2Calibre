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

            FillTextBoxes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //form the file name
            String appPath = Path.GetDirectoryName(Application.ExecutablePath); //no final "\"
            String tabName = appPath + "\\" + textBoxArtist.Text.Replace(" ", "") + "_" + textBoxSong.Text.Replace(" ", "");
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
            String appPath = Path.GetDirectoryName(Application.ExecutablePath); //no final "\"

            FileInfo outFile = new FileInfo(appPath + "\\tab2calibre.dat");
            StreamWriter fileOut = outFile.CreateText();

            fileOut.WriteLine(textBoxTextEditor.Text);
            fileOut.WriteLine(textBoxCalibre.Text);

            fileOut.Close();
        }

        private void FillTextBoxes()
        {
            String appPath = Path.GetDirectoryName(Application.ExecutablePath); //no final "\"
            string name = appPath + "\\tab2calibre.dat";
            FileInfo fi = new FileInfo(name);
            if (File.Exists(name) && fi.Length != 0) //check that the file exists and isn't empty
            {
                string[] readText = File.ReadAllLines(name);

                if (readText.Count() == 2)
                {
                    textBoxTextEditor.Text = readText[0];
                    textBoxCalibre.Text = readText[1];
                }

            }
        }
    }
}