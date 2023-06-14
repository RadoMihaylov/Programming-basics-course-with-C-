using System;

namespace _03.SquareOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 0; r < n; r++)
            {
                Console.Write('*');
                for (int c = 1; c < n; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                
            }
        }
    }
}
