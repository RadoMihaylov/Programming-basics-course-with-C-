using System;

namespace _12.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int prevSum = 0;
            int currentSum = 0;



            for (int i = 0; i < n; i++)            
            {
                prevSum = currentSum;
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                currentSum = number1 + number2; 
                

            }
            if (prevSum == 0)
            {
                prevSum= currentSum;
            }

            if (currentSum == prevSum)
            {
                Console.WriteLine($"Yes, value={prevSum}");
            }
            else
            {
                int maxDiff = Math.Abs( prevSum - currentSum );
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }


            
        }
    }
}
