using System;

namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int factor1 = 1; factor1 <= 10; factor1++)
            {
                for (int factor2 = 1; factor2 <= 10; factor2++)
                {
                    int sum = factor2 * factor1;
                    Console.WriteLine($"{factor1} * {factor2} = {sum}");
                }
            }
        }
    }
}
