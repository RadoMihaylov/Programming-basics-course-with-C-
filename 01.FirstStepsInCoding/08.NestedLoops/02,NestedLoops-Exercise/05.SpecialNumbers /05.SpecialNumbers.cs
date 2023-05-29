using System;
using System.Runtime.InteropServices;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int number = i;
                bool isSpecial = true;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    if (lastDigit == 0 || num % lastDigit != 0)
                    {
                        isSpecial= false;
                        break;
                    }
                    
                    number /= 10;
                }
                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
                
            }
        }
    }
}
