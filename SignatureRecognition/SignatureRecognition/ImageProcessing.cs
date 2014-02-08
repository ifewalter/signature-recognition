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
using System.Drawing;

namespace SignatureRecognition
{
    class ImageProcessing
    {
        //Convert RGB To Matrix [Of Double]
        public static double[] ToMatrix(Bitmap BM, int MatrixRowNumber, int MatrixColumnNumber)
        {
            double HRate = ((Double)MatrixRowNumber / BM.Height);
            double WRate = ((Double)MatrixColumnNumber / BM.Width);
            double[] Result = new double[MatrixColumnNumber * MatrixRowNumber];

            for (int r = 0; r < MatrixRowNumber; r++)
            {
                for (int c = 0; c < MatrixColumnNumber; c++)
                {
                    Color color = BM.GetPixel((int)(c / WRate), (int)(r / HRate));
                    Result[r * MatrixColumnNumber + c] = 1 - (color.R * .3 + color.G * .59 + color.B * .11) / 255;
                }
            }
            return Result;
        }

        //Convert Double To Grey Level  
        public static Bitmap ToImage(double[] Matrix, int MatrixRowNumber, int MatrixColumnNumber,
                                                     int ImageHeight, int ImageWidth)
        {
            double HRate = ((double)ImageHeight / MatrixRowNumber);
            double WRate = ((double)ImageWidth / MatrixColumnNumber);
            Bitmap Result = new Bitmap(ImageWidth, ImageHeight);

            for (int i = 0; i < ImageHeight; i++)
            {
                for (int j = 0; j < ImageWidth; j++)
                {
                    int x = (int)((double)j / WRate);
                    int y = (int)((double)i / HRate);

                    double temp = Matrix[y * MatrixColumnNumber + x];
                    Result.SetPixel(j, i, Color.FromArgb((int)((1 - temp) * 255), (int)((1 - temp) * 255), (int)((1 - temp) * 255)));

                }
            }
            return Result;
        }

        //public static Bitmap Scale(Bitmap Input, int newHeight, int newWidth)
        //{
        //    double HRate = (double)Input.Height / newHeight;
        //    double WRate = (double)Input.Width / newWidth;
        //    Bitmap Result = new Bitmap(newWidth, newHeight);
        //    for (int i = 0; i < newHeight; i++)
        //    {
        //        for (int j = 0; j < newWidth; j++)
        //        {
        //            int x = (int)((double)j * WRate);
        //            int y = (int)((double)i * HRate);
        //            Result.SetPixel(j, i, Input.GetPixel(x, y));
        //        }
        //    }

        //    return Result;
        //}
    }
}
