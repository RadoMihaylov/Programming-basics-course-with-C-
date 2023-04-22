using System;
using System.Diagnostics.CodeAnalysis;

namespace _09.LeftАndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int leftNums = int.Parse(Console.ReadLine());
                leftSum += leftNums;
            }

            for (int i = 0; i < n; i++)
            {
                int rightNums = int.Parse(Console.ReadLine());
                rightSum += rightNums;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }    
    }
}
