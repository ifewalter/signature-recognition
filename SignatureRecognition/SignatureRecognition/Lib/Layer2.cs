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

namespace SignatureRecognition.Lib
{
    [Serializable]
    class Layer2<T> : IBackPropagation<T> where T : IComparable<T>
    {
        private int PreInputNum;
        private int InputNum;
        private int OutputNum;

        private PreInput[] PreInputLayer;
        private Input[] InputLayer;
        private Output<T>[] OutputLayer;

        private double learningRate = 0.2;      

        public Layer2(int preInputNum, int inputNum, int outputNum)
        {
            PreInputNum = preInputNum;
            InputNum = inputNum;
            OutputNum = outputNum;

            PreInputLayer = new PreInput[PreInputNum];
            InputLayer = new Input[InputNum];
            OutputLayer = new Output<T>[OutputNum];          
        }

        #region IBackPropagation<T> Members
        public void BackPropagate()
        {
            int i, j;
            double total;

            //Fix Input Layer's Error
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < OutputNum; j++)
                {
                    total += InputLayer[i].Weights[j] * OutputLayer[j].Error;
                }
                InputLayer[i].Error = total;
            }

            //Update The First Layer's Weights
            for (i = 0; i < InputNum; i++)
            {
                for (j = 0; j < PreInputNum; j++)
                {
                    PreInputLayer[j].Weights[i] +=
                        learningRate * InputLayer[i].Error * PreInputLayer[j].Value;
                }
            }

            //Update The Second Layer's Weights
            for (i = 0; i < OutputNum; i++)
            {
                for (j = 0; j < InputNum; j++)
                {
                    InputLayer[j].Weights[i] +=
                        learningRate * OutputLayer[i].Error * InputLayer[j].Output;
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

            //Calculate The First(Input) Layer's Inputs and Outputs
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }

                InputLayer[i].InputSum = total;
                InputLayer[i].Output = F(total);
            }

            //Calculate The Second(Output) Layer's Inputs, Outputs, Targets and Errors
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
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
            int i, j;
            Random rand = new Random();
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Weights = new double[InputNum];
                for (j = 0; j < InputNum; j++)
                {
                    PreInputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Weights = new double[OutputNum];
                for (j = 0; j < OutputNum; j++)
                {
                    InputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }

        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight, ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            //Apply input to the network
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = Input[i];
            }

            //Calculate Input Layer's Inputs and Outputs
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                InputLayer[i].InputSum = total;
                InputLayer[i].Output = F(total);
            }

            //Find the [Two] Highest Outputs   
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
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
