using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LinearModel
{
    public class ModelCalculation
    {

  

        private readonly double[] pointsArray = new double[] {0, 5, 10, 15, 20, 25, 30, 35 , 40};


        public Tuple<List<double>, List<double>> CountFunction()
        {
            List<double> list = new List<double>();
            List<double> inFunctionResult = new List<double>();
            double result = 0;
            for (int i = 0; i < pointsArray.Length; i++)// insert your function here
            {
                var inFunction = Math.Pow(pointsArray[i],3) + Math.Pow(pointsArray[i], 2) + pointsArray[i] + 1;
                inFunctionResult.Add(inFunction);
                result += (inFunction)*CountUnknown(pointsArray[i], i);
                list.Add(result);
            }
            return Tuple.Create(inFunctionResult, list);
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
