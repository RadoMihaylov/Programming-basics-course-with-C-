using System;

namespace _04.Sequence2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers = 1;

            while (numbers <= n)
            {
                Console.WriteLine(numbers);
                numbers = numbers * 2 + 1;
            }


        }
    }
}
