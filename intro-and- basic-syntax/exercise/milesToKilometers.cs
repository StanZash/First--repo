// CONFIRMED from StanZash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take miles from the console
            double miles = double.Parse(Console.ReadLine());
            //Difference between mile and kilometer
            double kilometersInMile = 1.60934;
            // Print the result
            Console.WriteLine("{0:0.00}", miles * kilometersInMile);
        }
    }
}
