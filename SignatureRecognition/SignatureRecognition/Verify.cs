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
using System.Threading;
using System.Windows.Forms;
using System.IO;
using SignatureRecognition.Lib;

namespace SignatureRecognition
{
    public partial class Verify : Form
    {
        private int numberoflayers = 2;
        private int inputunit;
        private int hiddenunit;
        private double maxerror = 1.1;
        private string outputunit;

        //Neural Network Object With Output Type String
        private NeuralNetwork<string> neuralNetwork = null;

        //Data Members Required For Neural Network
        private Dictionary<string, double[]> TrainingSet = null;
        private int av_ImageHeight = 0;
        private int av_ImageWidth = 0;
        private int NumOfPatterns = 0;

        //For Asynchronized Programming Instead of Handling Threads
        private delegate bool TrainingCallBack();
        private AsyncCallback asyCallBack = null;
        private IAsyncResult res = null;
        private ManualResetEvent ManualReset = null;
        public string positivePath;
        


        //For Asynchronized Programming Instead of Handling Threads
        //private delegate bool TrainingCallBack();
       // private AsyncCallback asyCallBack = null;
        //private IAsyncResult res = null;
        //private ManualResetEvent ManualReset = null;

        
        private string matchedlow;

        public Verify()
        {
            InitializeComponent();

           
            
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            positivePath = ".\\data\\" + idTextBox.Text + "\\positives";
            InitializeSettings();
            GenerateTrainingSet();
            CreateNeuralNetwork();

            try
            {
               neuralNetwork.LoadNetwork((positivePath + "\\network.net"));


                string MatchedHigh = "?", MatchedLow = "?";
                double OutputValueHight = 0, OutputValueLow = 0;
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                double[] input = ImageProcessing.ToMatrix(bitmap,
                    av_ImageHeight, av_ImageWidth);

                neuralNetwork.Recognize(input, ref MatchedHigh, ref OutputValueHight,
                    ref MatchedLow, ref OutputValueLow);

                ShowRecognitionResults(MatchedHigh, MatchedLow, OutputValueHight, OutputValueLow);

            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            
        }
        private void ShowRecognitionResults(string MatchedHigh, string MatchedLow, double OutputValueHight, double OutputValueLow)
        {
            //    Result.Text = "Accuracy level =  (" +        Result.Text = "Accuracy level = " + MatchedHigh + " (%" + ((int)100 * OutputValueHight).ToString("##") + ")";
            double accuracylevel = 100 * OutputValueHight;
            if (accuracylevel >= Properties.Settings.Default.AcceptanceLevel)
            {
                Result.Text = "Signature Accepted";
            }
            else
            {
                Result.Text = "Signature Rejected";
            }
          //  matchedlow = "Low: " + MatchedLow + " (%" + ((int)100 * OutputValueLow).ToString("##") + ")";
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "Bitmap Image(*.bmp)|*.bmp";


            if (FD.ShowDialog() == DialogResult.OK)
            {
                string FileName = FD.FileName;
                if (Path.GetExtension(FileName) == ".bmp")
                {
                    pictureBox1.Image = new Bitmap(
                    new Bitmap(FileName), pictureBox1.Width, pictureBox1.Height);

                    verifyButton.Enabled = true;
                }
            }
            FD.Dispose();
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            verifyButton.Enabled = false;
            browseButton.Enabled = false;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                browseButton.Enabled = true;
            }
            else
            {
                browseButton.Enabled = false;
            }
        }

        private void GenerateTrainingSet()
        {
            string[] Patterns = Directory.GetFiles(positivePath, "*.bmp");

            TrainingSet = new Dictionary<string, double[]>(Patterns.Length);
            foreach (string s in Patterns)
            {
                Bitmap Temp = new Bitmap(s);
                TrainingSet.Add(Path.GetFileNameWithoutExtension(s),
                    ImageProcessing.ToMatrix(Temp, av_ImageHeight, av_ImageWidth));
                Temp.Dispose();
            }
        }


        private void InitializeSettings()
        {
            try
            {
                //MessageBox.Show(positivePath);
                string[] Images = Directory.GetFiles(positivePath, "*.bmp");
                NumOfPatterns = Images.Length;

                av_ImageHeight = 0;
                av_ImageWidth = 0;

                foreach (string s in Images)
                {
                    Bitmap Temp = new Bitmap(s);
                    av_ImageHeight += Temp.Height;
                    av_ImageWidth += Temp.Width;
                    Temp.Dispose();
                }
                av_ImageHeight /= NumOfPatterns;
                av_ImageWidth /= NumOfPatterns;

                int networkInput = av_ImageHeight * av_ImageWidth;

                inputunit = ((int)((double)(networkInput + NumOfPatterns) * .33));
                hiddenunit = ((int)((double)(networkInput + NumOfPatterns) * .11));
                outputunit = NumOfPatterns.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Initializing Settings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateNeuralNetwork()
        {


            if (TrainingSet == null)
                throw new Exception("Unable to Create Neural Network As There is No Data to Train..");

            if (numberoflayers == 0)
            {

                neuralNetwork = new NeuralNetwork<string>
                    (new Layer1<string>(av_ImageHeight * av_ImageWidth, NumOfPatterns), TrainingSet);


            }
            else if (numberoflayers == 1)
            {
                int InputNum = inputunit;

                neuralNetwork = new NeuralNetwork<string>
                    (new Layer2<string>(av_ImageHeight * av_ImageWidth, InputNum, NumOfPatterns), TrainingSet);

            }
            else if (numberoflayers == 2)
            {
                int InputNum = inputunit;

                int HiddenNum = hiddenunit;
                
                neuralNetwork = new NeuralNetwork<string>
                    (new Layer3<string>(av_ImageHeight * av_ImageWidth, InputNum, HiddenNum, NumOfPatterns), TrainingSet);
            }

            neuralNetwork.IterationChanged +=
                new NeuralNetwork<string>.IterationChangedCallBack(neuralNetwork_IterationChanged);

            neuralNetwork.MaximumError = maxerror;
        }

        void neuralNetwork_IterationChanged(object o, NeuralEventArgs args)
        {
            if (ManualReset.WaitOne(0, true))
            {
                args.Stop = true;
            }
        }
    }
}
