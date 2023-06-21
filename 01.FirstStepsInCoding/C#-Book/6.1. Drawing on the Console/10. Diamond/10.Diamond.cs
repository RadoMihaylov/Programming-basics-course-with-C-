using System;

namespace _10.Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 2;
            if (n % 2 == 1)
            {
                stars = 1;
            }
            int hyphen = -1;
            if (n % 2 == 0)
            {
                hyphen = 0;
            }
            
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                int left = (n - 2 - hyphen) / 2;
                Console.Write(new string ('-', left));
                Console.Write('*');
                if (hyphen >= 0 )
                {
                    Console.Write(new string('-', hyphen));
                    Console.Write('*');
                    //Console.Write(new string('-', left));
                }
                Console.Write(new string('-', left));
                hyphen += 2;
                Console.WriteLine();
            }
            hyphen -= 4;
            for (int row = 1; row < (n + 1) / 2; row++)
            {
                int left = (n - 2 - hyphen) / 2;
                Console.Write(new string('-', left));
                Console.Write('*');
                if (hyphen >= 0)
                {
                    Console.Write(new string('-', hyphen));
                    Console.Write('*');
                    //Console.Write(new string('-', left));
                }
                Console.Write(new string('-', left));
                hyphen -= 2;
                Console.WriteLine();
            }

        }
    }
}
