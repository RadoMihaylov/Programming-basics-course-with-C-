using System;

namespace _04.TriangleOfDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int r = 0; r < n; r++)
            {
                Console.Write("$");
                for (int col = 1; col <= r; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
