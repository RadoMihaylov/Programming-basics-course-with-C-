using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (max < num)
                {
                    max = num;
                }
            }

            int sumWithoutMax = Math.Abs(sum - max);
            if (max != sumWithoutMax)
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
            else if (max == sumWithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }


        }
    }
}
