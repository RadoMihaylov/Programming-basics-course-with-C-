using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0; 
            int p2 = 0; 
            int p3 = 0; 
            int p4 = 0;
            int p5 = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentCount = int.Parse(Console.ReadLine());
                sum += currentCount;
                
                if (currentCount <= 5)
                {
                    p1 += currentCount;
                }
                else if (currentCount <= 12)
                {
                    p2 += currentCount;
                }
                else if (currentCount <= 25)
                {
                    p3 += currentCount;
                }
                else if (currentCount <= 40)
                {
                    p4 += currentCount;

                }
                else if (currentCount >= 41)
                {
                    p5 += currentCount;
                }

            }
            Console.WriteLine($"{(double)p1 / sum * 100:f2}%");
            Console.WriteLine($"{(double)p2 / sum * 100:f2}%");
            Console.WriteLine($"{(double)p3 / sum * 100:f2}%");
            Console.WriteLine($"{(double)p4 / sum * 100:f2}%");
            Console.WriteLine($"{(double)p5 / sum * 100:f2}%");

        }
    }
}
