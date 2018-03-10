// CONFIRMED from StanZash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace label
{
    class Program
    {
        static void Main(string[] args)
        {
            // We recieve from the Console the product name -> a string;
            string productName = Console.ReadLine();

            /* In the next three lines, we recieve volume,
             * energy and sugar content of our product,
             * as and integer */
            double productVolume = double.Parse(Console.ReadLine());
            double productEnergy = double.Parse(Console.ReadLine());
            double productSugar = double.Parse(Console.ReadLine());

            // We calculate energy and sugars
            double energy = productVolume / 100.00 * productEnergy;
            double sugars = productVolume / 100.00 * productSugar;
            // We print the results
            Console.WriteLine("{0}ml {1}:", productVolume, productName);
            Console.WriteLine("{0}kcal, {1}g sugars", energy, sugars);
        }
    }
}
