// CONFIRMED from StanZash
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take Debit Card Number from Console
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            // Print numbers 
            Console.WriteLine("{0:0000} {1:0000} {2:0000} {3:0000}", firstNum, secondNum, thirdNum, fourthNum);
        }
    }
}
