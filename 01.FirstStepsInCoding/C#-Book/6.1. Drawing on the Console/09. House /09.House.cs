using System;
using System.ComponentModel;

namespace _09.House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = n = int.Parse(Console.ReadLine());
            var stars = 1;
            int rowCount = 0;
            if (n % 2 == 0)
            {
                stars++;
            }

            for (int row = 0; row < (n +1) / 2; row++)
            {
                var hyphens = (Math.Abs(n - stars) / 2);
                Console.Write(new string ('-', hyphens));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', hyphens));
                Console.WriteLine();  
                stars = stars + 2;
                rowCount++;
            }
            
            for (int i = 0; i < n - rowCount; i++)
            {
                Console.Write('|');
                Console.Write(new string ('*', n -2));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
