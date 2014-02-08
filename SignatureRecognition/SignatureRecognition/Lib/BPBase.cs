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
    struct PreInput
    {
        public double Value;
        public double[] Weights;
    };
    [Serializable]
    struct Input
    {
        public double InputSum;
        public double Output;
        public double Error;
        public double[] Weights;
    };
    [Serializable]
    struct Hidden
    {
        public double InputSum;
        public double Output;
        public double Error;
        public double[] Weights;
    };
   
    [Serializable]
    struct Output<T> where T : IComparable<T>
    {
        public double InputSum;
        public double output;
        public double Error;
        public double Target;
        public T Value;
    };

    public class NeuralEventArgs : EventArgs
    {
        public bool Stop = false;
        public double CurrentError = 0;
        public int CurrentIteration = 0;
    }

}
