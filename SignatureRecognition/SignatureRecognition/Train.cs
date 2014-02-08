#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * IBackPropagation.cs
 * -------------------------------------------------------------------------
 * By
 * Ronke Ajibade, Ifeoluwa Okpah, Murat FIRAT, - April 2011
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion
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
    public partial class Train : Form
    {
        //Declare Constants
        private const string FILTER = "Bitmap Image(*.bmp)|*.bmp";

        //Declare Variables
        private string[] imageCollection = new string[9];


        public Train()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            browseImage(signature8, 8);
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            
            int errorCount = 0;
            errorCount = verifyInput();
         
            if (errorCount < 1)
            {
                copyImagesToFolder();
                TrainProcess tp = new TrainProcess();
                tp.positivePath = ".\\data\\" + idTextBox.Text + "\\positives";
                tp.TopLevel = true;
                tp.Show();
                this.Close();
                
            }
         
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseImage(PictureBox pictureBox, int signatureNumber)
        {
            string fileName = "";
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = FILTER;

            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                string path = browseFile.FileName;
                fileName = path;
            }
            browseFile.Dispose();
            pictureBox.ImageLocation = fileName;
            imageCollection[signatureNumber] = fileName;
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            browseImage(signature1, 1);
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            browseImage(signature2, 2);
        }

        private void browseButton3_Click(object sender, EventArgs e)
        {
            browseImage(signature3, 3);
        }

        private void browseButton4_Click(object sender, EventArgs e)
        {
            browseImage(signature4, 4);
        }

        private void browseButton5_Click(object sender, EventArgs e)
        {
            browseImage(signature5, 5);
        }

        private void browseButton6_Click(object sender, EventArgs e)
        {
            browseImage(signature6, 6);
        }

        private void browseButton7_Click(object sender, EventArgs e)
        {
            browseImage(signature7, 7);
        }

        private int verifyInput()
        {
            //decalre local variables
            int errorCount = 0;
            string errorMsg = "";

            //verify if an ID was entered
            if (idTextBox.Text == "")
            {
                errorCount += 1;
                errorMsg = "Please give an ID for the signature";
            }

            //TODO: check the existence of the account

            //if (nameBox1.Text == "")
            //{
            //    errorCount += 1;
            //    errorMsg = "Please give an name for the signature";
            //}
            for (int i = 1; i < 9; i++)
            {
                try
                {
                    string ifg = imageCollection.GetValue(i).ToString();

                    if (ifg == "")
                    {
                        errorCount += 1;
                        errorMsg = ("\n Please select signature " + i);
                    }
                }
                catch (Exception)
                {

                    errorCount += 1;
                    errorMsg += ("\n Please select signature " + i);

                }

            }

            if (errorCount > 0)
            {
                MessageBox.Show(errorMsg);
            }
            return errorCount;
        }

        private void copyImagesToFolder()
        {
            try
            {
                Directory.CreateDirectory((".\\data\\" + idTextBox.Text + "\\positives"));
            }
            catch (Exception)
            {

                MessageBox.Show("Error creating folder");
            }

            for (int i = 1; i < 9; i++)
            {
                try
                {
                    string ifg = imageCollection.GetValue(i).ToString();

                    File.Copy(ifg, (".\\data\\"+idTextBox.Text+"\\positives\\"+i.ToString()+".bmp"));

                }
                catch (Exception)
                {

                    MessageBox.Show("Error copying file"); ;

                }

            }
            
            
        }

        private void Train_Load(object sender, EventArgs e)
        {
            
        }

       
        private void idTextBox_DoneEditing(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                if (Directory.Exists(".\\data\\" + idTextBox.Text + "\\positives"))
                {
                    MessageBox.Show(this, "Account already exists. Please give another account identity. \n Otherwise existing account will be overwritten.", "Existing account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void idGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
