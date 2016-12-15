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
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
