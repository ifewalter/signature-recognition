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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using SignatureRecognition.Lib;

namespace SignatureRecognition
{

    public partial class TrainProcess : Form
    {
      //  public string positivePath = "" ; //= "C:\\Users\\Ghost\\Documents\\Visual Studio 2008\\Projects\\SignatureRecognition\\SignatureRecognition\\bin\\Debug\\data\\48978979831\\positives";
        
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
        public string positivePath ;
        private DateTime DTStart;

        public TrainProcess()
        {
            
            InitializeComponent();

           

        }

        private void TrainProcess_Load(object sender, EventArgs e)
        {
            
            InitializeSettings();

            GenerateTrainingSet();
            CreateNeuralNetwork();

            asyCallBack = new AsyncCallback(TraningCompleted);
            ManualReset = new ManualResetEvent(false);


            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;

            UpdateState("Began training process...\n");

            ManualReset.Reset();

            TrainingCallBack TR = new TrainingCallBack(neuralNetwork.Train);
            res = TR.BeginInvoke(asyCallBack, TR);
            DTStart = DateTime.Now;
            timer1.Start();



        }

        private void TraningCompleted(IAsyncResult result)
        {

            if (result.AsyncState is TrainingCallBack)
            {

                TrainingCallBack TR = (TrainingCallBack)result.AsyncState;

                bool isSuccess = TR.EndInvoke(res);
                if (isSuccess)
                {
                    UpdateState("Completed Training Process Successfully\r\n");
                    timer1.Stop();
                   // closeButton.Enabled = true;
                    //SaveFileDialog FD = new SaveFileDialog();
                    //FD.Filter = "Network File(*.net)|*.net";
                    //if (FD.ShowDialog() == DialogResult.OK)
                    //{ 
                    try
                    {
                        string savenet = positivePath + "\\network.net";
                        neuralNetwork.SaveNetwork(savenet);
                        UpdateProgressBar("completed");
                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                    
                    //}
                    //FD.Dispose();
                }
                else
                {
                    UpdateState("Training Process is Aborted or Exceed Maximum Iteration\r\n");
                    timer1.Stop();
                }

            }
            
        }

        private void GenerateTrainingSet()
        {
            UpdateState("Generating Training Set..");

            string[] Patterns = Directory.GetFiles(positivePath, "*.bmp");

            TrainingSet = new Dictionary<string, double[]>(Patterns.Length);
            foreach (string s in Patterns)
            {
                Bitmap Temp = new Bitmap(s);
                TrainingSet.Add(Path.GetFileNameWithoutExtension(s),
                    ImageProcessing.ToMatrix(Temp, av_ImageHeight, av_ImageWidth));
                Temp.Dispose();
            }

            UpdateState("Done!\r\n");
        }


        private void InitializeSettings()
        {
            UpdateState("Initializing Settings..");

            try
            {
                // NameValueCollection AppSettings = ConfigurationManager.AppSettings;

                //comboBoxLayers.SelectedIndex = (Int16.Parse(AppSettings["NumOfLayers"]) - 1);


                //  textBoxTrainingBrowse.Text = Path.GetFullPath(AppSettings["PatternsDirectory"]);
                //   textBoxMaxError.Text = AppSettings["MaxError"];

                //TODO: DONE: fix this settings error
               // inputunit = 258;
               // hiddenunit = 84;

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

            UpdateState("Done!\r\n");
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
                
                // int InputNum = 58;
                int HiddenNum = hiddenunit;
               //  int HiddenNum = 14;

                neuralNetwork = new NeuralNetwork<string>
                    (new Layer3<string>(av_ImageHeight * av_ImageWidth, InputNum, HiddenNum, NumOfPatterns), TrainingSet);

            }

            neuralNetwork.IterationChanged +=
                new NeuralNetwork<string>.IterationChangedCallBack(neuralNetwork_IterationChanged);

            neuralNetwork.MaximumError = maxerror;
        }

        void neuralNetwork_IterationChanged(object o, NeuralEventArgs args)
        {
            UpdateIteration(args.CurrentIteration);
            UpdateError(args.CurrentError);


            if (ManualReset.WaitOne(0, true))
            {
                args.Stop = true;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TSElapsed = DateTime.Now.Subtract(DTStart);
            UpdateTimer(TSElapsed.Hours.ToString("D2") + ":" +
                TSElapsed.Minutes.ToString("D2") + ":" +
                TSElapsed.Seconds.ToString("D2"));

        }

        private delegate void UpdateUI(object o);

        private void UpdateError(object o)
        {
            if (labelError.InvokeRequired)
            {
                labelError.Invoke(new UpdateUI(UpdateError), o);
            }
            else
            {
                labelError.Text = "Error: " + ((double)o).ToString(".###");
            }
        }
        private void UpdateIteration(object o)
        {
            if (labelIteration.InvokeRequired)
            {
                labelIteration.Invoke(new UpdateUI(UpdateIteration), o);
            }
            else
            {
                labelIteration.Text = "Iteration: " + ((int)o).ToString();
            }
        }
        private void UpdateTimer(object o)
        {
            if (timeLabel.InvokeRequired)
            {
                timeLabel.Invoke(new UpdateUI(UpdateTimer), o);
            }
            else
            {
                timeLabel.Text = (string)o;
            }
        }
        private void UpdateState(object o)
        {
            if (statusBox.InvokeRequired)
            {
                statusBox.Invoke(new UpdateUI(UpdateState), o);
            }
            else
            { 
                statusBox.AppendText((string)o);
            }
            
        }

        private void UpdateProgressBar(object o)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new UpdateUI(UpdateProgressBar), o);
            }
            else
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = 100;
                
            }
        }

        
       
    }

}
