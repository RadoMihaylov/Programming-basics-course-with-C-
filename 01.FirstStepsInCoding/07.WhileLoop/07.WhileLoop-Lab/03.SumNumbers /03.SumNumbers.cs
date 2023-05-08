using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numbers = 0;
            int sum = 0;

            while (num > sum)
            {
                numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }

            Console.WriteLine(sum);
        }
    }
}
