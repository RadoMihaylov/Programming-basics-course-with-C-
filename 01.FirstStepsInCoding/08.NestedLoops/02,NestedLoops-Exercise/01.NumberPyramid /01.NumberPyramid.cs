using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = 1;
            int currentNumber = 1;

            while (currentNumber <= n)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    if (currentNumber > n) break;
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}
