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
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SignatureRecognition.Lib
{    
    class NeuralNetwork<T>
        where T : IComparable<T>
    {
        private IBackPropagation<T> NeuralNet;
        private double maximumError = 1.0;
        private int maximumIteration = 10000;
        Dictionary<T, double[]> TrainingSet;

        public delegate void IterationChangedCallBack(object o, NeuralEventArgs args);
        public event IterationChangedCallBack IterationChanged = null;

        public NeuralNetwork(IBackPropagation<T> IBackPro, Dictionary<T, double[]> trainingSet)
        {
            NeuralNet = IBackPro;
            TrainingSet = trainingSet;
            NeuralNet.InitializeNetwork(TrainingSet);
        }

        public bool Train()
        {
            double currentError = 0;
            int currentIteration = 0;
            NeuralEventArgs Args = new NeuralEventArgs() ;

            do
            {
                currentError = 0;
                foreach (KeyValuePair<T, double[]> p in TrainingSet)
                {
                    NeuralNet.ForwardPropagate(p.Value, p.Key);
                    NeuralNet.BackPropagate();
                    currentError += NeuralNet.GetError();
                }
                
                currentIteration++;

                if (IterationChanged != null && currentIteration % 5 == 0)
                {
                    Args.CurrentError = currentError;
                    Args.CurrentIteration = currentIteration;
                    IterationChanged(this, Args);
                }

            } while (currentError > maximumError && currentIteration < maximumIteration && !Args.Stop);
                        
            if (IterationChanged != null)
            {
                Args.CurrentError = currentError;
                Args.CurrentIteration = currentIteration;
                IterationChanged(this, Args);
            }

            if (currentIteration >= maximumIteration || Args.Stop)   
                return false;//Training Not Successful
            
            return true;
        }

        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight,
            ref T MatchedLow, ref double OutputValueLow)
        {
            NeuralNet.Recognize(Input, ref MatchedHigh,ref OutputValueHight,ref MatchedLow,ref OutputValueLow);
        }

        public void SaveNetwork(string path)
        {
            FileStream FS = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, NeuralNet);
            FS.Close();
        }

        public void LoadNetwork(string path)
        {
            FileStream FS = new FileStream(path, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            NeuralNet = (IBackPropagation<T>)BF.Deserialize(FS);
            FS.Close();
        }

        public double MaximumError
        {
            get { return maximumError; }
            set { maximumError = value; }
        }

        public int MaximumIteration
        {
            get { return maximumIteration; }
            set { maximumIteration = value; }
        }
    }
}
