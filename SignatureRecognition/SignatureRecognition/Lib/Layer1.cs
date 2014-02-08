#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * Layer1.cs
 * -------------------------------------------------------------------------
 * By
 * Murat FIRAT, June 2007
 * 
 * -------------------------------------------------------------------------
 * Description:
 * Layer1.cs Implements Single Layer Backpropagation Neural Network
 * 
 * -------------------------------------------------------------------------
 * Notes:
 * If training process takes too long, modify (mostly increase) learning rate 
 * and initial weight.
 * 
 * To modify initial weight, change x(0<x<1) and y(0<y<100) in the following
 * code segment(in InitializeNetwork(..) function):
 * 
 * PreInputLayer[i].Weights[j] = x +((double)rand.Next(0, y) / 100);
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SignatureRecognition.Lib
{
    [Serializable]
    class Layer1<T> : IBackPropagation<T> where T : IComparable<T>
    {
        private int PreInputNum;
        private int OutputNum;

        private PreInput[] PreInputLayer;
        private Output<T>[] OutputLayer;

        private double learningRate = 0.2;

        public Layer1(int preInputNum, int outputNum)
        {
            PreInputNum = preInputNum;
            OutputNum = outputNum;

            PreInputLayer = new PreInput[PreInputNum];
            OutputLayer = new Output<T>[OutputNum];
        }

        #region IBackPropagation<T> Members

        public void BackPropagate()
        {
            //Update The First Layer's Weights
            for (int j = 0; j < OutputNum; j++)
            {
                for (int i = 0; i < PreInputNum; i++)
                {
                    PreInputLayer[i].Weights[j] += LearningRate * (OutputLayer[j].Error) * PreInputLayer[i].Value;
                }
            }
        }

        public double F(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        public void ForwardPropagate(double[] pattern, T output)
        {
            int i, j;
            double total = 0.0;

            //Apply input to the network
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = pattern[i];
            }

            //Calculate The First(Output) Layer's Inputs, Outputs, Targets and Errors
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = F(total);
                OutputLayer[i].Target = OutputLayer[i].Value.CompareTo(output) == 0 ? 1.0 : 0.0;
                OutputLayer[i].Error = (OutputLayer[i].Target - OutputLayer[i].output) * (OutputLayer[i].output) * (1 - OutputLayer[i].output);
            }
        }

        public double GetError()
        {
            double total = 0.0;
            for (int j = 0; j < OutputNum; j++)
            {
                total += Math.Pow((OutputLayer[j].Target - OutputLayer[j].output), 2) / 2;
            }
            return total;
        }

        public void InitializeNetwork(Dictionary<T, double[]> TrainingSet)
        {
            Random rand = new Random();
            for (int i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Weights = new double[OutputNum];
                for (int j = 0; j < OutputNum; j++)
                {
                    PreInputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 2) / 100);
                }
            }

            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }

        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight,
            ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            //Apply Input to Network
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = Input[i];
            }

            //Find the [Two] Highest Outputs
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = F(total);
                if (OutputLayer[i].output > max)
                {
                    MatchedLow = MatchedHigh;
                    OutputValueLow = max;
                    max = OutputLayer[i].output;
                    MatchedHigh = OutputLayer[i].Value;
                    OutputValueHight = max;
                }
            }
        }

        #endregion

        public double LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }

    }
}
