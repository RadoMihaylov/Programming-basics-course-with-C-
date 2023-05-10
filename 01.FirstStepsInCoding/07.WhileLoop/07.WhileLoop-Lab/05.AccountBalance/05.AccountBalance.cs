using System;
using System.ComponentModel;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;            
            double total = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double currentIncome = double.Parse(input);

                if (currentIncome < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += currentIncome;
                Console.WriteLine($"Increase: {currentIncome:f2}");                
            }

            Console.WriteLine($"Total: {total:f2}");
   
        }
    }
}
