using System;
using System.Collections.Generic;

namespace LinearModel
{
    public class ModelCalculation
    {

  

        private readonly double[] pointsArray = new double[] { 0.1, 0.5, 1.78, 2, 3.9, 5 };

        public List<double> CountFunction()
        {
            List<double> list = new List<double>();
            double result = 0;
            for (int i = 0; i < pointsArray.Length; i++)// insert your function here
            {
                result += (Math.Pow(pointsArray[i], 3) + Math.Sqrt(pointsArray[i]) + 28)*CountUnknown(2.8, i);
                list.Add(result);
            }
            return list;
        }



        private double CountUnknown(double xFromMainFunction, int index)
        {
            double result = 0.0;
            for (int i = 0; i < pointsArray.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (result == 0.0)
                {
                    result = (xFromMainFunction - pointsArray[i])/(pointsArray[index] - pointsArray[i]);
                }
                else
                {
                    result *= (xFromMainFunction - pointsArray[i]) / (pointsArray[index] - pointsArray[i]);
                }
            }
            return result;
        }
    }
}
