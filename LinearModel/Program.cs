using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new ModelCalculation().CountFunction();
            Print(result.Item1);
            Console.WriteLine("\n");
            Print(result.Item2);
            Console.ReadKey();
        }


        private static void Print(List<double> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
