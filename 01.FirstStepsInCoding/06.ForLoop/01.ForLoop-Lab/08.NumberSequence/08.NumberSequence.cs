using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue; 
            int maxNumber = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (minNumber > currentNum)
                {
                    minNumber = currentNum;
                }

                if (maxNumber < currentNum) 
                {
                    maxNumber = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
