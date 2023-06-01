using System;

namespace _07.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }
            for (int i = 0; i < n; i++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}");
            }
            
        }
    }
}
