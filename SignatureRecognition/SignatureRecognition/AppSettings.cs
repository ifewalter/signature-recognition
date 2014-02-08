using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SignatureRecognition
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double currentvalue = 0;
            currentvalue = double.Parse(comboBox1.Text);
            Properties.Settings.Default.ErrorLevel = currentvalue;
            Properties.Settings.Default.Save();
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            double currentvalue = 0;
            currentvalue = Properties.Settings.Default.ErrorLevel;
            comboBox1.Text = currentvalue.ToString();
            textBox1.Text = Properties.Settings.Default.AcceptanceLevel.ToString();
        }

        private void restoreBackup_Click(object sender, EventArgs e)
        {

            try
            {
                string fileName = "";
                OpenFileDialog browseFile = new OpenFileDialog();
                browseFile.Filter = "Signature Recognition backup File(*.srb)|*.srb";

                if (browseFile.ShowDialog() == DialogResult.OK)
                {
                    string path = browseFile.FileName;
                    fileName = path;
                }

                String srcpath = Directory.GetParent(fileName).ToString();
                copyDirtectory(srcpath, ".\\data\\");
                browseFile.Dispose();

                backupDetail.Text = "Backup restored sucessfully";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }

        private void copyDirtectory(String src, String dst)
        {
            String[] files;
            if (dst[dst.Length - 1] != Path.DirectorySeparatorChar)
                dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(dst)) Directory.CreateDirectory(dst);
            files = Directory.GetFileSystemEntries(src);
            foreach (string element in files)
            {
                if (Directory.Exists(element))
                {
                    copyDirtectory(element, dst + Path.GetFileName(element));


                }
                else
                {
                    File.Copy(element, dst + Path.GetFileName(element), true);
                }
            }
        }

        private void makebackupbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderbrowser = new FolderBrowserDialog();
                folderbrowser.ShowDialog(this);
                string savepath = folderbrowser.SelectedPath;
                copyDirtectory(".\\data\\", savepath);
                File.Create(savepath + "\\back.srb");
                backupDetail.Text = "Back up successfull";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void settingGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AcceptanceLevel = int.Parse(textBox1.Text);
        }
    }
}
