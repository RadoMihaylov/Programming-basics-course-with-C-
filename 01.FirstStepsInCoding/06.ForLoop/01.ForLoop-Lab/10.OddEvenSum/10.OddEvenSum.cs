using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenNums = 0;
            int oddNums = 0;
            for (int i = 1; i <= n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (nums % 2 != 0)
                {
                    oddNums += nums;
                }
                else
                {
                    evenNums += nums;
                }

            }
            
            
            if (oddNums == evenNums)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNums}");
            }
            else
            {
                int diff = Math.Abs(evenNums - oddNums);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
